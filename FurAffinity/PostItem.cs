using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

using HtmlAgilityPack;
using HtmlDoc = HtmlAgilityPack.HtmlDocument;

namespace FurAffinity
{
    public partial class PostItem : UserControl
    {
        #region Variables
        public HtmlDoc htmlDoc = new HtmlDoc();
        public PostData postData = new PostData();
        public string imageName;
        public bool loadingLocally;
        static string imageDir => SettingsForm.preferences.imageDirPath;
        public Image previewImage;
        #endregion

        #region Initialization
        public PostItem()
        {
            InitializeComponent();
        }

        public PostItem(string url, string html)
        {
            InitializeComponent();
            postData.url = url;
            postData.html = html;
            htmlDoc.LoadHtml(html);

            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {
                foreach (var error in htmlDoc.ParseErrors)
                {
                    Console.WriteLine(error.Reason);
                }
            }
            else
            {
                if (htmlDoc.DocumentNode != null)
                {
                    HtmlNode imagePost = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"submissionImg\"]");
                    HtmlNode titleText = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"columnpage\"]/div[2]/section/div[1]/div/div[2]/div/h2/p");

                    if (imagePost != null)
                    {
                        postData.imageSrc = imagePost.GetAttributeValue("src", null);
                        imageName = Path.Combine(imageDir, Path.GetFileName(postData.imageSrc)).FixPath();
                        if (!postData.imageSrc.StartsWith("https:")) postData.imageSrc = "https:" + postData.imageSrc;
                        Console.WriteLine("User is favoriting: " + postData.imageSrc);
                        imageProgressBar.Visible = true;
                        imageProgressBar.Value = 0;
                        if (File.Exists(imageName))
                        {
                            loadingLocally = true;
                            postImage.LoadAsync(imageName);
                        }
                        else
                        {
                            postImage.LoadAsync(postData.imageSrc);
                        }
                    }

                    if (titleText != null)
                    {
                        postData.title = titleText.InnerText;
                        postName.Text = titleText.InnerText;
                    }
                }
            }
        }
        #endregion

        #region Events
        private void PostImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var previousHeight = postImage.Height;
            float height = postImage.Image.Height * ((float)postImage.Width / postImage.Image.Width);

            postImage.Height = (int)height;
            Height += (int)height - previousHeight;

            imageProgressBar.Visible = false;

            if (postImage.Image != postImage.ErrorImage || postImage.Image != null)
            {
                previewImage = postImage.Image;
                if(!loadingLocally) postImage.Image.Save(imageName);
            }
        }

        private void PostImage_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            imageProgressBar.Value = e.ProgressPercentage;
        }

        private void PostItem_Click(object sender, EventArgs e)
        {
            MainForm.form.NavigateTo(postData.url);
        }

        private void showLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.form.NavigateTo(postData.url);
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(imageName))
            {
                Process.Start(imageName);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.form.RemoveFavoritePost(postData);
        }
        #endregion

        #region Utility
        public static bool IsHtmlAValidPost(string html)
        {
            var htDoc = new HtmlDoc();
            htDoc.LoadHtml(html);

            if (htDoc.ParseErrors != null && htDoc.ParseErrors.Count() > 0)
            {
                foreach (var error in htDoc.ParseErrors)
                {
                    Console.WriteLine(error.Reason);
                }
            }
            else
            {
                if (htDoc.DocumentNode != null)
                {
                    HtmlNode imagePost = htDoc.DocumentNode.SelectSingleNode("//*[@id=\"submissionImg\"]");
                    if (imagePost != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool isHidden;
        private void hidePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHidden = !isHidden;
            postImage.Image = isHidden ? null : previewImage;
            hidePreviewToolStripMenuItem.Text = isHidden ? "Show Preview" : "Hide Preview";
        }
        #endregion
    }

    #region Classes
    public class PostData
    {
        public string url;
        public string title;
        public string author;

        public string imageSrc;
        public string html;
    }

    public static class PathFixer
    {
        public static string startPath;
        public static string FixPath(this string str)
        {
            FixStartPath();
            str = str.Replace("\\", "/");
            if (string.IsNullOrWhiteSpace(startPath))
            {
                return str;
            }
            else
            {
                if (str.Contains(":/"))
                {
                    return str.Replace("{ApplicationDir}", startPath);
                }
                else
                {
                    string rps = str.Replace("{ApplicationDir}", startPath);
                    return rps.Contains(":/") ? rps : Path.Combine(startPath, rps);
                }
            }
        }

        public static string FixStartPath()
        {
            if(startPath.EndsWith("\\") || startPath.EndsWith("/"))
            {
                startPath = startPath.TrimEnd('\\', '/');
            }
            return startPath;
        }
    }
    #endregion
}