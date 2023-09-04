using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using HtmlDoc = HtmlAgilityPack.HtmlDocument;

using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace FurAffinity
{
    public partial class MainForm : Form
    {
        #region Variables
        public static MainForm form;
        public NotificationHistory history = new NotificationHistory();
        public List<PostData> favoritedPosts = new List<PostData>();
        public List<PostItem> favoritedItems = new List<PostItem>();
        public static string profileDir = SettingsForm.preferences.profilePath;
        public static Profile profile = new Profile();
        public static CoreWebView2Environment webViewEnvironment;
        public static string absoluteProfileDir;

        // XPaths
        const string notificationXPath = "//*[@id=\"ddmenu\"]/ul/li[7]";
        #endregion

        #region Initialization
        public MainForm(string[] args)
        {
            form = this;

            absoluteProfileDir = InitializeEnvironment(args);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            InitializeProfile(absoluteProfileDir);
            InitializeComponent();

            webBrowser.EnsureCoreWebView2Async(webViewEnvironment);
            webBrowser.BackColor = Color.Black;
            webBrowser.CoreWebView2InitializationCompleted += WebBrowser_CoreWebView2InitializationCompleted;

            StartWatchingNotification(watchDuration);
            CreateDir(SettingsForm.preferences.imageDirPath.FixPath());
            LoadFavorites();

            checkBackgroundBox.Checked = SettingsForm.preferences.checkInBackground;

            SetupView();
            FAScraper.onLoadedFinish += UpdateNotifications;
        }

        private static string InitializeEnvironment(string[] args)
        {
            string profilePath = GetProfilePathFromArgs(args);

            var profDir = profilePath.FixPath();
            CreateDir(profDir.FixPath());

            string browserPath = null;

            if (Directory.Exists("WebView2".FixPath()))
                browserPath = "WebView2".FixPath();

            var envTask = CoreWebView2Environment.CreateAsync(browserPath, profDir);
            envTask.Wait();
            webViewEnvironment = envTask.Result;
            return profDir;
        }

        private void InitializeProfile(string profDir)
        {
            var profileJson = Path.Combine(profDir, "profile.json");

            if (File.Exists(profileJson))
            {
                var data = File.ReadAllText(profileJson);
                profile = JsonConvert.DeserializeObject<Profile>(data);
            }
            else
            {
                profile = new Profile();
                profile.profileName = Path.GetFileName(profDir) == "ProfileData" ? "Default" : Path.GetFileName(profDir);
                profile.profileDir = profDir;
                SaveProfile();
            }
        }

        private static string GetProfilePathFromArgs(string[] args)
        {
            // Find profile argument
            var profilePath = profileDir;
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
                if (args.Length > 1)
                {
                    Console.WriteLine(args[1]);
                }

                var arg = args[0];
                if (arg.Contains("-profile=") && !arg.Contains("ProfileData"))
                {
                    profilePath = arg.Replace("-profile=", "");
                    CreateDir(profilePath);
                    SettingsForm.preferencesPath = $"preferences{Path.GetFileName(profilePath)}.json".FixPath();

                    SettingsForm.ReInit();
                    SettingsForm.preferences.profilePath = profilePath;
                    SettingsForm.Save();
                }
            }

            return profilePath;
        }

        public WebView2 SetupView()
        {
            var webView = new WebView2();
            var task = webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.CoreWebView2InitializationCompleted += (s, e) => {
                webView.CoreWebView2.Navigate(FAScraper.tosUrl);
                Console.WriteLine("WebView for Notification background initialized");
                FAScraper.SetView(webView);
            };
            return webView;
        }

        public void SaveProfile()
        {
            var profDir = profileDir.FixPath();
            var profileJson = Path.Combine(profDir, "profile.json");
            File.WriteAllText(profileJson, JsonConvert.SerializeObject(profile, Formatting.Indented));
        }
        #endregion

        #region Toolbar
        private void backButton_Click(object sender, EventArgs e) => webBrowser.GoBack();
        private void nextButton_Click(object sender, EventArgs e) => webBrowser.GoForward();
        private void reloadButton_Click(object sender, EventArgs e) => webBrowser.Reload();

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                webBrowser.CoreWebView2.Navigate(urlBox.Text);

            if (e.KeyCode == Keys.Escape)
                urlBox.Text = webBrowser.Source.AbsoluteUri;

            MainForm_KeyDown(sender, e);
        }
        #endregion

        #region Browser
        public void NavigateTo(string url) => webBrowser.CoreWebView2.Navigate(url);

        public async Task<string> GetHtmlFromBrowser()
        {
            var task = webBrowser.CoreWebView2.ExecuteScriptAsync("document.body.outerHTML");
            var html = await task;
            return JsonConvert.DeserializeObject(html).ToString();
        }

        private void WebBrowser_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/");

            webBrowser.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            webBrowser.CoreWebView2.NavigationCompleted += WebBrowser_Navigated;
            webBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            webBrowser.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;

            webBrowser.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
            webBrowser.CoreWebView2.ContextMenuRequested += CoreWebView2_ContextMenuRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            if (!e.Uri.Contains("//www.furaffinity.net"))
            {
                System.Diagnostics.Process.Start(e.Uri);
                e.Handled = true;
            }
        }

        private void WebBrowser_Navigated(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var uri = webBrowser.Source.AbsoluteUri;
            favoritePostButton.Enabled = uri.Contains("net/view/");
        }

        private void CoreWebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {   
            if(e.Uri.Contains("//www.furaffinity.net"))
            {
                urlBox.Text = e.Uri;
            }
            else
            {
                if (MessageBox.Show($"This page leads you to {e.Uri}, do you want to open it in your browser?", "FurAffinity: External Links", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(e.Uri);
                e.Cancel = true;
            }
        }

        private async void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e) =>
            UpdateNotifications(await GetHtmlFromBrowser());

        private void CoreWebView2_ContextMenuRequested(object sender, CoreWebView2ContextMenuRequestedEventArgs e)
        {
            // Add new item to end of collection
            var env = webBrowser.CoreWebView2.Environment;
            string url = webBrowser.Source.AbsoluteUri;
            if (url.Contains("net/view/"))
            {
                string name = IsFavoriteExist(url) ? "Remove post from favorite" : "Add post to favorite";
                var newItem = env.CreateContextMenuItem(name, null, CoreWebView2ContextMenuItemKind.Command);
                newItem.CustomItemSelected += delegate (object send, Object ex)
                {
                    System.Threading.SynchronizationContext.Current.Post((_) =>
                    {
                        AddFavorite();
                    },
                    null);
                };
                e.MenuItems.Insert(1, newItem);
            }
        }

        public void UpdateFavoriteButtonState(string html)
        {
            var brows = html;
            Invoke(new Action(() => {
                bool isValid = PostItem.IsHtmlAValidPost(brows);
                favoritePostButton.Enabled = isValid;
                if (isValid)
                {
                    var isOnList = favoritedPosts.Find(val => val.url == webBrowser.Source.AbsoluteUri) != null;
                    favoritePostButton.Text = isOnList ? "Remove Favorite" : "Local Favorite";
                }
            }));
        }
        #endregion

        #region Favorites
        private void favoritePostButton_Click(object sender, EventArgs e)
        {
            AddFavorite();
        }

        public async void AddFavorite()
        {
            var post = favoritedPosts.Find(val => val.url == webBrowser.Source.AbsoluteUri);
            if (post != null)
            {
                favoritePostButton.Text = "Local Favorite";
                favoritedPosts.Remove(post);
                var item = favoritedItems.Find(val => val.postData.url == webBrowser.Source.AbsoluteUri);
                if (item != null)
                {
                    favoritePostsLayout.Controls.Remove(item);
                    favoritedItems.Remove(item);
                    item.Dispose();
                }
                SaveFavorites();
            }
            else
            {
                favoritePostButton.Text = "Remove Favorite";
                var html = await GetHtmlFromBrowser();
                Invoke(new Action(() => {
                    var item = new PostItem(urlBox.Text, html);
                    favoritedPosts.Add(item.postData);
                    favoritedItems.Add(item);
                    favoritePostsLayout.Controls.Add(item);
                    SaveFavorites();
                }));
            }
        }

        public void SaveFavorites()
        {
            File.WriteAllText(FavoritePath, JsonConvert.SerializeObject(favoritedPosts, Formatting.Indented));
        }

        public void LoadFavorites()
        {
            if(File.Exists(FavoritePath))
            {
                favoritedPosts = JsonConvert.DeserializeObject<List<PostData>>(File.ReadAllText(FavoritePath));
                foreach(var post in favoritedPosts)
                {
                    var item = new PostItem(post.url, post.html);
                    favoritedItems.Add(item);
                    favoritePostsLayout.Controls.Add(item);
                }
            }
        }

        public string FavoritePath => Path.Combine(absoluteProfileDir, "favorites.json");

        public bool IsFavoriteExist(string url)
        {
            return favoritedPosts.Exists(val => val.url == url);
        }

        public void RemoveFavoritePost(PostData data)
        {
            var post = favoritedPosts.Find(val => val.url == data.url);
            if (post != null)
            {
                if (data.url == webBrowser.Source.AbsoluteUri)
                {
                    favoritePostButton.Text = "Local Favorite";
                }
                favoritedPosts.Remove(post);
                var item = favoritedItems.Find(val => val.postData.url == data.url);
                if (item != null)
                {
                    favoritePostsLayout.Controls.Remove(item);
                    favoritedItems.Remove(item);
                    item.Dispose();
                }
                SaveFavorites();
            }
        }
        #endregion

        #region Tray Icon
        static bool isForceQuit;
        static bool stayOnTray => SettingsForm.preferences.hideOnTray;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(stayOnTray)
            {
                e.Cancel = !isForceQuit;
                if(!isForceQuit)
                    Hide();
            }
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isForceQuit = true;
            Close();
        }

        private void notifIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                Show();
        }

        private void notifIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
        }
        #endregion

        #region Notification
        int watchDuration => SettingsForm.preferences.watchInterval * 60000;
        Timer notifWatchTimer;
        
        public void CheckForNotification() => FAScraper.webView.Reload();
        public void StartWatchingNotification(int interval)
        {
            if (notifWatchTimer != null) notifWatchTimer.Dispose();

            notifWatchTimer = new Timer();
            notifWatchTimer.Interval = interval;
            notifWatchTimer.Tick += (a, e) => {
                if (!SettingsForm.preferences.checkInBackground) return;
                
                if(Focused) return;
                
                FAScraper.webView.Reload();
                Console.WriteLine("Scraper: Scraper's webview is reloading");
            };
            notifWatchTimer.Start();
        }

        public void UpdateNotifications(string html)
        {
            var htmlDoc = new HtmlDoc();
            var previous = history.Clone();
            var newHistory = new NotificationHistory();

            try
            {
                htmlDoc.LoadHtml(html);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var notifNode = htmlDoc.DocumentNode.SelectSingleNode(notificationXPath);
            if (notifNode != null)
            {
                var nodes = notifNode.SelectNodes("a");
                if (nodes != null)
                {
                    foreach (var node in nodes)
                    {
                        var attribute = node.GetAttributeValue("href", null);
                        switch (attribute)
                        {
                            case "/msg/submissions/":
                                notifSubsButton.Text = "Submissions: " + node.InnerText.Replace("S", "");
                                if (int.TryParse(node.InnerText.Replace("S", ""), out int si)) newHistory.submission = si;
                                break;
                            case "/msg/others/#comments":
                                notifCommentsButton.Text = "Comments: " + node.InnerText.Replace("C", "");
                                if (int.TryParse(node.InnerText.Replace("C", ""), out int ci)) newHistory.comments = ci;
                                break;
                            case "/msg/others/#favorites":
                                notifFavesButton.Text = "Favorites: " + node.InnerText.Replace("F", "");
                                if (int.TryParse(node.InnerText.Replace("F", ""), out int fi)) newHistory.favorites = fi;
                                break;
                            case "/msg/others/#journals":
                                notifJournalsButton.Text = "Journals: " + node.InnerText.Replace("J", "");
                                if (int.TryParse(node.InnerText.Replace("J", ""), out int ji)) newHistory.journals = ji;
                                break;
                            case "/msg/others/#watches":
                                notifWatchersButton.Text = "Watches: " + node.InnerText.Replace("W", "");
                                if (int.TryParse(node.InnerText.Replace("W", ""), out int wi)) newHistory.watchers = wi;
                                break;
                            case "/msg/pms/":
                                notifMessagesButton.Text = "Messages: " + node.InnerText.Replace("N", "");
                                if (int.TryParse(node.InnerText.Replace("N", ""), out int ni)) newHistory.notes = ni;
                                break;
                            default:
                                break;
                        }
                    }
                    history = newHistory;
                }
                else
                {
                    history = new NotificationHistory();
                }
                RefreshNotificationInterface();
            }

            if (SettingsForm.preferences.checkInBackground)
            {
                var message = history.GetNotificationChange(previous);
                if (!string.IsNullOrWhiteSpace(message))
                    notifIcon.ShowBalloonTip(5000, "New Notifications", message, ToolTipIcon.Info);
            }
        }

        private void checkManualButton_Click(object sender, EventArgs e)
        {
            CheckForNotification();
        }

        public void RefreshNotificationInterface()
        {
            notifSubsButton.Text = "Submissions: " + history.submission;
            notifCommentsButton.Text = "Comments: " + history.comments;
            notifFavesButton.Text = "Favorites: " + history.favorites;
            notifJournalsButton.Text = "Journals: " + history.journals;
            notifWatchersButton.Text = "Watches: " + history.watchers;
            notifMessagesButton.Text = "Messages: " + history.notes;
        }

        private void notifSubsButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/submissions/");

        private void notifFavesButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/others/#favorites");

        private void notifWatchersButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/others/#watches");

        private void notifJournalsButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/others/#journals");

        private void notifCommentsButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/others/#comments");

        private void notifMessagesButton_Click(object sender, EventArgs e) =>
            webBrowser.CoreWebView2.Navigate("https://www.furaffinity.net/msg/pms");
        #endregion

        #region Settings
        private void settingsButton_Click(object sender, EventArgs e) => SettingsForm.ShowAvailable();
        private void cibBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsForm.preferences.checkInBackground = checkBackgroundBox.Checked;
            SettingsForm.Save();
        }
        #endregion

        #region Keys
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                bool to = !sidePanel.Visible;
                sidePanel.Visible = to;
                topPanel.Visible = to;
            }
        }
        #endregion

        #region Utility
        public static void CreateDir(string dir)
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        }
        #endregion
    }

    #region Classes
    public enum MessageType
    {
        Submissions,
        Comments,
        Favorites,
        Watchers,
        Journals,
        Notes,
        Undefined
    }

    public class NotificationHistory
    {
        public int submission;
        public int comments;
        public int watchers;
        public int journals;
        public int favorites;
        public int notes;

        public NotificationHistory Clone()
        {
            var n = new NotificationHistory() {
                submission = submission,
                comments = comments,
                watchers = watchers,
                journals = journals,
                favorites = favorites,
                notes = notes
            };
            return n;
        }

        public string GetNotificationChange(NotificationHistory previous)
        {
            List<string> messages = new List<string>();
            AddMessage(messages, "submission", previous.submission, submission);
            AddMessage(messages, "favorite", previous.favorites, favorites);
            AddMessage(messages, "comment", previous.comments, comments);
            AddMessage(messages, "watcher", previous.watchers, watchers);
            AddMessage(messages, "journal", previous.journals, journals);
            AddMessage(messages, "message", previous.notes, notes);

            Console.WriteLine($"Notification count: {messages.Count}");
            return messages.Count > 0 ? "There's " + string.Join(", ", messages.ToArray()) : null;
        }

        public void AddMessage(List<string> list, string type, int start, int end)
        {
            Console.WriteLine($"Checking {type} - S:{start} E:{end}");
            if (start < end)
            {
                var count = end - start;
                list.Add(GetPluralCount(count, count + " new " + type));
            }
        }

        public string GetPluralCount(int count, string message)
        {
            return count != 1 ? message + "s" : message;
        }
    }
    #endregion
}
