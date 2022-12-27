using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Security.Cryptography;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Principal;

namespace FsAFS
{
    public partial class Form1 : Form
    {
        int f = 0;

        private Rectangle panelSourceFolderRect;
        private Rectangle panelDestinationFolderRect;
        private Rectangle panelButtom1Rect;
        private Rectangle panelButtom2Rect;
        private Rectangle panelMiddel1Rect;
        private Rectangle panelSDRect;

        private Rectangle lvDifferentRect;
        private Rectangle lvDuplicateRect;

        private Rectangle pbCopySourceFolderNameRect;
        private Rectangle pbCopySourceFolderPathRect;
        private Rectangle pbCopyDestinationFolderNameRect;
        private Rectangle pbCopyDestinationFolderPathRect;

        private Rectangle txtSourceFolderNameRect;
        private Rectangle txtSourceFolderPathRect;
        private Rectangle txtDestinationFolderNameRect;
        private Rectangle txtDestinationFolderPathRect;

        private Rectangle label1Rect;
        private Rectangle label2Rect;
        private Rectangle label10Rect;
        private Rectangle label8Rect;
        private Rectangle label7Rect;
        private Rectangle label12Rect;
        private Rectangle lbLeftSideFolderSizeRect;
        private Rectangle lbNoOfSourceFilesRect;
        private Rectangle lbNoOfSourceFoldersRect;
        private Rectangle lbRightSideFolderSizeRect;
        private Rectangle lbNoOfDestinationFilesRect;
        private Rectangle lbNoOfDestinationFoldersRect;
        private Rectangle lbDifferentRect;
        private Rectangle lbDuplicateRect;
        private Rectangle lb1Rect;
        private Rectangle lb2Rect;

        private double panelSourceFolderFont;
        private double panelDestinationFolderFont;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FsAFS_Database.mdf;Integrated Security=True");

        private Size formRectSize;
        string[] filetype_name = new string[406];
        public Boolean operationCancel = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Imagepath = AppDomain.CurrentDomain.BaseDirectory;
            SetFolderPermission(Imagepath);
            Imagepath = Imagepath.Replace(@"bin\Debug\", @"Resources\");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("TRUNCATE TABLE copy_item_list", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //trayIcon.Icon = Properties.Resources.logo;
            //trayIcon.Visible = true;
            //trayIcon.ShowBalloonTip(1000, "Wlcome Message", "Welcome to My Application FsAFS", ToolTipIcon.None);
            pbProgressBar.Visible = false;
            lbProcessing.Visible = false;
            //<>
            {
                btnAnalyse.Enabled = false;
                btnSC_FAF.Enabled = false;
                btnSM_FAF.Enabled = false;
                btnCopyDuplicate.Enabled = false;
                btnMoveDuplicate.Enabled = false;
                btnDDF.Enabled = false;
                btnDDFS.Enabled = false;
                btnCopyLeftToRightFAF.Enabled = false;
                btnCopyRightToLeftFAF.Enabled = false;
                btnMoveLeftToRightFAF.Enabled = false;
                btnMoveRightToLeftFAF.Enabled = false;
                btnCancel.Enabled = false;
            }
            //</>

            //<>
            ListView.CheckForIllegalCrossThreadCalls = false;
            //</>

            //<>
            {

                lvDifferent.GridLines = true;
                lvDifferent.FullRowSelect = true;
                lvDifferent.View = View.Details;
                lvDifferent.Columns.Add("Name");
                lvDifferent.Columns.Add("AvaliblePath");
                lvDifferent.Columns.Add("NotAvaliblePath");
                lvDifferent.Columns.Add("Type");
                lvDifferent.Columns.Add("MD5");

                lvDuplicate.GridLines = true;
                lvDuplicate.FullRowSelect = true;
                lvDuplicate.View = View.Details;
                lvDuplicate.Columns.Add("Name");
                lvDuplicate.Columns.Add("Type");
                lvDuplicate.Columns.Add("MD5");
            }
            //</>

            //<>
            {
                txtSourceFolderName.Clear();
                txtDestinationFolderName.Clear();
                txtSourceFolderPath.Clear();
                txtDestinationFolderPath.Clear();
                lbLeftSideFolderSize.Text = "";
                lbRightSideFolderSize.Text = "";
                lbNoOfSourceFiles.Text = "";
                lbNoOfSourceFolders.Text = "";
                lbNoOfDestinationFiles.Text = "";
                lbNoOfDestinationFolders.Text = "";
            }

            //</>
            
            string filetype_name_path = Imagepath + @"filetype_name.txt";
            if (File.Exists(filetype_name_path))
            {
                filetype_name = File.ReadAllText(filetype_name_path).Split(',');
                //MessageBox.Show(Imagepath + @"filetype_icon\" + filetype_name[0] + ".png");
            }
            ImageList img = new ImageList() { ImageSize = new Size(25, 25) };

            //<>

            //img.Images.Add(Properties.Resources.file);
            //img.Images.Add(Properties.Resources.folder);
            img.Images.Add(Image.FromFile(Imagepath + @"file.png"));
            img.Images.Add(Image.FromFile(Imagepath + @"folder.png"));
            for (int i = 0; i < filetype_name.Length; i++)
            {
                string filename = filetype_name[i];

                img.Images.Add(Image.FromFile(Imagepath + @"filetype_icon\" + filename + ".png"));
            }

            //</>

            //<>
            lvDifferent.SmallImageList = img;
            lvDuplicate.SmallImageList = img;
            //</>


            //<>
            //btnBL.Image = new Bitmap(Properties.Resources.add_folder, new Size(20, 20));
            //</>

            formRectSize = this.Size;


            panelSourceFolderRect = new Rectangle(panelSourceFolder.Location, panelSourceFolder.Size);
            panelDestinationFolderRect = new Rectangle(panelDestinationFolder.Location, panelDestinationFolder.Size);
            panelButtom1Rect = new Rectangle(panelBottom1.Location, panelBottom1.Size);
            panelButtom2Rect = new Rectangle(panelBottom2.Location, panelBottom2.Size);
            panelMiddel1Rect = new Rectangle(panelMiddel1.Location, panelMiddel1.Size);
            panelSDRect = new Rectangle(panelSD.Location, panelSD.Size);

            lvDifferentRect = new Rectangle(lvDifferent.Location, lvDifferent.Size);
            lvDuplicateRect = new Rectangle(lvDuplicate.Location, lvDuplicate.Size);

            pbCopySourceFolderNameRect = new Rectangle(pbCopySourceFolderName.Location, pbCopySourceFolderName.Size);
            pbCopySourceFolderPathRect = new Rectangle(pbCopySourceFolderPath.Location, pbCopySourceFolderPath.Size);
            pbCopyDestinationFolderNameRect = new Rectangle(pbCopyDestinationFolderName.Location, pbCopyDestinationFolderName.Size);
            pbCopyDestinationFolderPathRect = new Rectangle(pbCopyDestinationFolderPath.Location, pbCopyDestinationFolderPath.Size);

            txtSourceFolderNameRect = new Rectangle(txtSourceFolderName.Location, txtSourceFolderName.Size);
            txtSourceFolderPathRect = new Rectangle(txtSourceFolderPath.Location, txtSourceFolderPath.Size);
            txtDestinationFolderNameRect = new Rectangle(txtDestinationFolderName.Location, txtDestinationFolderName.Size);
            txtDestinationFolderPathRect = new Rectangle(txtDestinationFolderPath.Location, txtDestinationFolderPath.Size);

            label1Rect = new Rectangle(lbSourceFolderName.Location, lbSourceFolderName.Size);
            label2Rect = new Rectangle(lbSourceFolderPath.Location, lbSourceFolderPath.Size);
            label10Rect = new Rectangle(label10.Location, label10.Size);
            label8Rect = new Rectangle(lbDestinationFolderName.Location, lbDestinationFolderName.Size);
            label7Rect = new Rectangle(lbDestinationFolderPath.Location, lbDestinationFolderPath.Size);
            label12Rect = new Rectangle(label12.Location, label12.Size);
            lbLeftSideFolderSizeRect = new Rectangle(lbLeftSideFolderSize.Location, lbLeftSideFolderSize.Size);
            lbNoOfSourceFilesRect = new Rectangle(lbNoOfSourceFiles.Location, lbNoOfSourceFiles.Size);
            lbNoOfSourceFoldersRect = new Rectangle(lbNoOfSourceFolders.Location, lbNoOfSourceFolders.Size);
            lbRightSideFolderSizeRect = new Rectangle(lbRightSideFolderSize.Location, lbRightSideFolderSize.Size);
            lbNoOfDestinationFilesRect = new Rectangle(lbNoOfDestinationFiles.Location, lbNoOfDestinationFiles.Size);
            lbNoOfDestinationFoldersRect = new Rectangle(lbNoOfDestinationFolders.Location, lbNoOfDestinationFolders.Size);
            lbDifferentRect = new Rectangle(lbDifferent.Location, lbDifferent.Size);
            lbDuplicateRect = new Rectangle(lbDuplicate.Location, lbDuplicate.Size);
            lb1Rect = new Rectangle(label1.Location, label1.Size);
            lb2Rect = new Rectangle(label2.Location, label2.Size);
            //</>

            //<Font>
            {
                panelSourceFolderFont = panelSourceFolder.Font.Size;
                panelDestinationFolderFont = panelDestinationFolder.Font.Size;
            }
            //</>

            //<Screen>
            {
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                if (screenWidth < 800)
                {
                    MessageBox.Show("Screen Is not capable");
                    this.Close();
                }
                else if (screenWidth == 800)
                {
                    this.Size = MaximumSize;
                }
                else if (screenWidth == 1024)
                {
                    this.Width = 700;
                }
                else if (screenWidth == 1280)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(150, 60);
                    int widthpr = (int)((float)screenWidth / (float)4);
                    int higpr = (int)((float)screenHeight / (float)2);
                    this.Width = screenWidth - widthpr;
                    this.Height = screenHeight - higpr;
                }
                else if (screenWidth == 1366)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(150, 60);
                    int widthpr = (int)((float)screenWidth / (float)3.4);
                    this.Width = screenWidth - widthpr;
                }
                else if (screenWidth == 1600)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(250, 120);
                    int widthpr = (int)((float)screenWidth / (float)2.7);
                    this.Width = screenWidth - widthpr;
                }
                else if (screenWidth == 1680)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(250, 120);
                    int widthpr = (int)((float)screenWidth / (float)2.5);
                    this.Width = screenWidth - widthpr;
                }
                else if (screenWidth >= 1920)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(250, 120);
                    int widthpr = (int)((float)screenWidth / (float)2.7);
                    this.Width = screenWidth - widthpr;
                }
            }
            //</>

            timer1.Interval = 1000;
            timer1.Start();

        }

        public static void SetFolderPermission(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();
            var currentUserIdentity = WindowsIdentity.GetCurrent();
            var fileSystemRule = new FileSystemAccessRule(currentUserIdentity.Name,
                                                          FileSystemRights.FullControl,
                                                          InheritanceFlags.ObjectInherit |
                                                          InheritanceFlags.ContainerInherit,
                                                          PropagationFlags.None, AccessControlType.Allow);
           
            directorySecurity.AddAccessRule(fileSystemRule);
            directoryInfo.SetAccessControl(directorySecurity);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ChildResize();
        }

        public void copyFile(string sourcePath, string destinationPath, Boolean fileOverride = false)
        {
            try
            {
                File.Copy(sourcePath, destinationPath, fileOverride);
                con.Open();
                string query = "insert into copy_item_list values('" + sourcePath + "','" + destinationPath + "',1,'" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Error to insert in database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public static bool AccessCheck(string folderPath)
        {
            try
            {
                // Attempt to get a list of security permissions from the folder. 
                // This will raise an exception if the path is read only or do not have access to view the permissions. 
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
                string[] folders = Directory.GetDirectories(folderPath, "*.*", SearchOption.AllDirectories);
                foreach (string folder in folders)
                {
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        // This will raise an exception if the path is read only or do not have access to view the permissions. 
                        DirectorySecurity ds1 = Directory.GetAccessControl(folder);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        return false;
                    }
                }
                foreach (string file in files)
                {
                    try
                    {
                        // Attempt to get a list of security permissions from the folder. 
                        // This will raise an exception if the path is read only or do not have access to view the permissions. 
                        DirectorySecurity ds1 = Directory.GetAccessControl(file);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }

        }

        string GetFolderSize(string Path)
        {
            if (Directory.Exists(Path))
            {
                string[] a = Directory.GetFiles(Path, "*.*", SearchOption.AllDirectories);

                double b = 0;
                foreach (string name in a)
                {
                    FileInfo info = new FileInfo(name);
                    b += info.Length;
                }
                StringBuilder fsize = new StringBuilder();
                //string fsize = "";
                if (b >= 1024 && b < (1024 * 1024))
                {
                    fsize.Append(string.Format("{0:N2} KB", (b / 1024)));
                }
                if (b >= (1024 * 1024) && b < (1024 * 1024 * 1024))
                {
                    fsize.Append(string.Format("{0:N2} MB", (b / (1024 * 1024))));
                }
                if (b >= (1024 * 1024 * 1024))
                {
                    fsize.Append(string.Format("{0:N2} GB", (b / (1024 * 1024 * 1024))));
                }
                if (b >= 0 && b < 1024)
                {
                    fsize.Append(string.Format("{0} Bytes", b));
                }
                return fsize.ToString();
            }
            else
            {
                return null;
            }
        }

        void EnableOrDisableControls(bool ed)
        {
            btnAnalyse.Enabled = ed;
            btnSC_FAF.Enabled = ed;
            btnSM_FAF.Enabled = ed;
            btnCopyDuplicate.Enabled = ed;
            btnMoveDuplicate.Enabled = ed;
            btnBR.Enabled = ed;
            btnBL.Enabled = ed;
            btnDDF.Enabled = ed;
            btnDDFS.Enabled = ed;
            btnCopyLeftToRightFAF.Enabled = ed;
            btnCopyRightToLeftFAF.Enabled = ed;
            btnMoveLeftToRightFAF.Enabled = ed;
            btnMoveRightToLeftFAF.Enabled = ed;
            btnClear.Enabled = ed;
        }

        void calculatefilesandfolders(int i)
        {
            if (i == 0)
            {
                string[] sourceFiles = Directory.GetFiles(txtSourceFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] sourceFolders = Directory.GetDirectories(txtSourceFolderPath.Text, "*.*", SearchOption.AllDirectories);
                lbNoOfSourceFiles.Text = "Files: " + sourceFiles.Length;
                lbNoOfSourceFolders.Text = "Folders: " + sourceFolders.Length;
            }
            else if (i == 1)
            {
                string[] destinationFiles = Directory.GetFiles(txtDestinationFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] destinationFolders = Directory.GetDirectories(txtDestinationFolderPath.Text, "*.*", SearchOption.AllDirectories);
                lbNoOfDestinationFiles.Text = "Files: " + destinationFiles.Length;
                lbNoOfDestinationFolders.Text = "Folders: " + destinationFolders.Length;
            }
            else if (i == 2)
            {
                string[] sourceFiles = Directory.GetFiles(txtSourceFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] sourceFolders = Directory.GetDirectories(txtSourceFolderPath.Text, "*.*", SearchOption.AllDirectories);
                lbNoOfSourceFiles.Text = "Files: " + sourceFiles.Length;
                lbNoOfSourceFolders.Text = "Folders: " + sourceFolders.Length;
                string[] destinationFiles = Directory.GetFiles(txtDestinationFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] destinationFolders = Directory.GetDirectories(txtDestinationFolderPath.Text, "*.*", SearchOption.AllDirectories);
                lbNoOfDestinationFiles.Text = "Files: " + destinationFiles.Length;
                lbNoOfDestinationFolders.Text = "Folders: " + destinationFolders.Length;
            }
        }

        void ChildResize()
        {
            ControlResize(panelSourceFolderRect, panelSourceFolder, panelSourceFolderFont);
            ControlResize(panelDestinationFolderRect, panelDestinationFolder, panelDestinationFolderFont);
            ControlResize(panelButtom1Rect, panelBottom1);
            panelBottom1.Height = 122;
            ControlResize(panelButtom2Rect, panelBottom2);
            panelBottom2.Height = 122;
            ControlResize(panelMiddel1Rect, panelMiddel1);
            ControlResize(panelSDRect, panelSD);
            panelSD.Height = 40;

            ControlResize(lvDifferentRect, lvDifferent);
            ControlResize(lvDuplicateRect, lvDuplicate);

            Relocated(pbCopySourceFolderNameRect, pbCopySourceFolderName);
            Relocated(pbCopySourceFolderPathRect, pbCopySourceFolderPath);
            Relocated(pbCopyDestinationFolderNameRect, pbCopyDestinationFolderName);
            Relocated(pbCopyDestinationFolderPathRect, pbCopyDestinationFolderPath);

            ControlResize(txtSourceFolderNameRect, txtSourceFolderName);
            ControlResize(txtSourceFolderPathRect, txtSourceFolderPath);
            ControlResize(txtDestinationFolderNameRect, txtDestinationFolderName);
            ControlResize(txtDestinationFolderPathRect, txtDestinationFolderPath);

            ControlResize(label1Rect, lbSourceFolderName);
            ControlResize(label2Rect, lbSourceFolderPath);
            ControlResize(label10Rect, label10);
            ControlResize(label8Rect, lbDestinationFolderName);
            ControlResize(label7Rect, lbDestinationFolderPath);
            ControlResize(label12Rect, label12);
            ControlResize(lbLeftSideFolderSizeRect, lbLeftSideFolderSize);
            ControlResize(lbNoOfSourceFilesRect, lbNoOfSourceFiles);
            ControlResize(lbNoOfSourceFoldersRect, lbNoOfSourceFolders);
            ControlResize(lbRightSideFolderSizeRect, lbRightSideFolderSize);
            ControlResize(lbNoOfDestinationFilesRect, lbNoOfDestinationFiles);
            ControlResize(lbNoOfDestinationFoldersRect, lbNoOfDestinationFolders);
            ControlResize(lbDifferentRect, lbDifferent);
            ControlResize(lbDuplicateRect, lbDuplicate);
            ControlResize(lb1Rect, label1);
            ControlResize(lb2Rect, label2);
        }

        void ControlResize(Rectangle r, Control c)
        {
            double xRatio = ((double)this.Width / (double)formRectSize.Width);
            double yRatio = ((double)this.Height / (double)formRectSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        void ControlResize(Rectangle r, Control c, double orignalFontSize)
        {
            double xRatio = ((double)this.Width / (double)formRectSize.Width);
            double yRatio = ((double)this.Height / (double)formRectSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            double ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            double newFontSize = orignalFontSize * ratio;
            Font nowFontSize = new Font(c.Font.FontFamily, (float)6);
            if (newFontSize > 9)
            {
                nowFontSize = new Font(c.Font.FontFamily, (float)9);
            }
            else if (newFontSize <= 9 && newFontSize >= 6)
            {
                nowFontSize = new Font(c.Font.FontFamily, (float)newFontSize);
            }
            c.Font = nowFontSize;
        }

        void Relocated(Rectangle r, Control c)
        {
            double xRatio = ((double)this.Width / (double)formRectSize.Width);
            double yRatio = ((double)this.Height / (double)formRectSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            c.Location = new Point(newX, newY);
        }

        void AddItemListViewDifferent(params string[] s)
        {
            int iconIndex = 0;
            if (s[3] == "Folder")
            {
                iconIndex = 1;
            }
            else
            {
                string fileext = Path.GetExtension(s[2]);
                fileext = fileext.Replace(".", "");
                int index = Array.IndexOf(filetype_name, fileext.ToLower());
                if (index != -1)
                {
                    iconIndex = index + 2;
                }
            }
            ListViewItem item = new ListViewItem(s[0], iconIndex);
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, s[1]);
            ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, s[2]);
            ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem(item, s[3]);
            ListViewItem.ListViewSubItem subitem4 = new ListViewItem.ListViewSubItem(item, s[4]);
            item.SubItems.Add(subitem1);
            item.SubItems.Add(subitem2);
            item.SubItems.Add(subitem3);
            item.SubItems.Add(subitem4);
            lvDifferent.Items.Add(item);
            lvDifferent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void AddItemListViewDuplicate(params string[] s)
        {
            int iconIndex = 0;
            if (s[1] == "Folder")
            {
                iconIndex = 1;
            }
            else
            {
                string fileext = Path.GetExtension(s[0]);
                fileext = fileext.Replace(".", "");
                int index = Array.IndexOf(filetype_name, fileext.ToLower());
                if (index != -1)
                {
                    iconIndex = index + 2;
                }
            }
            ListViewItem item = new ListViewItem(s[0], iconIndex);
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, s[1]);
            ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, s[2]);
            item.SubItems.Add(subitem1);
            item.SubItems.Add(subitem2);
            lvDuplicate.Items.Add(item);
            lvDuplicate.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public static string StringToMD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                //Delete all files from the Directory
                foreach (string file in Directory.GetFiles(path))
                {
                    File.Delete(file);

                }
                //Delete all child Directories
                foreach (string directory in Directory.GetDirectories(path))
                {
                    DeleteDirectory(directory);
                }
                //Delete a Directory
                Directory.Delete(path);

            }
        }

        void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into delete_item_list values ('" + path + "','" + DateTime.Now.ToString() + "')", con);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Add Deleted item in Database Error");
                }
                con.Close();
            }
        }

        bool FileCompare(string path1, string path2)
        {
            if (File.Exists(path1) && File.Exists(path2))
            {
                HashAlgorithm ha = HashAlgorithm.Create();
                FileStream f1 = new FileStream(path1, FileMode.Open); ;
                FileStream f2 = new FileStream(path2, FileMode.Open); ;


                /* Calculate Hash */
                byte[] hash1 = ha.ComputeHash(f1);
                byte[] hash2 = ha.ComputeHash(f2);
                f1.Close();
                f2.Close();
                /* Compare the hash and return True or False */
                if (BitConverter.ToString(hash1) == BitConverter.ToString(hash2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool FolderCompare(string pathA, string pathB)
        {
            if (Directory.Exists(pathA) && Directory.Exists(pathB))
            {
                DirectoryInfo dir1 = new DirectoryInfo(pathA);
                DirectoryInfo dir2 = new DirectoryInfo(pathB);
                IEnumerable<FileInfo> list1 = dir1.GetFiles("*.*", SearchOption.AllDirectories);
                IEnumerable<FileInfo> list2 = dir2.GetFiles("*.*", SearchOption.AllDirectories);
                FileCompare2 myFileCompare = new FileCompare2();
                bool areIdentical = list1.SequenceEqual(list2, myFileCompare);
                if (areIdentical == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        class FileCompare2 : IEqualityComparer<FileInfo>
        {
            public FileCompare2() { }

            public bool Equals(FileInfo f1, FileInfo f2)
            {
                return (f1.Name == f2.Name &&
                        f1.Length == f2.Length);
            }
            public int GetHashCode(FileInfo fi)
            {
                string s = $"{fi.Name}{fi.Length}";
                return s.GetHashCode();
            }
        }

        public void DifferentFileSettings(params string[] data)
        {

            string settingData = Properties.Settings.Default.DifferentSettings;
            string[] SplitsSettingData = settingData.Split(',');
            double fromSize = 0;
            double toSize = 0;
            if (SplitsSettingData[0] == "SizeCreated DateType" || SplitsSettingData[0] == "SizeCreated DateCustom Type" || SplitsSettingData[0] == "SizeCreated Date" || SplitsSettingData[0] == "Size" || SplitsSettingData[0] == "SizeCustom Type" || SplitsSettingData[0] == "SizeType")
            {
                if (SplitsSettingData[2] == "KB")
                {
                    fromSize = (Convert.ToDouble(SplitsSettingData[1]) * 1024);
                }
                else if (SplitsSettingData[2] == "MB")
                {
                    fromSize = (Convert.ToDouble(SplitsSettingData[1]) * (1024 * 1024));
                }
                else if (SplitsSettingData[2] == "GB")
                {
                    fromSize = (Convert.ToDouble(SplitsSettingData[1]) * (1024 * 1024 * 1024));
                }
                else if (SplitsSettingData[2] == "Bytes")
                {
                    fromSize = Convert.ToDouble(SplitsSettingData[1]);
                }

                if (SplitsSettingData[4] == "KB")
                {
                    toSize = (Convert.ToDouble(SplitsSettingData[3]) * 1024);
                }
                else if (SplitsSettingData[4] == "MB")
                {
                    toSize = (Convert.ToDouble(SplitsSettingData[3]) * (1024 * 1024));
                }
                else if (SplitsSettingData[4] == "GB")
                {
                    toSize = (Convert.ToDouble(SplitsSettingData[3]) * (1024 * 1024 * 1024));
                }
                else if (SplitsSettingData[4] == "Bytes")
                {
                    toSize = Convert.ToDouble(SplitsSettingData[3]);
                }
            }

            if (SplitsSettingData[0] == "SizeCreated DateType")
            {
                double filesize = new FileInfo(data[1]).Length;
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[5]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[6]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if ((filesize >= fromSize && filesize <= toSize) && (Path.GetExtension(data[1]) == SplitsSettingData[7]) && (dateTimeFrom <= fileDate && dateTimeTo >= fileDate))
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "SizeCreated DateCustom Type")
            {
                double filesize = new FileInfo(data[1]).Length;
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[5]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[6]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if ((filesize >= fromSize && filesize <= toSize) && (dateTimeFrom <= fileDate && dateTimeTo >= fileDate))
                {
                    string[] customtypes = SplitsSettingData[7].Split('|');
                    foreach (string type in customtypes)
                    {
                        if (type.Contains(Path.GetExtension(data[1])))
                        {
                            AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                            break;
                        }
                    }
                }
            }
            else if (SplitsSettingData[0] == "Created DateType")
            {
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[1]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[2]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if ((Path.GetExtension(data[1]) == SplitsSettingData[3]) && (dateTimeFrom <= fileDate && dateTimeTo >= fileDate))
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "Created DateCustom Type")
            {
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[1]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[2]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if ((dateTimeFrom <= fileDate && dateTimeTo >= fileDate))
                {
                    string[] customtypes = SplitsSettingData[3].Split('|');
                    foreach (string type in customtypes)
                    {
                        if (type.Contains(Path.GetExtension(data[1])))
                        {
                            AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                            break;
                        }
                    }
                }
            }
            else if (SplitsSettingData[0] == "SizeCreated Date")
            {
                double filesize = new FileInfo(data[1]).Length;
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[5]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[6]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if ((filesize >= fromSize && filesize <= toSize) && (dateTimeFrom <= fileDate && dateTimeTo >= fileDate))
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "SizeType")
            {
                double filesize = new FileInfo(data[1]).Length;
                if ((filesize >= fromSize && filesize <= toSize) && (Path.GetExtension(data[1]) == SplitsSettingData[5]))
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "SizeCustom Type")
            {
                double filesize = new FileInfo(data[1]).Length;
                if ((filesize >= fromSize && filesize <= toSize))
                {
                    string[] customtypes = SplitsSettingData[5].Split('|');
                    foreach (string type in customtypes)
                    {
                        if (type.Contains(Path.GetExtension(data[1])))
                        {
                            AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                            break;
                        }
                    }
                }
            }
            else if (SplitsSettingData[0] == "Size")
            {
                double filesize = new FileInfo(data[1]).Length;
                if (filesize >= fromSize && filesize <= toSize)
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }

            }
            else if (SplitsSettingData[0] == "Created Date")
            {
                DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[1]);
                DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[2]);
                DateTime fileDate = DateTime.Parse(File.GetCreationTime(data[1]).ToShortDateString());
                if (dateTimeFrom <= fileDate && dateTimeTo >= fileDate)
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "Type")
            {
                if (Path.GetExtension(data[1]) == SplitsSettingData[1])
                {
                    AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                }
            }
            else if (SplitsSettingData[0] == "Custom Type")
            {
                string[] customtypes = SplitsSettingData[1].Split('|');
                foreach (string type in customtypes)
                {
                    if (type.Contains(Path.GetExtension(data[1])))
                    {
                        AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
                        break;
                    }
                }
            }
            else
            {
                AddItemListViewDifferent(data[0], data[1], data[2], data[3], data[4]);
            }
        }


        private void BtnBL_Click(object sender, EventArgs e)
        {
            lbLeftSideFolderSize.Text = "";
            txtSourceFolderName.Clear();
            txtSourceFolderPath.Clear();
            lbNoOfSourceFiles.Text = "";
            lbNoOfSourceFolders.Text = "";
            lvDuplicate.Items.Clear();
            lvDifferent.Items.Clear();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (AccessCheck(dialog.FileName))
                {

                    timer1.Stop();
                    btnBL.Enabled = false;
                    string str = dialog.FileName;
                    if (str != txtDestinationFolderPath.Text)
                    {
                        txtSourceFolderName.Text = (str.Replace(Path.GetDirectoryName(str) + @"\", ""));
                        txtSourceFolderPath.Text = str;
                        lbLeftSideFolderSize.Text = GetFolderSize(str);
                        calculatefilesandfolders(0);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Selected");
                    }
                    btnBL.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Folder Not Accessible", "Folder Auth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnBR_Click(object sender, EventArgs e)
        {

            lbRightSideFolderSize.Text = "";
            lbNoOfDestinationFiles.Text = "";
            lbNoOfDestinationFolders.Text = "";
            txtDestinationFolderName.Clear();
            txtDestinationFolderPath.Clear();


            lvDuplicate.Items.Clear();
            lvDifferent.Items.Clear();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (AccessCheck(dialog.FileName))
                {
                    timer1.Stop();
                    btnBR.Enabled = false;
                    string str = dialog.FileName;
                    if (str != txtSourceFolderPath.Text)
                    {
                        txtDestinationFolderName.Text = (str.Replace(Path.GetDirectoryName(str) + @"\", ""));
                        txtDestinationFolderPath.Text = str;
                        lbRightSideFolderSize.Text = GetFolderSize(str);
                        calculatefilesandfolders(1);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Selected");
                    }
                    btnBR.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Folder Not Accessible", "Folder Auth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnAnalyse_Click(object sender, EventArgs e)
        {
            if (txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "")
            {
                pbProgressBar.Visible = true;lbProcessing.Visible = true;
                timer1.Stop();
                EnableOrDisableControls(false);
                btnCancel.Enabled = true;
                btnAnalyseSettings.Enabled = false;
                string[] SourceFiles = Directory.GetFiles(txtSourceFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] SourceFolders = Directory.GetDirectories(txtSourceFolderPath.Text, "*", SearchOption.AllDirectories);
                string[] DestinationFiles = Directory.GetFiles(txtDestinationFolderPath.Text, "*.*", SearchOption.AllDirectories);
                string[] DestinationFolders = Directory.GetDirectories(txtDestinationFolderPath.Text, "*", SearchOption.AllDirectories);
                int DesFileLen = DestinationFiles.Length;
                int SourceFileLen = SourceFiles.Length;
                int DesFolderLen = DestinationFolders.Length;
                int SourceFolderLen = SourceFolders.Length;
                lvDifferent.Items.Clear();
                lvDuplicate.Items.Clear();
                Boolean flagOperationCancel = false;

                await Task.Run(() =>
                {
                    Task task1 = Task.Factory.StartNew(() =>
                    {
                        for (int i = 0; i < SourceFolderLen; i++)
                        {
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                operationCancel = false;
                                break;
                            }
                            string item = SourceFolders[i].Replace(txtSourceFolderPath.Text, "");
                            string itemPath = SourceFolders[i];
                            string type = "Folder";
                            string itemMD5Hash = StringToMD5Hash(item);
                            string notAvalibleItemPath = txtDestinationFolderPath.Text + item;
                            if (DesFolderLen == 0)
                            {

                                AddItemListViewDifferent(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                            }
                            else
                            {
                                if (Directory.Exists(notAvalibleItemPath))
                                {
                                    if (FolderCompare(itemPath, notAvalibleItemPath))
                                    {
                                        AddItemListViewDuplicate(item, type, itemMD5Hash);
                                    }
                                    else
                                    {
                                        AddItemListViewDifferent(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                    }
                                }
                                else
                                {
                                    AddItemListViewDifferent(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                }
                            }
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                        }
                    });
                    Task task2 = Task.Factory.StartNew(() =>
                    {
                        for (int i = 0; i < DesFolderLen; i++)
                        {
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                            string item = DestinationFolders[i].Replace(txtDestinationFolderPath.Text, "");
                            string itemPath = DestinationFolders[i];
                            string type = "Folder";
                            string itemMD5Hash = StringToMD5Hash(item);
                            string notAvalibleItemPath = txtSourceFolderPath.Text + item;
                            if (SourceFolderLen == 0)
                            {

                                AddItemListViewDifferent(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                            }
                            else
                            {
                                if (!Directory.Exists(txtSourceFolderPath.Text + item))
                                {
                                    AddItemListViewDifferent(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                }
                            }
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                        }
                    });
                    Task.WaitAll(task1, task2);

                    Task task3 = Task.Factory.StartNew(() =>
                    {
                        for (int i = 0; i < SourceFiles.Length; i++)
                        {
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                            string item = SourceFiles[i].Replace(txtSourceFolderPath.Text, "");
                            string itemPath = SourceFiles[i];
                            string type = "File";
                            string itemMD5Hash = StringToMD5Hash(item);
                            string notAvalibleItemPath = txtDestinationFolderPath.Text + item;
                            if (DestinationFiles.Length == 0)
                            {
                                
                                DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                            }
                            else
                            {
                                if (File.Exists(notAvalibleItemPath))
                                {
                                    if (StringToMD5Hash(Path.GetFileName(itemPath)) == StringToMD5Hash(Path.GetFileName(notAvalibleItemPath)))
                                    {
                                        FileInfo fi1 = new FileInfo(itemPath);
                                        FileInfo fi2 = new FileInfo(notAvalibleItemPath);
                                        if (fi1.Length == fi2.Length)
                                        {
                                            bool check = FileCompare(itemPath, notAvalibleItemPath);
                                            if (check)
                                            {
                                                AddItemListViewDuplicate(item, type, itemMD5Hash);
                                            }
                                            else
                                            {
                                                DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                            }
                                        }
                                        else
                                        {
                                            DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                        }
                                    }
                                    else
                                    {
                                        DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                    }
                                }
                                else
                                {
                                    DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                }
                            }
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                        }
                    });

                    Task task4 = Task.Factory.StartNew(() =>
                    {
                        for (int i = 0; i < DesFileLen; i++)
                        {
                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                            string item = DestinationFiles[i].Replace(txtDestinationFolderPath.Text, "");
                            string itemPath = DestinationFiles[i];
                            string type = "File";
                            string itemMD5Hash = StringToMD5Hash(item);
                            string notAvalibleItemPath = txtSourceFolderPath.Text + item;
                            if (SourceFileLen == 0)
                            {
                                DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                            }
                            else
                            {
                                if (!File.Exists(txtSourceFolderPath.Text + item))
                                {
                                    DifferentFileSettings(item, itemPath, notAvalibleItemPath, type, itemMD5Hash);
                                }
                            }

                            if (operationCancel || flagOperationCancel)
                            {
                                flagOperationCancel = true;
                                
                                operationCancel = false;
                                break;
                            }
                        }
                    });
                    Task.WaitAll(task3, task4);
                });
                pbProgressBar.Visible = false;lbProcessing.Visible = false;
                if(flagOperationCancel)
                {
                    lvDifferent.Items.Clear();
                    lvDuplicate.Items.Clear();
                    MessageBox.Show("Analyse was Cancel","Notification",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Analyse was Complete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EnableOrDisableControls(true);
                btnAnalyseSettings.Enabled = true;
                btnCancel.Enabled = false;
                timer1.Start();
            }
        }

        private async void BtnSC_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);
                        f = 0;
                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string avalableItemPath = lvDifferent.Items[i].SubItems[1].Text;
                            string notAvalableItemPath = lvDifferent.Items[i].SubItems[2].Text;
                            string type = lvDifferent.Items[i].SubItems[3].Text;
                            string item = lvDifferent.Items[i].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;
                            if (type == "Folder")
                            {
                                if (!Directory.Exists(notAvalableItemPath))
                                {
                                    Directory.CreateDirectory(notAvalableItemPath);
                                }
                            }
                            else
                            {
                                if (!Directory.Exists(Path.GetDirectoryName(notAvalableItemPath)))
                                {
                                    Directory.CreateDirectory(notAvalableItemPath);
                                }
                                if (File.Exists(notAvalableItemPath) && File.Exists(avalableItemPath))
                                {
                                    if (f == 0 || f == 3 || f == 4)
                                    {
                                        DialogResult res = DKCustomMessageBox.Show("Files Name are same but size is different");

                                        if (res == DialogResult.No)
                                        {
                                            f = 1;
                                        }
                                        else if (res == DialogResult.Cancel)
                                        {
                                            f = 2;
                                        }
                                        else if (res == DialogResult.Yes)
                                        {
                                            f = 3;
                                        }
                                        else if (res == DialogResult.OK)
                                        {
                                            f = 4;
                                        }
                                    }
                                    if (f == 1 || f == 3)
                                    {
                                        if (File.Exists(avalableItemPath))
                                        {
                                            copyFile(avalableItemPath, notAvalableItemPath, true);
                                        }

                                    }
                                    if (f == 2 || f == 4)
                                    {
                                        string filename1 = Path.GetFileNameWithoutExtension(notAvalableItemPath) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}(2)", DateTime.Now);
                                        string fileext1 = Path.GetExtension(notAvalableItemPath);
                                        string fullfilepath1 = notAvalableItemPath.Replace(Path.GetFileName(notAvalableItemPath), (filename1 + fileext1));

                                        string filename2 = Path.GetFileNameWithoutExtension(avalableItemPath) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}(1)", DateTime.Now);
                                        string fileext2 = Path.GetExtension(avalableItemPath);
                                        string fullfilepath2 = avalableItemPath.Replace(Path.GetFileName(avalableItemPath), (filename2 + fileext2));

                                        if (!File.Exists(fullfilepath1) && !File.Exists(fullfilepath2))
                                        {
                                            if (File.Exists(avalableItemPath))
                                            {
                                                File.Move(avalableItemPath, fullfilepath2);
                                                if (File.Exists(notAvalableItemPath))
                                                {
                                                    File.Move(notAvalableItemPath, fullfilepath1);

                                                    if (File.Exists(fullfilepath2))
                                                    {
                                                        copyFile(fullfilepath2, notAvalableItemPath.Replace(Path.GetFileName(notAvalableItemPath), Path.GetFileName(fullfilepath2)));
                                                    }
                                                    if (File.Exists(fullfilepath1))
                                                    {
                                                        copyFile(fullfilepath1, avalableItemPath.Replace(Path.GetFileName(avalableItemPath), Path.GetFileName(fullfilepath1)));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (File.Exists(avalableItemPath))
                                    {
                                        copyFile(avalableItemPath, notAvalableItemPath);
                                    }
                                }
                            }
                        }
                        lvDifferent.Items.Clear();
                        lvDuplicate.Items.Clear();
                        lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                        lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                        calculatefilesandfolders(2);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Sync Completed");
                        EnableOrDisableControls(true);
                    });
                    timer1.Start();
                }

            }
            else
            {
                MessageBox.Show("Please Analyse Directory or Different Files and Folders not Found");
            }

        }

        private async void BtnSM_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);
                        ArrayList al = new ArrayList();
                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string item = lvDifferent.Items[i].Text;
                            string avalableItemPath = lvDifferent.Items[i].SubItems[1].Text;
                            string notAvalableItemPath = lvDifferent.Items[i].SubItems[2].Text;
                            string type = lvDifferent.Items[i].SubItems[3].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;
                            if (type == "Folder")
                            {
                                if (!Directory.Exists(notAvalableItemPath))
                                {
                                    al.Add(avalableItemPath);

                                    Directory.CreateDirectory(notAvalableItemPath);
                                }
                            }
                            else
                            {
                                if (!Directory.Exists(Path.GetDirectoryName(notAvalableItemPath)))
                                {
                                    Directory.CreateDirectory(notAvalableItemPath);
                                }
                                if (File.Exists(notAvalableItemPath) && File.Exists(avalableItemPath))
                                {
                                    string filename1 = Path.GetFileNameWithoutExtension(notAvalableItemPath) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}(2)", DateTime.Now);
                                    string fileext1 = Path.GetExtension(notAvalableItemPath);
                                    string fullfilepath1 = notAvalableItemPath.Replace(Path.GetFileName(notAvalableItemPath), (filename1 + fileext1));
                                    if (File.Exists(notAvalableItemPath))
                                    {
                                        File.Move(notAvalableItemPath, fullfilepath1);
                                        if (File.Exists(avalableItemPath))
                                        {
                                            File.Move(avalableItemPath, notAvalableItemPath);

                                            if (File.Exists(fullfilepath1))
                                            {
                                                File.Move(fullfilepath1, avalableItemPath);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (File.Exists(avalableItemPath))
                                    {
                                        File.Move(avalableItemPath, notAvalableItemPath);
                                    }
                                }
                            }

                        }
                        foreach (string p in al)
                        {
                            DeleteDirectory(p);
                        }
                        lvDifferent.Items.Clear();
                        lvDuplicate.Items.Clear();
                        lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                        lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                        calculatefilesandfolders(2);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Sync Completed");
                        EnableOrDisableControls(true);
                    });
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Please Analyse Directory or Different Files and Folders not Found");
            }
        }

        private async void BtnCopyLeftToRightFAF_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);

                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string item = lvDifferent.Items[i].Text;
                            string avaliableItem = lvDifferent.Items[i].SubItems[1].Text;
                            string notAvalibleIntem = lvDifferent.Items[i].SubItems[2].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;

                            if ((txtSourceFolderPath.Text + item) == avaliableItem)
                            {
                                string type = lvDifferent.Items[i].SubItems[3].Text;
                                if (type == "File")
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName(notAvalibleIntem)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(notAvalibleIntem));
                                    }
                                    if (File.Exists(avaliableItem) && File.Exists(notAvalibleIntem))
                                    {
                                        string filename1 = Path.GetFileNameWithoutExtension(avaliableItem) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
                                        string fileext1 = Path.GetExtension(avaliableItem);
                                        string fullfilepath1 = avaliableItem.Replace(Path.GetFileName(avaliableItem), (filename1 + fileext1));
                                        if (File.Exists(avaliableItem))
                                        {
                                            File.Move(avaliableItem, fullfilepath1);
                                            if (File.Exists(fullfilepath1))
                                            {
                                                copyFile(fullfilepath1, notAvalibleIntem.Replace(Path.GetFileName(notAvalibleIntem), (filename1 + fileext1)));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (File.Exists(avaliableItem))
                                        {
                                            copyFile(avaliableItem, notAvalibleIntem);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(notAvalibleIntem))
                                    {
                                        Directory.CreateDirectory(notAvalibleIntem);
                                    }
                                }

                            }
                        }
                        lvDifferent.Items.Clear();
                        lvDuplicate.Items.Clear();
                        lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                        calculatefilesandfolders(1);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Process Completed");
                        EnableOrDisableControls(true);
                    });

                    timer1.Start();
                }

            }
            else
            {
                MessageBox.Show("Please Analyse or there is no file different");
            }
        }

        private async void BtnCopyRightToLeftFAF_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);
                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string item = lvDifferent.Items[i].Text;
                            string avaliableItem = lvDifferent.Items[i].SubItems[1].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;
                            string notAvalibleItem = lvDifferent.Items[i].SubItems[2].Text;
                            if ((txtDestinationFolderPath.Text + item) == avaliableItem)
                            {
                                string type = lvDifferent.Items[i].SubItems[3].Text;
                                if (type == "File")
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName(notAvalibleItem)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(notAvalibleItem));
                                    }
                                    if (File.Exists(avaliableItem) && File.Exists(notAvalibleItem))
                                    {
                                        string filename1 = Path.GetFileNameWithoutExtension(avaliableItem) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
                                        string fileext1 = Path.GetExtension(avaliableItem);
                                        string fullfilepath1 = avaliableItem.Replace(Path.GetFileName(avaliableItem), (filename1 + fileext1));
                                        if (File.Exists(avaliableItem))
                                        {
                                            File.Move(avaliableItem, fullfilepath1);
                                            if (File.Exists(fullfilepath1))
                                            {
                                                copyFile(fullfilepath1, notAvalibleItem.Replace(Path.GetFileName(notAvalibleItem), (filename1 + fileext1)));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (File.Exists(avaliableItem))
                                        {
                                            copyFile(avaliableItem, notAvalibleItem);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(notAvalibleItem))
                                    {
                                        Directory.CreateDirectory(notAvalibleItem);
                                    }
                                }

                            }
                        }
                        lvDifferent.Items.Clear();
                        lvDuplicate.Items.Clear();
                        lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                        calculatefilesandfolders(0);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Process Completed");
                        EnableOrDisableControls(true);


                    });
                    timer1.Start();
                }


            }
            else
            {
                MessageBox.Show("Please Analyse or there is no file different");
            }
        }

        private async void BtnMoveLeftToRightFAF_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);
                        ArrayList arl = new ArrayList();
                        f = 0;
                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string item = lvDifferent.Items[i].Text;
                            string avaliableItem = lvDifferent.Items[i].SubItems[1].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;
                            if ((txtSourceFolderPath.Text + item) == avaliableItem)
                            {
                                string notAvalibleItem = lvDifferent.Items[i].SubItems[2].Text;
                                string type = lvDifferent.Items[i].SubItems[3].Text;
                                if (type == "File")
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName(notAvalibleItem)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(notAvalibleItem));
                                    }
                                    if (File.Exists(avaliableItem) && File.Exists(notAvalibleItem))
                                    {
                                        if (f == 0 || f == 3 || f == 4)
                                        {
                                            DialogResult res = DKCustomMessageBox.Show("Files Name are same but size is different");
                                            if (res == DialogResult.No)
                                            {
                                                f = 1;
                                            }
                                            else if (res == DialogResult.Cancel)
                                            {
                                                f = 2;
                                            }
                                            else if (res == DialogResult.Yes)
                                            {
                                                f = 3;
                                            }
                                            else if (res == DialogResult.OK)
                                            {
                                                f = 4;
                                            }
                                        }
                                        if (f == 1 || f == 3)
                                        {
                                            if (File.Exists(avaliableItem))
                                            {
                                                copyFile(avaliableItem, notAvalibleItem, true);
                                                DeleteFile(avaliableItem);
                                            }
                                        }
                                        if (f == 2 || f == 4)
                                        {
                                        repeat:
                                            string filename1 = Path.GetFileNameWithoutExtension(avaliableItem) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
                                            string fileext1 = Path.GetExtension(avaliableItem);
                                            string fullfilepath1 = notAvalibleItem.Replace(Path.GetFileName(notAvalibleItem), (filename1 + fileext1));
                                            if (!File.Exists(fullfilepath1))
                                            {
                                                if (File.Exists(avaliableItem))
                                                {
                                                    File.Move(avaliableItem, fullfilepath1);
                                                }
                                            }
                                            else
                                            {
                                                goto repeat;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (File.Exists(avaliableItem))
                                        {
                                            File.Move(avaliableItem, notAvalibleItem);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(notAvalibleItem))
                                    {
                                        Directory.CreateDirectory(notAvalibleItem);

                                    }
                                    arl.Add(avaliableItem);
                                }
                            }
                        }
                        foreach (string p in arl)
                        {
                            DeleteDirectory(p);
                        }
                        lvDifferent.Items.Clear();
                        lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                        lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                        calculatefilesandfolders(2);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Process Completed");

                        EnableOrDisableControls(true);


                    });

                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Please Analyse or there is no file different");
            }
        }

        private async void BtnMoveRightToLeftFAF_Click(object sender, EventArgs e)
        {
            if (lvDifferent.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                {
                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    await Task.Run(() =>
                    {
                        EnableOrDisableControls(false);
                        ArrayList arl = new ArrayList();
                        f = 0;
                        for (int i = 0; i < lvDifferent.Items.Count; i++)
                        {
                            string item = lvDifferent.Items[i].Text;
                            string avaliableItem = lvDifferent.Items[i].SubItems[1].Text;
                            string itemMD5Hash = lvDifferent.Items[i].SubItems[4].Text;
                            if ((txtDestinationFolderPath.Text + item) == avaliableItem)
                            {
                                string notAvalibleItem = lvDifferent.Items[i].SubItems[2].Text;
                                string type = lvDifferent.Items[i].SubItems[3].Text;
                                if (type == "File")
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName(notAvalibleItem)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(notAvalibleItem));
                                    }
                                    if (File.Exists(avaliableItem) && File.Exists(notAvalibleItem))
                                    {
                                        if (f == 0 || f == 3 || f == 4)
                                        {
                                            DialogResult res = DKCustomMessageBox.Show("Files Name are same but size is different");
                                            if (res == DialogResult.No)
                                            {
                                                f = 1;
                                            }
                                            else if (res == DialogResult.Cancel)
                                            {
                                                f = 2;
                                            }
                                            else if (res == DialogResult.Yes)
                                            {
                                                f = 3;
                                            }
                                            else if (res == DialogResult.OK)
                                            {
                                                f = 4;
                                            }
                                        }
                                        if (f == 1 || f == 3)
                                        {
                                            if (File.Exists(avaliableItem))
                                            {
                                                copyFile(avaliableItem, notAvalibleItem, true);
                                                DeleteFile(avaliableItem);
                                            }
                                        }
                                        if (f == 2 || f == 4)
                                        {
                                        repeat:
                                            string filename1 = Path.GetFileNameWithoutExtension(avaliableItem) + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
                                            string fileext1 = Path.GetExtension(avaliableItem);
                                            string fullfilepath1 = notAvalibleItem.Replace(Path.GetFileName(notAvalibleItem), (filename1 + fileext1));
                                            if (!File.Exists(fullfilepath1))
                                            {
                                                if (File.Exists(avaliableItem))
                                                {
                                                    File.Move(avaliableItem, fullfilepath1);
                                                }
                                            }
                                            else
                                            {
                                                goto repeat;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (File.Exists(avaliableItem))
                                        {
                                            File.Move(avaliableItem, notAvalibleItem);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(notAvalibleItem))
                                    {
                                        Directory.CreateDirectory(notAvalibleItem);
                                    }
                                    arl.Add(avaliableItem);
                                }
                            }
                        }
                        foreach (string p in arl)
                        {
                            DeleteDirectory(p);
                        }
                        lvDifferent.Items.Clear();
                        lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                        lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                        calculatefilesandfolders(2);
                        pbProgressBar.Visible = false;lbProcessing.Visible = false;
                        MessageBox.Show("Process Completed");

                        EnableOrDisableControls(true);


                    });

                    timer1.Start();
                }


            }
            else
            {
                MessageBox.Show("Please Analyse or there is no file different");
            }
        }

        private async void BtnCopyDuplicate_Click(object sender, EventArgs e)
        {
            if (lvDuplicate.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {

                CommonOpenFileDialog dialog = new CommonOpenFileDialog()
                { IsFolderPicker = true };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                    {
                        timer1.Stop();
                        pbProgressBar.Visible = true;lbProcessing.Visible = true;
                        await Task.Run(() =>
                        {
                            EnableOrDisableControls(false);


                            for (int i = 0; i < lvDuplicate.Items.Count; i++)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "Folder")
                                {
                                    if (!Directory.Exists((dialog.FileName) + item))
                                    {
                                        Directory.CreateDirectory(dialog.FileName + item);
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName((dialog.FileName) + item)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName((dialog.FileName) + item));
                                    }
                                    if (File.Exists(txtSourceFolderPath.Text + item))
                                    {
                                        copyFile(txtSourceFolderPath.Text + item, (dialog.FileName) + item);
                                    }
                                }
                            }
                            pbProgressBar.Visible = false;lbProcessing.Visible = false;
                            MessageBox.Show("Process Completed");

                            EnableOrDisableControls(true);


                        });

                        timer1.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Somthing Wrong");
            }
        }

        private async void BtnMoveDuplicate_Click(object sender, EventArgs e)
        {
            if (lvDuplicate.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {

                CommonOpenFileDialog dialog = new CommonOpenFileDialog()
                { IsFolderPicker = true };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if (confirmMessage("You can't cancel/undo/redo operation do you want to continue?"))
                    {
                        timer1.Stop();
                        pbProgressBar.Visible = true;lbProcessing.Visible = true;
                        await Task.Run(() =>
                        {
                            EnableOrDisableControls(false);


                            ArrayList al = new ArrayList();
                            for (int i = 0; i < lvDuplicate.Items.Count; i++)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                string itemMD5Hash = lvDuplicate.Items[i].SubItems[2].Text;
                                if (type == "Folder")
                                {
                                    if (!Directory.Exists((dialog.FileName) + item))
                                    {
                                        Directory.CreateDirectory(dialog.FileName + item);
                                        al.Add(item);
                                    }
                                }
                                else
                                {
                                    if (!Directory.Exists(Path.GetDirectoryName((dialog.FileName) + item)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName((dialog.FileName) + item));
                                    }
                                    if (File.Exists(txtSourceFolderPath.Text + item))
                                    {
                                        File.Move(txtSourceFolderPath.Text + item, (dialog.FileName) + item);
                                        DeleteFile(txtDestinationFolderPath.Text + item);
                                    }
                                }
                            }
                            foreach (string p in al)
                            {
                                DeleteDirectory(txtSourceFolderPath.Text + p);
                                DeleteDirectory(txtDestinationFolderPath.Text + p);
                            }
                            lvDuplicate.Items.Clear();
                            lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                            lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                            calculatefilesandfolders(2);
                            pbProgressBar.Visible = false;lbProcessing.Visible = false;
                            MessageBox.Show("Process Completed");

                            EnableOrDisableControls(true);


                        });

                        timer1.Start();
                    }


                }
            }
            else
            {
                MessageBox.Show("Somthing Wrong");
            }
        }

        private async void BtnDDFS_Click(object sender, EventArgs e)
        {
            if (lvDuplicate.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (MessageBox.Show("Do you want sure delete file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    timer1.Stop();
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;
                    EnableOrDisableControls(false);
                    await Task.Run(() =>
                    {
                        if (cbLeftFilesSubfoldersDelete.Checked && cbRightFilesSubfoldersDelete.Checked)
                        {
                            for (int i = lvDuplicate.Items.Count - 1; i >= 0; i--)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtDestinationFolderPath.Text + item);
                                    DeleteFile(txtSourceFolderPath.Text + item);
                                }
                                else
                                {
                                    DeleteDirectory(txtDestinationFolderPath.Text + item);
                                    DeleteDirectory(txtSourceFolderPath.Text + item);
                                }
                            }
                        }
                        else if (cbRightFilesSubfoldersDelete.Checked && !cbLeftFilesSubfoldersDelete.Checked)
                        {
                            for (int i = lvDuplicate.Items.Count - 1; i >= 0; i--)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtDestinationFolderPath.Text + item);
                                }
                                else
                                {
                                    DeleteDirectory(txtDestinationFolderPath.Text + item);
                                }
                            }
                        }
                        else if (!cbRightFilesSubfoldersDelete.Checked && cbLeftFilesSubfoldersDelete.Checked)
                        {
                            for (int i = lvDuplicate.Items.Count - 1; i >= 0; i--)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtSourceFolderPath.Text + item);
                                }
                                else
                                {
                                    DeleteDirectory(txtSourceFolderPath.Text + item);
                                }

                            }
                        }
                    });
                    lvDuplicate.Items.Clear();
                    lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                    lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                    calculatefilesandfolders(2);
                    pbProgressBar.Visible = false;lbProcessing.Visible = false;
                    MessageBox.Show("Process Completed");
                    EnableOrDisableControls(true);
                    timer1.Start();

                }
            }
            else
            {
                MessageBox.Show("Please Analyse Directory or Duplicate Files and Folders not Found");
            }
        }

        private async void BtnDDF_Click(object sender, EventArgs e)
        {
            if (lvDuplicate.Items.Count != 0 && txtSourceFolderPath.Text != "" && txtDestinationFolderPath.Text != "" && Directory.Exists(txtSourceFolderPath.Text) && Directory.Exists(txtDestinationFolderPath.Text))
            {
                if (MessageBox.Show("Do you want sure delete file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    timer1.Stop();
                    EnableOrDisableControls(false);
                    pbProgressBar.Visible = true;lbProcessing.Visible = true;

                    await Task.Run(() =>
                    {
                        if (cbLeftFileDelete.Checked && cbRightFileDelete.Checked)
                        {
                            for (int i = 0; i < lvDuplicate.Items.Count; i++)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtDestinationFolderPath.Text + item);
                                    DeleteFile(txtSourceFolderPath.Text + item);
                                }
                            }
                        }
                        else if (cbRightFileDelete.Checked && !cbLeftFileDelete.Checked)
                        {
                            for (int i = 0; i < lvDuplicate.Items.Count; i++)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtDestinationFolderPath.Text + item);
                                }
                            }

                        }
                        else if (!cbRightFileDelete.Checked && cbLeftFileDelete.Checked)
                        {
                            for (int i = 0; i < lvDuplicate.Items.Count; i++)
                            {
                                string item = lvDuplicate.Items[i].Text;
                                string type = lvDuplicate.Items[i].SubItems[1].Text;
                                if (type == "File")
                                {
                                    DeleteFile(txtSourceFolderPath.Text + item);
                                }
                            }
                        }
                    });
                    lvDuplicate.Items.Clear();


                    lbLeftSideFolderSize.Text = GetFolderSize(txtSourceFolderPath.Text);
                    lbRightSideFolderSize.Text = GetFolderSize(txtDestinationFolderPath.Text);
                    calculatefilesandfolders(2);
                    pbProgressBar.Visible = false;lbProcessing.Visible = false;
                    MessageBox.Show("Process Completed");
                    EnableOrDisableControls(true);
                    timer1.Start();

                }

            }
            else
            {
                MessageBox.Show("Please Analyse Directory or Duplicate Files and Folders not Found");
            }
        }


        private void BtnCopyLeftToRightFAF_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnCopyLeftToRightFAF, "Copy SubFolders and Files From Left To Right Side which are not avalible.");
        }

        private void BtnCopyRightToLeftFAF_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnCopyRightToLeftFAF, "Copy SubFolders and Files From Right To Left Side which are not avalible.");
        }

        private void BtnMoveLeftToRightFAF_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnMoveLeftToRightFAF, "Move SubFolders and Files From Left To Right Side which are not avalible.");
        }

        private void BtnMoveRightToLeftFAF_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnMoveRightToLeftFAF, "Move SubFolders and Files From Right To Left Side which are not avalible.");
        }

        private void BtnBrowseLeft_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnBL, "Add Folder");

        }

        private void BtnBrowseRight_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnBR, "Add Folder");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (txtSourceFolderPath.Text == "" || txtDestinationFolderPath.Text == "" || !Directory.Exists(txtSourceFolderPath.Text) || !Directory.Exists(txtDestinationFolderPath.Text))
            {
                btnAnalyse.Enabled = false;
                btnSC_FAF.Enabled = false;
                btnSM_FAF.Enabled = false;
                btnCopyDuplicate.Enabled = false;
                btnMoveDuplicate.Enabled = false;
                btnDDF.Enabled = false;
                btnDDFS.Enabled = false;
                btnCopyLeftToRightFAF.Enabled = false;
                btnCopyRightToLeftFAF.Enabled = false;
                btnMoveLeftToRightFAF.Enabled = false;
                btnMoveRightToLeftFAF.Enabled = false;
            }
            else
            {
                EnableOrDisableControls(true);
            }
            if (txtSourceFolderPath.Text != "")
            {
                if (!Directory.Exists(txtSourceFolderPath.Text))
                {
                    txtSourceFolderName.Clear();
                    txtSourceFolderPath.Clear();
                    lbNoOfSourceFiles.Text = "";
                    lbNoOfSourceFolders.Text = "";
                    lbLeftSideFolderSize.Text = "";
                    lvDifferent.Items.Clear();
                    lvDuplicate.Items.Clear();
                }
            }
            if (txtDestinationFolderPath.Text != "")
            {
                if (!Directory.Exists(txtDestinationFolderPath.Text))
                {
                    txtDestinationFolderName.Clear();
                    txtDestinationFolderPath.Clear();
                    lbNoOfDestinationFiles.Text = "";
                    lbNoOfDestinationFolders.Text = "";
                    lbRightSideFolderSize.Text = "";
                    lvDifferent.Items.Clear();
                    lvDuplicate.Items.Clear();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSourceFolderName.Clear();
            txtDestinationFolderName.Clear();
            lbLeftSideFolderSize.Text = string.Empty;
            lbRightSideFolderSize.Text = string.Empty;
            lbNoOfSourceFiles.Text = string.Empty;
            lbNoOfSourceFolders.Text = string.Empty;
            lbNoOfDestinationFiles.Text = string.Empty;
            lbNoOfDestinationFolders.Text = string.Empty;
            txtSourceFolderPath.Clear();
            txtDestinationFolderPath.Clear();


            lvDifferent.Items.Clear();
            lvDuplicate.Items.Clear();
            cbLeftFileDelete.Checked = false;
            cbRightFileDelete.Checked = false;
            cbLeftFilesSubfoldersDelete.Checked = false;
            cbRightFilesSubfoldersDelete.Checked = false;
        }

        private void PbCopySourceFolderName_Click(object sender, EventArgs e)
        {
            if (txtSourceFolderName.Text != string.Empty)
            {
                Clipboard.SetText(txtSourceFolderName.Text);
                NotificationManager.Show(this, "Copied ", Color.Green, Color.Black, Color.White, 1500);
            }
        }

        private void PbCopySourceFolderPath_Click(object sender, EventArgs e)
        {
            if (txtSourceFolderPath.Text != string.Empty)
            {
                Clipboard.SetText(txtSourceFolderPath.Text);
                NotificationManager.Show(this, "Copied", Color.Green, Color.Black, Color.White, 1500);
            }
        }

        private void PbCopyDestinationFolderName_Click(object sender, EventArgs e)
        {
            if (txtDestinationFolderName.Text != string.Empty)
            {
                Clipboard.SetText(txtDestinationFolderName.Text);
                NotificationManager.Show(this, "Copied", Color.Green, Color.Black, Color.White, 1500);
            }
        }

        private void PbCopyDestinationFolderPath_Click(object sender, EventArgs e)
        {
            if (txtDestinationFolderPath.Text != string.Empty)
            {
                Clipboard.SetText(txtDestinationFolderPath.Text);
                NotificationManager.Show(this, "Copied", Color.Green, Color.Black, Color.White, 1500);
            }
        }

        private void BtnAnalyseSettings_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            operationCancel = true;
        }

        Boolean confirmMessage(string msg)
        {
            if (MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
