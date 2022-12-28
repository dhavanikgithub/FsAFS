using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FsAFS
{
    public partial class Form2 : Form
    {
        string[] filetype_name = new string[404];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FsAFS_Database.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cobSizeFrom.SelectedIndex = 0;
            cobSizeTo.SelectedIndex = 0;
            txtSizeFrom.Text = "0";
            txtSizeTo.Text = "0";
            cobType.SelectedIndex = 0;
            EnableDisableControls(false);
            lbTotalCountSD.Text = "";
            lbTotalCountDelete.Text = "";

            string Imagepath = AppDomain.CurrentDomain.BaseDirectory;
            Imagepath = Imagepath.Replace(@"bin\Debug\", @"Resources\");
            string filetype_name_path = Imagepath + @"src\filetype_name.txt";


            if (File.Exists(filetype_name_path))
            {
                filetype_name = File.ReadAllText(filetype_name_path).Split(',');
                //MessageBox.Show(Imagepath + @"filetype_icon\" + filetype_name[0] + ".png");
            }
            ImageList img = new ImageList() { ImageSize = new Size(30,30) };

            //<>
            img.Images.Add(Image.FromFile(Imagepath + @"img\filetype_icon\blank.png"));
            for (int i = 0; i < filetype_name.Length; i++)
            {
                string filename = filetype_name[i];

                img.Images.Add(Image.FromFile(Imagepath + @"img\filetype_icon\" + filename + ".png"));
            }
            //</>

            //<>
            lvCopyFromSource.SmallImageList = img;
            lvDeleteItem.SmallImageList = img;
            //</>

            
            
            if (Properties.Settings.Default.DifferentSettings==null || Properties.Settings.Default.DifferentSettings=="Default")
            {
                rbDefault.Checked = true;
            }
            else
            {
                rbOther.Checked = true;
                
                string settingData = Properties.Settings.Default.DifferentSettings;
                string[] SplitsSettingData = settingData.Split(',');
                if (SplitsSettingData[0] == "SizeCreated DateType")
                {
                    cbSize.Checked = true;
                    cbCreatedDate.Checked = true;
                    cbType.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                    dtpCDateFrom.Value = DateTime.Parse(SplitsSettingData[5]);
                    dtpCDateTo.Value = DateTime.Parse(SplitsSettingData[6]);
                    cobType.SelectedItem = SplitsSettingData[7];
                }
                else if (SplitsSettingData[0] == "SizeCreated DateCustom Type")
                {
                    cbSize.Checked = true;
                    cbCreatedDate.Checked = true;
                    cbCustomType.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                    dtpCDateFrom.Value = DateTime.Parse(SplitsSettingData[5]);
                    dtpCDateTo.Value = DateTime.Parse(SplitsSettingData[6]);
                    txtCType.Text = SplitsSettingData[7];
                }
                else if (SplitsSettingData[0] == "Created DateType")
                {
                    cbCreatedDate.Checked = true;
                    cbType.Checked = true;
                    dtpCDateFrom.Value = DateTime.Parse(SplitsSettingData[1]);
                    dtpCDateTo.Value = DateTime.Parse(SplitsSettingData[2]);
                    cobType.SelectedItem = SplitsSettingData[3];
                    cbSize.Checked = false;
                }
                else if (SplitsSettingData[0] == "Created DateCustom Type")
                {
                    cbCreatedDate.Checked = true;
                    cbCustomType.Checked = true;
                    dtpCDateFrom.Value = DateTime.Parse(SplitsSettingData[1]);
                    dtpCDateTo.Value = DateTime.Parse(SplitsSettingData[2]);
                    txtCType.Text = SplitsSettingData[3];
                    cbSize.Checked = false;
                }
                else if (SplitsSettingData[0] == "SizeCreated Date")
                {
                    cbSize.Checked = true;
                    cbCreatedDate.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                    dtpCDateFrom.Value = DateTime.Parse(SplitsSettingData[5]);
                    dtpCDateTo.Value = DateTime.Parse(SplitsSettingData[6]);
                }
                else if (SplitsSettingData[0] == "SizeType")
                {
                    cbSize.Checked = true;
                    cbType.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                    cobType.SelectedItem = SplitsSettingData[5];
                }
                else if (SplitsSettingData[0] == "SizeCustom Type")
                {
                    cbSize.Checked = true;
                    cbCustomType.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                    txtCType.Text = SplitsSettingData[5];
                }
                else if (SplitsSettingData[0]=="Size")
                {
                    cbSize.Checked = true;
                    txtSizeFrom.Text = SplitsSettingData[1];
                    cobSizeFrom.SelectedItem = SplitsSettingData[2];
                    txtSizeTo.Text = SplitsSettingData[3];
                    cobSizeTo.SelectedItem = SplitsSettingData[4];
                }
                else if(SplitsSettingData[0]=="Created Date")
                {
                    cbCreatedDate.Checked = true;
                    DateTime dateTimeFrom = DateTime.Parse(SplitsSettingData[1]);
                    dtpCDateFrom.Value = dateTimeFrom;
                    DateTime dateTimeTo = DateTime.Parse(SplitsSettingData[2]);
                    dtpCDateTo.Value = dateTimeTo;
                    cbSize.Checked = false;
                }
                else if(SplitsSettingData[0]=="Type")
                {
                    cbType.Checked = true;
                    cobType.SelectedItem = SplitsSettingData[1];
                    cbSize.Checked = false;
                }
                else if(SplitsSettingData[0]=="Custom Type")
                {
                    cbCustomType.Checked = true;
                    txtCType.Text = SplitsSettingData[1];
                    cbSize.Checked = false;
                }
            }
            //</>
            
            
        }


        void AddItemListViewCopyFromSource(params string[] s)
        {
            var iconCode = 0;
            string fileext = Path.GetExtension(s[0]).ToLower();
            fileext = fileext.Replace(".", "");
            int index = Array.IndexOf(filetype_name, fileext);
            if (index != -1)
            {
                iconCode = index + 1;
            }
            ListViewItem item = new ListViewItem(s[0],iconCode);
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, s[1]);
            ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, s[2]);
            item.SubItems.Add(subitem1);
            item.SubItems.Add(subitem2);
            lvCopyFromSource.Items.Add(item);
            lvCopyFromSource.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvCopyFromSource.EnsureVisible(lvCopyFromSource.Items.Count - 1);
            lbTotalCountSD.Text = lvCopyFromSource.Items.Count.ToString();
        }

        void AddItemListViewDeleteItem(params string[] s)
        {
            var iconCode = 0;
            string fileext = Path.GetExtension(s[0]).ToLower();
            fileext = fileext.Replace(".", "");
            int index = Array.IndexOf(filetype_name, fileext);
            if (index != -1)
            {
                iconCode = index + 1;
            }
            ListViewItem item = new ListViewItem(s[0],iconCode);
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, s[1]);
            item.SubItems.Add(subitem1);
            lvDeleteItem.Items.Add(item);
            lvDeleteItem.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDeleteItem.EnsureVisible(lvDeleteItem.Items.Count - 1);
            lbTotalCountDelete.Text = lvDeleteItem.Items.Count.ToString();
        }

        void EnableDisableControls(bool ed)
        {
            txtSizeFrom.Enabled = ed;
            txtSizeTo.Enabled = ed;
            cobSizeFrom.Enabled = ed;
            cobSizeTo.Enabled = ed;
            txtCType.Enabled = ed;
            cobType.Enabled = ed;
            dtpCDateFrom.Enabled = ed;
            dtpCDateTo.Enabled = ed;
            cbSize.Enabled = ed;
            cbType.Enabled = ed;
            cbCustomType.Enabled = ed;
            cbCreatedDate.Enabled = ed;
            lbSizeTo.Enabled = ed;
            lbCDateTo.Enabled = ed;
            lbCTypeExample.Enabled = ed;
        }

        private void cobType_KeyPress(object sender, KeyPressEventArgs e)
        {
            cobType.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = cobType.Text.Substring(0, cobType.SelectionStart) + e.KeyChar;
            Int32 index = cobType.FindStringExact(str);
            if (index == -1)
            {
                index = cobType.FindString(str);
            }
            this.cobType.SelectedIndex = index;
            this.cobType.SelectionStart = str.Length;
            this.cobType.SelectionLength = this.cobType.Text.Length - this.cobType.SelectionStart;
            e.Handled = true;
        }

        private void btnDiffSaveSettings_Click(object sender, EventArgs e)
        {
            if(rbDefault.Checked)
            {
                Properties.Settings.Default.DifferentSettings = string.Format("{0}",rbDefault.Text);
            }
            else if(rbOther.Checked)
            {
                if (txtSizeFrom.Text == "")
                {
                    txtSizeFrom.Text = "0";
                }
                if (txtSizeTo.Text == "")
                {
                    txtSizeTo.Text = "0";
                }
                if (cbSize.Checked && cbCreatedDate.Checked && cbType.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", cbSize.Text+cbCreatedDate.Text+cbType.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text,dtpCDateFrom.Text,dtpCDateTo.Text,cobType.Text);
                }
                else if(cbSize.Checked && cbCreatedDate.Checked && cbCustomType.Checked)
                {
                    if (txtCType.Text != "")
                    {
                        Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", cbSize.Text + cbCreatedDate.Text + cbCustomType.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text, dtpCDateFrom.Text, dtpCDateTo.Text, txtCType.Text);
                    }
                }
                else if(cbSize.Checked && cbCreatedDate.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4},{5},{6}", cbSize.Text + cbCreatedDate.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text, dtpCDateFrom.Text, dtpCDateTo.Text);
                }
                else if(cbCreatedDate.Checked && cbType.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3}",cbCreatedDate.Text + cbType.Text, dtpCDateFrom.Text, dtpCDateTo.Text, cobType.Text);
                }
                else if(cbCreatedDate.Checked && cbCustomType.Checked)
                {
                    if(txtCType.Text!="")
                    {
                        Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3}", cbCreatedDate.Text + cbCustomType.Text, dtpCDateFrom.Text, dtpCDateTo.Text, txtCType.Text);
                    }
                }
                else if(cbSize.Checked && cbType.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4},{5}", cbSize.Text+ cbType.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text, cobType.Text);
                }
                else if(cbSize.Checked && cbCustomType.Checked)
                {
                    if(txtCType.Text!="")
                    {
                        Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4},{5}", cbSize.Text + cbCustomType.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text, txtCType.Text);
                    }
                }
                else if (cbSize.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2},{3},{4}", cbSize.Text, txtSizeFrom.Text, cobSizeFrom.Text, txtSizeTo.Text, cobSizeTo.Text);
                }
                else if (cbCreatedDate.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1},{2}", cbCreatedDate.Text, dtpCDateFrom.Text, dtpCDateTo.Text);
                }
                else if (cbType.Checked)
                {
                    Properties.Settings.Default.DifferentSettings = string.Format("{0},{1}", cbType.Text, cobType.Text);
                }
                else if (cbCustomType.Checked)
                {
                    if (txtCType.Text != "")
                    {
                        Properties.Settings.Default.DifferentSettings = string.Format("{0},{1}", cbCustomType.Text, txtCType.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter File Extenction", "Custom Type Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            Properties.Settings.Default.Save();
            NotificationManager.Show(this, "Settings Saved", Color.Green, Color.Black, Color.White, 900);
        }

        private void txtSizeFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtSizeTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSize.Checked)
            {
                txtSizeFrom.Enabled = true;
                txtSizeTo.Enabled = true;
                cobSizeFrom.Enabled = true;
                cobSizeTo.Enabled = true;
            }
            else
            {
                if(cbCreatedDate.Checked || cbType.Checked || cbCustomType.Checked)
                {
                    txtSizeFrom.Enabled = false;
                    txtSizeTo.Enabled = false;
                    cobSizeFrom.Enabled = false;
                    cobSizeTo.Enabled = false;
                }
                else
                {
                    cbSize.Checked = true;
                }
            }
        }

        private void cbCreatedDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCreatedDate.Checked)
            {
                dtpCDateFrom.Enabled = true;
                dtpCDateTo.Enabled = true;
            }
            else
            {
                if (cbType.Checked || cbCustomType.Checked || cbSize.Checked)
                {
                    dtpCDateFrom.Enabled = false;
                    dtpCDateTo.Enabled = false;
                }
                else
                {
                    cbCreatedDate.Checked = true;
                }
            }
        }

        private void cbType_CheckedChanged(object sender, EventArgs e)
        {
            if (cbType.Checked)
            {
                cbCustomType.Checked = false;
                cobType.Enabled = true;
            }
            else
            {
                if (cbCreatedDate.Checked || cbCustomType.Checked || cbSize.Checked)
                {
                    cobType.Enabled = false;
                }
                else
                {
                    cbType.Checked = true;
                }
            }
        }

        private void cbCustomType_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomType.Checked)
            {
                cbType.Checked = false;
                txtCType.Enabled = true;
            }
            else
            {
                if (cbCreatedDate.Checked || cbType.Checked || cbSize.Checked)
                {
                    txtCType.Enabled = false;
                }
                else
                {
                    cbCustomType.Checked = true;
                }
            }
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            if(rbOther.Checked)
            {
                cbSize_CheckedChanged(sender, e);
                cbSize.Enabled = true;
                cbCreatedDate.Enabled = true;
                cbType.Enabled = true;
                cbCustomType.Enabled = true;
            }
            else
            {
                EnableDisableControls(false);
            }
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.DifferentSettings);
        }

        private void btnCopyItemLoadData_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from copy_item_list", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AddItemListViewCopyFromSource(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(3).ToString());
                }
            }
            con.Close();
            
        }

        private void btnDeleteItemLoadData_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from delete_item_list", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AddItemListViewDeleteItem(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString());
                }
            }
            con.Close();
            
        }
    }
}
