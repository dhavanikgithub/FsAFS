using System;
using System.Windows.Forms;

namespace FsAFS
{
    public partial class DKCustomMessageBox : Form
    {
        public DKCustomMessageBox()
        {
            InitializeComponent();
        }
        public static DialogResult Show(string Text)
        {
            DKCustomMessageBox messageBox = new DKCustomMessageBox();
            messageBox.label1.Text = Text;
            messageBox.ShowDialog();
            return messageBox.DialogResult;
        }
        private void btnOverride_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                DialogResult = DialogResult.No;
            }
            else
            {
                DialogResult = DialogResult.Yes;
            }
            
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

       

    }
}
