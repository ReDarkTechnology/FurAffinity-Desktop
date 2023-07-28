using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace FurAffinity
{
    public partial class SettingsForm : Form
    {
        public static Preferences preferences = new Preferences();
        public static string preferencesPath;

        static SettingsForm()
        {
            PathFixer.startPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "");
            preferencesPath = "preferences.json".FixPath();

            if (File.Exists(preferencesPath))
                preferences = JsonConvert.DeserializeObject<Preferences>(File.ReadAllText("preferences.json".FixPath()));
        }

        public SettingsForm()
        {
            InitializeComponent();

            self = this;
            Disposed += SettingsForm_Disposed;

            LoadAndInitialize();
        }

        public static void ReInit()
        {
            if (File.Exists(preferencesPath))
                preferences = JsonConvert.DeserializeObject<Preferences>(File.ReadAllText("preferences.json".FixPath()));
        }

        public void LoadAndInitialize()
        {
            noChange = true;
            downloadOnFaveBox.Checked = preferences.autoDownloadFave;
            imagesPathBox.Text = preferences.imageDirPath;

            hideOnTrayBox.Checked = preferences.hideOnTray;
            profileDataBox.Text = preferences.profilePath;

            notifBackgroundBox.Checked = preferences.checkInBackground;
            notifDelaySlider.Value = preferences.watchInterval;
            notifDelayNumeric.Value = preferences.watchInterval;
            
            foreach(var dir in Directory.GetDirectories(PathFixer.startPath))
            {
                AddProfile(dir);
            }
            noChange = false;
        }

        public void OpenProfile(ProfileObject obj)
        {
            var info = new ProcessStartInfo();
            info.FileName = Assembly.GetExecutingAssembly().CodeBase;
            info.Arguments = $"\"-profile={obj.profilePath}\"";

            Process.Start(info);
        }

        private void profileAddButton_Click(object sender, EventArgs e)
        {
            var dir = profileNameBox.Text.FixPath();
            MainForm.CreateDir(dir);
            var profile = new Profile();
            profile.profileName = profileNameBox.Text;
            profile.profileDir = dir;
            var profileJson = Path.Combine(dir, "profile.json");
            File.WriteAllText(profileJson, JsonConvert.SerializeObject(profile, Formatting.Indented));
            AddProfile(dir, true);
        }

        public void AddProfile(string directory, bool newProfile = false)
        {
            if(newProfile)
            {
                MainForm.CreateDir(directory);
            }

            var profileJson = Path.Combine(directory, "profile.json");
            if (File.Exists(profileJson))
            {
                var profileObject = new ProfileObject();
                profileObject.profile = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(profileJson));
                profileObject.profilePath = directory;

                var l = new Label();
                l.Text = profileObject.profile.profileName;
                l.Click += (a, e) => OpenProfile(profileObject);
                l.Width = profilesPanel.Width - 15;
                l.Height = 25;
                l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                l.Padding = new Padding(3, 0, 0, 0);
                l.Margin = new Padding(3, 3, 3, 3);
                l.BackColor = System.Drawing.Color.FromArgb(255, 50, 0, 50);

                var contextMenu = new ContextMenuStrip();
                var item = contextMenu.Items.Add("Delete Profile");
                item.Click += (a, ee) => {
                    RecursiveDelete(new DirectoryInfo(directory));
                    profilesPanel.Controls.Remove(l);
                };
                l.ContextMenuStrip = contextMenu;
                profilesPanel.Controls.Add(l);
                profileObject.label = l;
            }
        }

        public static void RecursiveDelete(DirectoryInfo baseDir)
        {
            if (!baseDir.Exists)
                return;

            foreach (var dir in baseDir.EnumerateDirectories())
            {
                RecursiveDelete(dir);
            }
            baseDir.Delete(true);
        }

        public class ProfileObject
        {
            public Profile profile;
            public string profilePath;
            public Label label;
        }

        public static void Save()
        {
            File.WriteAllText(preferencesPath, JsonConvert.SerializeObject(preferences, Formatting.Indented));
        }

        bool noChange;
        private void notifDelaySlider_Scroll(object sender, EventArgs e)
        {
            if (noChange) return;

            noChange = true;
            notifDelayNumeric.Value = notifDelaySlider.Value;
            noChange = false;

            preferences.watchInterval = notifDelaySlider.Value;
            Save();
        }

        private void notifDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            noChange = true;
            notifDelaySlider.Value = (int)notifDelayNumeric.Value;
            noChange = false;

            preferences.watchInterval = (int)notifDelayNumeric.Value;
            Save();
        }

        private void notifBackgroundBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            preferences.checkInBackground = notifBackgroundBox.Checked;
            Save();
        }

        private void hideOnTrayBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            preferences.hideOnTray = hideOnTrayBox.Checked;
            Save();
        }

        private void profileDataBox_TextChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            preferences.profilePath = profileDataBox.Text;
            Save();
        }

        private void downloadOnFaveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            preferences.autoDownloadFave = downloadOnFaveBox.Checked;
            Save();
        }

        private void imagesPathBox_TextChanged(object sender, EventArgs e)
        {
            if (noChange) return;

            preferences.imageDirPath = imagesPathBox.Text;
            Save();
        }

        #region Singleton
        public static SettingsForm self;
        private void SettingsForm_Disposed(object sender, EventArgs e)
        {
            self = null;
        }

        public static void ShowAvailable()
        {
            if(self == null)
            {
                self = new SettingsForm();
                self.Show();
            }
            else
            {
                self.Activate();
                self.Show();
            }
        }
        #endregion
    }

    public class Preferences
    {
        // Images
        public bool autoDownloadFave = true;
        public string imageDirPath = "{ApplicationDir}/Images";

        // Application
        public bool hideOnTray = true;
        public string profilePath = "{ApplicationDir}/ProfileData";

        // Notification
        public bool checkInBackground = true;
        public int watchInterval = 15;

        // Profiles
        public List<Profile> profiles = new List<Profile>();
    }

    public class Profile
    {
        public string profileName;
        public string profileDir;

        public string faName;
        public string avatarUrl;
    }
}
