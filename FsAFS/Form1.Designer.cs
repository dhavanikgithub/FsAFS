
namespace FsAFS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbLeftFileDelete = new System.Windows.Forms.CheckBox();
            this.cbRightFileDelete = new System.Windows.Forms.CheckBox();
            this.cbLeftFilesSubfoldersDelete = new System.Windows.Forms.CheckBox();
            this.cbRightFilesSubfoldersDelete = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDDFS = new System.Windows.Forms.Button();
            this.lvDifferent = new System.Windows.Forms.ListView();
            this.lvDuplicate = new System.Windows.Forms.ListView();
            this.lbDifferent = new System.Windows.Forms.Label();
            this.lbDuplicate = new System.Windows.Forms.Label();
            this.panelDestinationFolder = new System.Windows.Forms.Panel();
            this.pbCopyDestinationFolderPath = new System.Windows.Forms.PictureBox();
            this.pbCopyDestinationFolderName = new System.Windows.Forms.PictureBox();
            this.txtDestinationFolderName = new System.Windows.Forms.TextBox();
            this.txtDestinationFolderPath = new System.Windows.Forms.TextBox();
            this.lbNoOfDestinationFolders = new System.Windows.Forms.Label();
            this.lbDestinationFolderName = new System.Windows.Forms.Label();
            this.lbNoOfDestinationFiles = new System.Windows.Forms.Label();
            this.lbDestinationFolderPath = new System.Windows.Forms.Label();
            this.btnBR = new System.Windows.Forms.Button();
            this.lbRightSideFolderSize = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSourceFolder = new System.Windows.Forms.Panel();
            this.pbCopySourceFolderPath = new System.Windows.Forms.PictureBox();
            this.pbCopySourceFolderName = new System.Windows.Forms.PictureBox();
            this.lbSourceFolderName = new System.Windows.Forms.Label();
            this.lbSourceFolderPath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLeftSideFolderSize = new System.Windows.Forms.Label();
            this.txtSourceFolderName = new System.Windows.Forms.TextBox();
            this.txtSourceFolderPath = new System.Windows.Forms.TextBox();
            this.lbNoOfSourceFolders = new System.Windows.Forms.Label();
            this.lbNoOfSourceFiles = new System.Windows.Forms.Label();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnMoveRightToLeftFAF = new System.Windows.Forms.Button();
            this.btnCopyDuplicate = new System.Windows.Forms.Button();
            this.btnCopyRightToLeftFAF = new System.Windows.Forms.Button();
            this.btnMoveLeftToRightFAF = new System.Windows.Forms.Button();
            this.btnCopyLeftToRightFAF = new System.Windows.Forms.Button();
            this.btnMoveDuplicate = new System.Windows.Forms.Button();
            this.btnSM_FAF = new System.Windows.Forms.Button();
            this.btnSC_FAF = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelBottom1 = new System.Windows.Forms.Panel();
            this.lbProcessing = new System.Windows.Forms.Label();
            this.pbProgressBar = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAnalyseSettings = new System.Windows.Forms.Button();
            this.panelBottom2 = new System.Windows.Forms.Panel();
            this.panelMiddel1 = new System.Windows.Forms.Panel();
            this.panelSD = new System.Windows.Forms.Panel();
            this.btnGotoTOPDuplicate = new System.Windows.Forms.Button();
            this.btnGotoBOTTOMDuplicate = new System.Windows.Forms.Button();
            this.btnGotoBOTTOMDifferent = new System.Windows.Forms.Button();
            this.btnGotoTOPDifferent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDifferentTotalCountTXT = new System.Windows.Forms.Label();
            this.lbDifferentTotalCount = new System.Windows.Forms.Label();
            this.lbDuplicateTotalCount = new System.Windows.Forms.Label();
            this.lbDuplicateTotalCountTXT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelDestinationFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyDestinationFolderPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyDestinationFolderName)).BeginInit();
            this.panelSourceFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopySourceFolderPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopySourceFolderName)).BeginInit();
            this.panelBottom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgressBar)).BeginInit();
            this.panelBottom2.SuspendLayout();
            this.panelMiddel1.SuspendLayout();
            this.panelSD.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLeftFileDelete
            // 
            this.cbLeftFileDelete.AutoSize = true;
            this.cbLeftFileDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeftFileDelete.Location = new System.Drawing.Point(12, 32);
            this.cbLeftFileDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeftFileDelete.Name = "cbLeftFileDelete";
            this.cbLeftFileDelete.Size = new System.Drawing.Size(75, 21);
            this.cbLeftFileDelete.TabIndex = 18;
            this.cbLeftFileDelete.Text = "Source";
            this.cbLeftFileDelete.UseVisualStyleBackColor = true;
            // 
            // cbRightFileDelete
            // 
            this.cbRightFileDelete.AutoSize = true;
            this.cbRightFileDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRightFileDelete.Location = new System.Drawing.Point(12, 53);
            this.cbRightFileDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRightFileDelete.Name = "cbRightFileDelete";
            this.cbRightFileDelete.Size = new System.Drawing.Size(101, 21);
            this.cbRightFileDelete.TabIndex = 19;
            this.cbRightFileDelete.Text = "Destination";
            this.cbRightFileDelete.UseVisualStyleBackColor = true;
            // 
            // cbLeftFilesSubfoldersDelete
            // 
            this.cbLeftFilesSubfoldersDelete.AutoSize = true;
            this.cbLeftFilesSubfoldersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeftFilesSubfoldersDelete.Location = new System.Drawing.Point(16, 32);
            this.cbLeftFilesSubfoldersDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeftFilesSubfoldersDelete.Name = "cbLeftFilesSubfoldersDelete";
            this.cbLeftFilesSubfoldersDelete.Size = new System.Drawing.Size(75, 21);
            this.cbLeftFilesSubfoldersDelete.TabIndex = 20;
            this.cbLeftFilesSubfoldersDelete.Text = "Source";
            this.cbLeftFilesSubfoldersDelete.UseVisualStyleBackColor = true;
            // 
            // cbRightFilesSubfoldersDelete
            // 
            this.cbRightFilesSubfoldersDelete.AutoSize = true;
            this.cbRightFilesSubfoldersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRightFilesSubfoldersDelete.Location = new System.Drawing.Point(16, 53);
            this.cbRightFilesSubfoldersDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRightFilesSubfoldersDelete.Name = "cbRightFilesSubfoldersDelete";
            this.cbRightFilesSubfoldersDelete.Size = new System.Drawing.Size(101, 21);
            this.cbRightFilesSubfoldersDelete.TabIndex = 21;
            this.cbRightFilesSubfoldersDelete.Text = "Destination";
            this.cbRightFilesSubfoldersDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDDF);
            this.groupBox1.Controls.Add(this.cbLeftFileDelete);
            this.groupBox1.Controls.Add(this.cbRightFileDelete);
            this.groupBox1.Location = new System.Drawing.Point(10, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 88);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duplicate Files";
            // 
            // btnDDF
            // 
            this.btnDDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnDDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDDF.Image = ((System.Drawing.Image)(resources.GetObject("btnDDF.Image")));
            this.btnDDF.Location = new System.Drawing.Point(105, 30);
            this.btnDDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDDF.Name = "btnDDF";
            this.btnDDF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDDF.Size = new System.Drawing.Size(40, 40);
            this.btnDDF.TabIndex = 15;
            this.btnDDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDDF.UseVisualStyleBackColor = true;
            this.btnDDF.Click += new System.EventHandler(this.BtnDDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDDFS);
            this.groupBox2.Controls.Add(this.cbLeftFilesSubfoldersDelete);
            this.groupBox2.Controls.Add(this.cbRightFilesSubfoldersDelete);
            this.groupBox2.Location = new System.Drawing.Point(168, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(166, 88);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duplicate Subfolders and Files";
            // 
            // btnDDFS
            // 
            this.btnDDFS.Image = ((System.Drawing.Image)(resources.GetObject("btnDDFS.Image")));
            this.btnDDFS.Location = new System.Drawing.Point(120, 30);
            this.btnDDFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDDFS.Name = "btnDDFS";
            this.btnDDFS.Size = new System.Drawing.Size(40, 40);
            this.btnDDFS.TabIndex = 16;
            this.btnDDFS.UseVisualStyleBackColor = true;
            this.btnDDFS.Click += new System.EventHandler(this.BtnDDFS_Click);
            // 
            // lvDifferent
            // 
            this.lvDifferent.HideSelection = false;
            this.lvDifferent.Location = new System.Drawing.Point(10, 129);
            this.lvDifferent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDifferent.Name = "lvDifferent";
            this.lvDifferent.Size = new System.Drawing.Size(377, 254);
            this.lvDifferent.TabIndex = 24;
            this.lvDifferent.UseCompatibleStateImageBehavior = false;
            this.lvDifferent.DoubleClick += new System.EventHandler(this.lvDifferent_DoubleClick);
            // 
            // lvDuplicate
            // 
            this.lvDuplicate.HideSelection = false;
            this.lvDuplicate.Location = new System.Drawing.Point(400, 129);
            this.lvDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDuplicate.Name = "lvDuplicate";
            this.lvDuplicate.Size = new System.Drawing.Size(377, 254);
            this.lvDuplicate.TabIndex = 25;
            this.lvDuplicate.UseCompatibleStateImageBehavior = false;
            this.lvDuplicate.DoubleClick += new System.EventHandler(this.lvDuplicate_DoubleClick);
            // 
            // lbDifferent
            // 
            this.lbDifferent.AutoSize = true;
            this.lbDifferent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbDifferent.Location = new System.Drawing.Point(10, 110);
            this.lbDifferent.Name = "lbDifferent";
            this.lbDifferent.Size = new System.Drawing.Size(62, 17);
            this.lbDifferent.TabIndex = 26;
            this.lbDifferent.Text = "Different";
            // 
            // lbDuplicate
            // 
            this.lbDuplicate.AutoSize = true;
            this.lbDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbDuplicate.Location = new System.Drawing.Point(400, 110);
            this.lbDuplicate.Name = "lbDuplicate";
            this.lbDuplicate.Size = new System.Drawing.Size(67, 17);
            this.lbDuplicate.TabIndex = 27;
            this.lbDuplicate.Text = "Duplicate";
            // 
            // panelDestinationFolder
            // 
            this.panelDestinationFolder.AllowDrop = true;
            this.panelDestinationFolder.Controls.Add(this.pbCopyDestinationFolderPath);
            this.panelDestinationFolder.Controls.Add(this.pbCopyDestinationFolderName);
            this.panelDestinationFolder.Controls.Add(this.txtDestinationFolderName);
            this.panelDestinationFolder.Controls.Add(this.txtDestinationFolderPath);
            this.panelDestinationFolder.Controls.Add(this.lbNoOfDestinationFolders);
            this.panelDestinationFolder.Controls.Add(this.lbDestinationFolderName);
            this.panelDestinationFolder.Controls.Add(this.lbNoOfDestinationFiles);
            this.panelDestinationFolder.Controls.Add(this.lbDestinationFolderPath);
            this.panelDestinationFolder.Controls.Add(this.btnBR);
            this.panelDestinationFolder.Controls.Add(this.lbRightSideFolderSize);
            this.panelDestinationFolder.Controls.Add(this.label12);
            this.panelDestinationFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDestinationFolder.Location = new System.Drawing.Point(432, 25);
            this.panelDestinationFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDestinationFolder.Name = "panelDestinationFolder";
            this.panelDestinationFolder.Size = new System.Drawing.Size(345, 81);
            this.panelDestinationFolder.TabIndex = 4;
            this.panelDestinationFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDestinationFolder_DragDrop);
            this.panelDestinationFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDestinationFolder_DragEnter);
            // 
            // pbCopyDestinationFolderPath
            // 
            this.pbCopyDestinationFolderPath.Image = ((System.Drawing.Image)(resources.GetObject("pbCopyDestinationFolderPath.Image")));
            this.pbCopyDestinationFolderPath.Location = new System.Drawing.Point(264, 34);
            this.pbCopyDestinationFolderPath.Name = "pbCopyDestinationFolderPath";
            this.pbCopyDestinationFolderPath.Size = new System.Drawing.Size(15, 15);
            this.pbCopyDestinationFolderPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopyDestinationFolderPath.TabIndex = 58;
            this.pbCopyDestinationFolderPath.TabStop = false;
            this.pbCopyDestinationFolderPath.Click += new System.EventHandler(this.PbCopyDestinationFolderPath_Click);
            // 
            // pbCopyDestinationFolderName
            // 
            this.pbCopyDestinationFolderName.Image = ((System.Drawing.Image)(resources.GetObject("pbCopyDestinationFolderName.Image")));
            this.pbCopyDestinationFolderName.Location = new System.Drawing.Point(264, 6);
            this.pbCopyDestinationFolderName.Name = "pbCopyDestinationFolderName";
            this.pbCopyDestinationFolderName.Size = new System.Drawing.Size(15, 15);
            this.pbCopyDestinationFolderName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopyDestinationFolderName.TabIndex = 57;
            this.pbCopyDestinationFolderName.TabStop = false;
            this.pbCopyDestinationFolderName.Click += new System.EventHandler(this.PbCopyDestinationFolderName_Click);
            // 
            // txtDestinationFolderName
            // 
            this.txtDestinationFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolderName.Location = new System.Drawing.Point(47, 3);
            this.txtDestinationFolderName.Multiline = true;
            this.txtDestinationFolderName.Name = "txtDestinationFolderName";
            this.txtDestinationFolderName.ReadOnly = true;
            this.txtDestinationFolderName.Size = new System.Drawing.Size(211, 20);
            this.txtDestinationFolderName.TabIndex = 48;
            // 
            // txtDestinationFolderPath
            // 
            this.txtDestinationFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolderPath.Location = new System.Drawing.Point(47, 31);
            this.txtDestinationFolderPath.Multiline = true;
            this.txtDestinationFolderPath.Name = "txtDestinationFolderPath";
            this.txtDestinationFolderPath.ReadOnly = true;
            this.txtDestinationFolderPath.Size = new System.Drawing.Size(211, 20);
            this.txtDestinationFolderPath.TabIndex = 47;
            // 
            // lbNoOfDestinationFolders
            // 
            this.lbNoOfDestinationFolders.AutoSize = true;
            this.lbNoOfDestinationFolders.Location = new System.Drawing.Point(248, 63);
            this.lbNoOfDestinationFolders.Name = "lbNoOfDestinationFolders";
            this.lbNoOfDestinationFolders.Size = new System.Drawing.Size(93, 17);
            this.lbNoOfDestinationFolders.TabIndex = 42;
            this.lbNoOfDestinationFolders.Text = "No of Folders";
            // 
            // lbDestinationFolderName
            // 
            this.lbDestinationFolderName.AutoSize = true;
            this.lbDestinationFolderName.Location = new System.Drawing.Point(3, 7);
            this.lbDestinationFolderName.Name = "lbDestinationFolderName";
            this.lbDestinationFolderName.Size = new System.Drawing.Size(49, 17);
            this.lbDestinationFolderName.TabIndex = 9;
            this.lbDestinationFolderName.Text = "Name:";
            // 
            // lbNoOfDestinationFiles
            // 
            this.lbNoOfDestinationFiles.AutoSize = true;
            this.lbNoOfDestinationFiles.Location = new System.Drawing.Point(159, 63);
            this.lbNoOfDestinationFiles.Name = "lbNoOfDestinationFiles";
            this.lbNoOfDestinationFiles.Size = new System.Drawing.Size(75, 17);
            this.lbNoOfDestinationFiles.TabIndex = 46;
            this.lbNoOfDestinationFiles.Text = "No of Files";
            // 
            // lbDestinationFolderPath
            // 
            this.lbDestinationFolderPath.AutoSize = true;
            this.lbDestinationFolderPath.Location = new System.Drawing.Point(3, 35);
            this.lbDestinationFolderPath.Name = "lbDestinationFolderPath";
            this.lbDestinationFolderPath.Size = new System.Drawing.Size(41, 17);
            this.lbDestinationFolderPath.TabIndex = 10;
            this.lbDestinationFolderPath.Text = "Path:";
            // 
            // btnBR
            // 
            this.btnBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBR.Image = ((System.Drawing.Image)(resources.GetObject("btnBR.Image")));
            this.btnBR.Location = new System.Drawing.Point(301, 2);
            this.btnBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(40, 39);
            this.btnBR.TabIndex = 4;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.BtnBR_Click);
            this.btnBR.MouseHover += new System.EventHandler(this.BtnBrowseRight_MouseHover);
            // 
            // lbRightSideFolderSize
            // 
            this.lbRightSideFolderSize.AutoSize = true;
            this.lbRightSideFolderSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbRightSideFolderSize.Location = new System.Drawing.Point(47, 63);
            this.lbRightSideFolderSize.Name = "lbRightSideFolderSize";
            this.lbRightSideFolderSize.Size = new System.Drawing.Size(79, 17);
            this.lbRightSideFolderSize.TabIndex = 45;
            this.lbRightSideFolderSize.Text = "Folder Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Size: ";
            // 
            // panelSourceFolder
            // 
            this.panelSourceFolder.AllowDrop = true;
            this.panelSourceFolder.Controls.Add(this.pbCopySourceFolderPath);
            this.panelSourceFolder.Controls.Add(this.pbCopySourceFolderName);
            this.panelSourceFolder.Controls.Add(this.lbSourceFolderName);
            this.panelSourceFolder.Controls.Add(this.lbSourceFolderPath);
            this.panelSourceFolder.Controls.Add(this.label10);
            this.panelSourceFolder.Controls.Add(this.lbLeftSideFolderSize);
            this.panelSourceFolder.Controls.Add(this.txtSourceFolderName);
            this.panelSourceFolder.Controls.Add(this.txtSourceFolderPath);
            this.panelSourceFolder.Controls.Add(this.lbNoOfSourceFolders);
            this.panelSourceFolder.Controls.Add(this.lbNoOfSourceFiles);
            this.panelSourceFolder.Controls.Add(this.btnBL);
            this.panelSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSourceFolder.Location = new System.Drawing.Point(10, 25);
            this.panelSourceFolder.Margin = new System.Windows.Forms.Padding(4);
            this.panelSourceFolder.Name = "panelSourceFolder";
            this.panelSourceFolder.Size = new System.Drawing.Size(345, 81);
            this.panelSourceFolder.TabIndex = 52;
            this.panelSourceFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelSourceFolder_DragDrop);
            this.panelSourceFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelSourceFolder_DragEnter);
            // 
            // pbCopySourceFolderPath
            // 
            this.pbCopySourceFolderPath.Image = ((System.Drawing.Image)(resources.GetObject("pbCopySourceFolderPath.Image")));
            this.pbCopySourceFolderPath.Location = new System.Drawing.Point(263, 32);
            this.pbCopySourceFolderPath.Name = "pbCopySourceFolderPath";
            this.pbCopySourceFolderPath.Size = new System.Drawing.Size(15, 15);
            this.pbCopySourceFolderPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopySourceFolderPath.TabIndex = 57;
            this.pbCopySourceFolderPath.TabStop = false;
            this.pbCopySourceFolderPath.Click += new System.EventHandler(this.PbCopySourceFolderPath_Click);
            // 
            // pbCopySourceFolderName
            // 
            this.pbCopySourceFolderName.Image = ((System.Drawing.Image)(resources.GetObject("pbCopySourceFolderName.Image")));
            this.pbCopySourceFolderName.Location = new System.Drawing.Point(263, 6);
            this.pbCopySourceFolderName.Name = "pbCopySourceFolderName";
            this.pbCopySourceFolderName.Size = new System.Drawing.Size(15, 15);
            this.pbCopySourceFolderName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopySourceFolderName.TabIndex = 56;
            this.pbCopySourceFolderName.TabStop = false;
            this.pbCopySourceFolderName.Click += new System.EventHandler(this.PbCopySourceFolderName_Click);
            // 
            // lbSourceFolderName
            // 
            this.lbSourceFolderName.AutoSize = true;
            this.lbSourceFolderName.Location = new System.Drawing.Point(3, 7);
            this.lbSourceFolderName.Margin = new System.Windows.Forms.Padding(0);
            this.lbSourceFolderName.Name = "lbSourceFolderName";
            this.lbSourceFolderName.Size = new System.Drawing.Size(49, 17);
            this.lbSourceFolderName.TabIndex = 55;
            this.lbSourceFolderName.Text = "Name:";
            // 
            // lbSourceFolderPath
            // 
            this.lbSourceFolderPath.AutoSize = true;
            this.lbSourceFolderPath.Location = new System.Drawing.Point(3, 33);
            this.lbSourceFolderPath.Margin = new System.Windows.Forms.Padding(0);
            this.lbSourceFolderPath.Name = "lbSourceFolderPath";
            this.lbSourceFolderPath.Size = new System.Drawing.Size(41, 17);
            this.lbSourceFolderPath.TabIndex = 54;
            this.lbSourceFolderPath.Text = "Path:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Size:";
            // 
            // lbLeftSideFolderSize
            // 
            this.lbLeftSideFolderSize.AutoSize = true;
            this.lbLeftSideFolderSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbLeftSideFolderSize.Location = new System.Drawing.Point(45, 63);
            this.lbLeftSideFolderSize.Margin = new System.Windows.Forms.Padding(0);
            this.lbLeftSideFolderSize.Name = "lbLeftSideFolderSize";
            this.lbLeftSideFolderSize.Size = new System.Drawing.Size(79, 17);
            this.lbLeftSideFolderSize.TabIndex = 52;
            this.lbLeftSideFolderSize.Text = "Folder Size";
            // 
            // txtSourceFolderName
            // 
            this.txtSourceFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolderName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSourceFolderName.Location = new System.Drawing.Point(45, 3);
            this.txtSourceFolderName.Multiline = true;
            this.txtSourceFolderName.Name = "txtSourceFolderName";
            this.txtSourceFolderName.ReadOnly = true;
            this.txtSourceFolderName.Size = new System.Drawing.Size(211, 20);
            this.txtSourceFolderName.TabIndex = 47;
            // 
            // txtSourceFolderPath
            // 
            this.txtSourceFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolderPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSourceFolderPath.Location = new System.Drawing.Point(45, 29);
            this.txtSourceFolderPath.Multiline = true;
            this.txtSourceFolderPath.Name = "txtSourceFolderPath";
            this.txtSourceFolderPath.ReadOnly = true;
            this.txtSourceFolderPath.Size = new System.Drawing.Size(211, 20);
            this.txtSourceFolderPath.TabIndex = 46;
            // 
            // lbNoOfSourceFolders
            // 
            this.lbNoOfSourceFolders.AutoSize = true;
            this.lbNoOfSourceFolders.Location = new System.Drawing.Point(238, 63);
            this.lbNoOfSourceFolders.Margin = new System.Windows.Forms.Padding(0);
            this.lbNoOfSourceFolders.Name = "lbNoOfSourceFolders";
            this.lbNoOfSourceFolders.Size = new System.Drawing.Size(93, 17);
            this.lbNoOfSourceFolders.TabIndex = 45;
            this.lbNoOfSourceFolders.Text = "No of Folders";
            // 
            // lbNoOfSourceFiles
            // 
            this.lbNoOfSourceFiles.AutoSize = true;
            this.lbNoOfSourceFiles.Location = new System.Drawing.Point(157, 63);
            this.lbNoOfSourceFiles.Margin = new System.Windows.Forms.Padding(0);
            this.lbNoOfSourceFiles.Name = "lbNoOfSourceFiles";
            this.lbNoOfSourceFiles.Size = new System.Drawing.Size(75, 17);
            this.lbNoOfSourceFiles.TabIndex = 44;
            this.lbNoOfSourceFiles.Text = "No of Files";
            // 
            // btnBL
            // 
            this.btnBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBL.Image = ((System.Drawing.Image)(resources.GetObject("btnBL.Image")));
            this.btnBL.Location = new System.Drawing.Point(303, 2);
            this.btnBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(40, 39);
            this.btnBL.TabIndex = 1;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.BtnBL_Click);
            this.btnBL.MouseHover += new System.EventHandler(this.BtnBrowseLeft_MouseHover);
            // 
            // btnMoveRightToLeftFAF
            // 
            this.btnMoveRightToLeftFAF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveRightToLeftFAF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveRightToLeftFAF.Location = new System.Drawing.Point(634, 2);
            this.btnMoveRightToLeftFAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveRightToLeftFAF.Name = "btnMoveRightToLeftFAF";
            this.btnMoveRightToLeftFAF.Size = new System.Drawing.Size(124, 35);
            this.btnMoveRightToLeftFAF.TabIndex = 50;
            this.btnMoveRightToLeftFAF.Text = "Move D to S";
            this.btnMoveRightToLeftFAF.UseVisualStyleBackColor = true;
            this.btnMoveRightToLeftFAF.Click += new System.EventHandler(this.BtnMoveRightToLeftFAF_Click);
            this.btnMoveRightToLeftFAF.MouseHover += new System.EventHandler(this.BtnMoveRightToLeftFAF_MouseHover);
            // 
            // btnCopyDuplicate
            // 
            this.btnCopyDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyDuplicate.Image")));
            this.btnCopyDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyDuplicate.Location = new System.Drawing.Point(160, 77);
            this.btnCopyDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyDuplicate.Name = "btnCopyDuplicate";
            this.btnCopyDuplicate.Padding = new System.Windows.Forms.Padding(5);
            this.btnCopyDuplicate.Size = new System.Drawing.Size(154, 40);
            this.btnCopyDuplicate.TabIndex = 46;
            this.btnCopyDuplicate.Text = "Copy Duplicate";
            this.btnCopyDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyDuplicate.UseVisualStyleBackColor = true;
            this.btnCopyDuplicate.Click += new System.EventHandler(this.BtnCopyDuplicate_Click);
            // 
            // btnCopyRightToLeftFAF
            // 
            this.btnCopyRightToLeftFAF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCopyRightToLeftFAF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyRightToLeftFAF.Location = new System.Drawing.Point(501, 2);
            this.btnCopyRightToLeftFAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyRightToLeftFAF.Name = "btnCopyRightToLeftFAF";
            this.btnCopyRightToLeftFAF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyRightToLeftFAF.Size = new System.Drawing.Size(124, 35);
            this.btnCopyRightToLeftFAF.TabIndex = 30;
            this.btnCopyRightToLeftFAF.Text = "Copy D to S";
            this.btnCopyRightToLeftFAF.UseVisualStyleBackColor = true;
            this.btnCopyRightToLeftFAF.Click += new System.EventHandler(this.BtnCopyRightToLeftFAF_Click);
            this.btnCopyRightToLeftFAF.MouseHover += new System.EventHandler(this.BtnCopyRightToLeftFAF_MouseHover);
            // 
            // btnMoveLeftToRightFAF
            // 
            this.btnMoveLeftToRightFAF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMoveLeftToRightFAF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoveLeftToRightFAF.Location = new System.Drawing.Point(136, 2);
            this.btnMoveLeftToRightFAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveLeftToRightFAF.Name = "btnMoveLeftToRightFAF";
            this.btnMoveLeftToRightFAF.Size = new System.Drawing.Size(124, 35);
            this.btnMoveLeftToRightFAF.TabIndex = 30;
            this.btnMoveLeftToRightFAF.Text = "Move S to D";
            this.btnMoveLeftToRightFAF.UseVisualStyleBackColor = true;
            this.btnMoveLeftToRightFAF.Click += new System.EventHandler(this.BtnMoveLeftToRightFAF_Click);
            this.btnMoveLeftToRightFAF.MouseHover += new System.EventHandler(this.BtnMoveLeftToRightFAF_MouseHover);
            // 
            // btnCopyLeftToRightFAF
            // 
            this.btnCopyLeftToRightFAF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCopyLeftToRightFAF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyLeftToRightFAF.Location = new System.Drawing.Point(6, 2);
            this.btnCopyLeftToRightFAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyLeftToRightFAF.Name = "btnCopyLeftToRightFAF";
            this.btnCopyLeftToRightFAF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyLeftToRightFAF.Size = new System.Drawing.Size(124, 35);
            this.btnCopyLeftToRightFAF.TabIndex = 30;
            this.btnCopyLeftToRightFAF.Text = "Copy S to D";
            this.btnCopyLeftToRightFAF.UseVisualStyleBackColor = true;
            this.btnCopyLeftToRightFAF.Click += new System.EventHandler(this.BtnCopyLeftToRightFAF_Click);
            this.btnCopyLeftToRightFAF.MouseHover += new System.EventHandler(this.BtnCopyLeftToRightFAF_MouseHover);
            // 
            // btnMoveDuplicate
            // 
            this.btnMoveDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoveDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDuplicate.Image")));
            this.btnMoveDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveDuplicate.Location = new System.Drawing.Point(0, 77);
            this.btnMoveDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveDuplicate.Name = "btnMoveDuplicate";
            this.btnMoveDuplicate.Padding = new System.Windows.Forms.Padding(5);
            this.btnMoveDuplicate.Size = new System.Drawing.Size(154, 40);
            this.btnMoveDuplicate.TabIndex = 47;
            this.btnMoveDuplicate.Text = "Move Duplicate";
            this.btnMoveDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoveDuplicate.UseVisualStyleBackColor = true;
            this.btnMoveDuplicate.Click += new System.EventHandler(this.BtnMoveDuplicate_Click);
            // 
            // btnSM_FAF
            // 
            this.btnSM_FAF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSM_FAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM_FAF.Image = ((System.Drawing.Image)(resources.GetObject("btnSM_FAF.Image")));
            this.btnSM_FAF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSM_FAF.Location = new System.Drawing.Point(266, 33);
            this.btnSM_FAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSM_FAF.Name = "btnSM_FAF";
            this.btnSM_FAF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSM_FAF.Size = new System.Drawing.Size(150, 40);
            this.btnSM_FAF.TabIndex = 14;
            this.btnSM_FAF.Text = "Sync and Move";
            this.btnSM_FAF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSM_FAF.UseVisualStyleBackColor = true;
            this.btnSM_FAF.Click += new System.EventHandler(this.BtnSM_Click);
            // 
            // btnSC_FAF
            // 
            this.btnSC_FAF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSC_FAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC_FAF.Image = ((System.Drawing.Image)(resources.GetObject("btnSC_FAF.Image")));
            this.btnSC_FAF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSC_FAF.Location = new System.Drawing.Point(108, 33);
            this.btnSC_FAF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSC_FAF.Name = "btnSC_FAF";
            this.btnSC_FAF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSC_FAF.Size = new System.Drawing.Size(150, 40);
            this.btnSC_FAF.TabIndex = 13;
            this.btnSC_FAF.Text = "Sync and Copy";
            this.btnSC_FAF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSC_FAF.UseVisualStyleBackColor = true;
            this.btnSC_FAF.Click += new System.EventHandler(this.BtnSC_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyse.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalyse.Image")));
            this.btnAnalyse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyse.Location = new System.Drawing.Point(0, 33);
            this.btnAnalyse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Padding = new System.Windows.Forms.Padding(5);
            this.btnAnalyse.Size = new System.Drawing.Size(102, 40);
            this.btnAnalyse.TabIndex = 28;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.BtnAnalyse_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(0, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnClear.Size = new System.Drawing.Size(70, 36);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.Visible = true;
            // 
            // panelBottom1
            // 
            this.panelBottom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBottom1.Controls.Add(this.lbProcessing);
            this.panelBottom1.Controls.Add(this.pbProgressBar);
            this.panelBottom1.Controls.Add(this.btnCancel);
            this.panelBottom1.Controls.Add(this.btnAnalyse);
            this.panelBottom1.Controls.Add(this.btnSC_FAF);
            this.panelBottom1.Controls.Add(this.btnSM_FAF);
            this.panelBottom1.Controls.Add(this.btnMoveDuplicate);
            this.panelBottom1.Controls.Add(this.btnCopyDuplicate);
            this.panelBottom1.Location = new System.Drawing.Point(10, 428);
            this.panelBottom1.Name = "panelBottom1";
            this.panelBottom1.Size = new System.Drawing.Size(421, 122);
            this.panelBottom1.TabIndex = 54;
            // 
            // lbProcessing
            // 
            this.lbProcessing.AutoSize = true;
            this.lbProcessing.Location = new System.Drawing.Point(38, 6);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(173, 17);
            this.lbProcessing.TabIndex = 56;
            this.lbProcessing.Text = "Processing Please Wait....";
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Image = ((System.Drawing.Image)(resources.GetObject("pbProgressBar.Image")));
            this.pbProgressBar.Location = new System.Drawing.Point(3, 0);
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(28, 28);
            this.pbProgressBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgressBar.TabIndex = 55;
            this.pbProgressBar.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(320, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(96, 40);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAnalyseSettings
            // 
            this.btnAnalyseSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalyseSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalyseSettings.Image")));
            this.btnAnalyseSettings.Location = new System.Drawing.Point(15, 40);
            this.btnAnalyseSettings.Name = "btnAnalyseSettings";
            this.btnAnalyseSettings.Size = new System.Drawing.Size(40, 40);
            this.btnAnalyseSettings.TabIndex = 49;
            this.btnAnalyseSettings.UseVisualStyleBackColor = true;
            this.btnAnalyseSettings.Click += new System.EventHandler(this.BtnAnalyseSettings_Click);
            // 
            // panelBottom2
            // 
            this.panelBottom2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom2.Controls.Add(this.groupBox1);
            this.panelBottom2.Controls.Add(this.groupBox2);
            this.panelBottom2.Location = new System.Drawing.Point(436, 428);
            this.panelBottom2.Name = "panelBottom2";
            this.panelBottom2.Size = new System.Drawing.Size(339, 122);
            this.panelBottom2.TabIndex = 55;
            // 
            // panelMiddel1
            // 
            this.panelMiddel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMiddel1.Controls.Add(this.btnClear);
            this.panelMiddel1.Controls.Add(this.btnAnalyseSettings);
            this.panelMiddel1.Location = new System.Drawing.Point(358, 25);
            this.panelMiddel1.Name = "panelMiddel1";
            this.panelMiddel1.Size = new System.Drawing.Size(70, 81);
            this.panelMiddel1.TabIndex = 56;
            // 
            // panelSD
            // 
            this.panelSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSD.Controls.Add(this.btnGotoTOPDuplicate);
            this.panelSD.Controls.Add(this.btnGotoBOTTOMDuplicate);
            this.panelSD.Controls.Add(this.btnGotoBOTTOMDifferent);
            this.panelSD.Controls.Add(this.btnGotoTOPDifferent);
            this.panelSD.Controls.Add(this.btnMoveLeftToRightFAF);
            this.panelSD.Controls.Add(this.btnMoveRightToLeftFAF);
            this.panelSD.Controls.Add(this.btnCopyRightToLeftFAF);
            this.panelSD.Controls.Add(this.btnCopyLeftToRightFAF);
            this.panelSD.Location = new System.Drawing.Point(10, 385);
            this.panelSD.Name = "panelSD";
            this.panelSD.Size = new System.Drawing.Size(765, 40);
            this.panelSD.TabIndex = 57;
            // 
            // btnGotoTOPDuplicate
            // 
            this.btnGotoTOPDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoTOPDuplicate.Image")));
            this.btnGotoTOPDuplicate.Location = new System.Drawing.Point(390, 2);
            this.btnGotoTOPDuplicate.Name = "btnGotoTOPDuplicate";
            this.btnGotoTOPDuplicate.Size = new System.Drawing.Size(35, 35);
            this.btnGotoTOPDuplicate.TabIndex = 54;
            this.btnGotoTOPDuplicate.UseVisualStyleBackColor = true;
            this.btnGotoTOPDuplicate.Click += new System.EventHandler(this.btnGotoTOPDuplicate_Click);
            // 
            // btnGotoBOTTOMDuplicate
            // 
            this.btnGotoBOTTOMDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoBOTTOMDuplicate.Image")));
            this.btnGotoBOTTOMDuplicate.Location = new System.Drawing.Point(439, 2);
            this.btnGotoBOTTOMDuplicate.Name = "btnGotoBOTTOMDuplicate";
            this.btnGotoBOTTOMDuplicate.Size = new System.Drawing.Size(35, 35);
            this.btnGotoBOTTOMDuplicate.TabIndex = 53;
            this.btnGotoBOTTOMDuplicate.UseVisualStyleBackColor = true;
            this.btnGotoBOTTOMDuplicate.Click += new System.EventHandler(this.btnGotoBOTTOMDuplicate_Click);
            // 
            // btnGotoBOTTOMDifferent
            // 
            this.btnGotoBOTTOMDifferent.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoBOTTOMDifferent.Image")));
            this.btnGotoBOTTOMDifferent.Location = new System.Drawing.Point(342, 2);
            this.btnGotoBOTTOMDifferent.Name = "btnGotoBOTTOMDifferent";
            this.btnGotoBOTTOMDifferent.Size = new System.Drawing.Size(35, 35);
            this.btnGotoBOTTOMDifferent.TabIndex = 52;
            this.btnGotoBOTTOMDifferent.UseVisualStyleBackColor = true;
            this.btnGotoBOTTOMDifferent.Click += new System.EventHandler(this.btnGotoBOTTOMDifferent_Click);
            // 
            // btnGotoTOPDifferent
            // 
            this.btnGotoTOPDifferent.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoTOPDifferent.Image")));
            this.btnGotoTOPDifferent.Location = new System.Drawing.Point(296, 2);
            this.btnGotoTOPDifferent.Name = "btnGotoTOPDifferent";
            this.btnGotoTOPDifferent.Size = new System.Drawing.Size(35, 35);
            this.btnGotoTOPDifferent.TabIndex = 51;
            this.btnGotoTOPDifferent.UseVisualStyleBackColor = true;
            this.btnGotoTOPDifferent.Click += new System.EventHandler(this.btnGotoTOPDifferent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Destination";
            // 
            // lbDifferentTotalCountTXT
            // 
            this.lbDifferentTotalCountTXT.AutoSize = true;
            this.lbDifferentTotalCountTXT.Location = new System.Drawing.Point(167, 110);
            this.lbDifferentTotalCountTXT.Name = "lbDifferentTotalCountTXT";
            this.lbDifferentTotalCountTXT.Size = new System.Drawing.Size(44, 17);
            this.lbDifferentTotalCountTXT.TabIndex = 60;
            this.lbDifferentTotalCountTXT.Text = "Total:";
            // 
            // lbDifferentTotalCount
            // 
            this.lbDifferentTotalCount.AutoSize = true;
            this.lbDifferentTotalCount.Location = new System.Drawing.Point(205, 110);
            this.lbDifferentTotalCount.Name = "lbDifferentTotalCount";
            this.lbDifferentTotalCount.Size = new System.Drawing.Size(46, 17);
            this.lbDifferentTotalCount.TabIndex = 61;
            this.lbDifferentTotalCount.Text = "label4";
            // 
            // lbDuplicateTotalCount
            // 
            this.lbDuplicateTotalCount.AutoSize = true;
            this.lbDuplicateTotalCount.Location = new System.Drawing.Point(630, 110);
            this.lbDuplicateTotalCount.Name = "lbDuplicateTotalCount";
            this.lbDuplicateTotalCount.Size = new System.Drawing.Size(46, 17);
            this.lbDuplicateTotalCount.TabIndex = 63;
            this.lbDuplicateTotalCount.Text = "label5";
            // 
            // lbDuplicateTotalCountTXT
            // 
            this.lbDuplicateTotalCountTXT.AutoSize = true;
            this.lbDuplicateTotalCountTXT.Location = new System.Drawing.Point(591, 110);
            this.lbDuplicateTotalCountTXT.Name = "lbDuplicateTotalCountTXT";
            this.lbDuplicateTotalCountTXT.Size = new System.Drawing.Size(44, 17);
            this.lbDuplicateTotalCountTXT.TabIndex = 62;
            this.lbDuplicateTotalCountTXT.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lbDuplicateTotalCount);
            this.Controls.Add(this.lbDuplicateTotalCountTXT);
            this.Controls.Add(this.lbDifferentTotalCount);
            this.Controls.Add(this.lbDifferentTotalCountTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSD);
            this.Controls.Add(this.panelMiddel1);
            this.Controls.Add(this.lbDifferent);
            this.Controls.Add(this.lbDuplicate);
            this.Controls.Add(this.panelBottom2);
            this.Controls.Add(this.panelBottom1);
            this.Controls.Add(this.lvDuplicate);
            this.Controls.Add(this.lvDifferent);
            this.Controls.Add(this.panelSourceFolder);
            this.Controls.Add(this.panelDestinationFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files And Folders Synchronize by Mr.Dhavanik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelDestinationFolder.ResumeLayout(false);
            this.panelDestinationFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyDestinationFolderPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyDestinationFolderName)).EndInit();
            this.panelSourceFolder.ResumeLayout(false);
            this.panelSourceFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopySourceFolderPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopySourceFolderName)).EndInit();
            this.panelBottom1.ResumeLayout(false);
            this.panelBottom1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgressBar)).EndInit();
            this.panelBottom2.ResumeLayout(false);
            this.panelMiddel1.ResumeLayout(false);
            this.panelSD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSC_FAF;
        private System.Windows.Forms.Button btnSM_FAF;
        private System.Windows.Forms.Button btnDDF;
        private System.Windows.Forms.Button btnDDFS;
        private System.Windows.Forms.CheckBox cbLeftFileDelete;
        private System.Windows.Forms.CheckBox cbRightFileDelete;
        private System.Windows.Forms.CheckBox cbLeftFilesSubfoldersDelete;
        private System.Windows.Forms.CheckBox cbRightFilesSubfoldersDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDifferent;
        private System.Windows.Forms.ListView lvDuplicate;
        private System.Windows.Forms.Label lbDifferent;
        private System.Windows.Forms.Label lbDuplicate;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnCopyLeftToRightFAF;
        private System.Windows.Forms.Button btnCopyRightToLeftFAF;
        private System.Windows.Forms.Button btnMoveRightToLeftFAF;
        private System.Windows.Forms.Button btnMoveLeftToRightFAF;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnCopyDuplicate;
        private System.Windows.Forms.Button btnMoveDuplicate;
        private System.Windows.Forms.Label lbDestinationFolderName;
        private System.Windows.Forms.Label lbDestinationFolderPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRightSideFolderSize;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Panel panelDestinationFolder;
        private System.Windows.Forms.Panel panelSourceFolder;
        private System.Windows.Forms.Label lbNoOfSourceFolders;
        private System.Windows.Forms.Label lbNoOfSourceFiles;
        private System.Windows.Forms.Label lbNoOfDestinationFolders;
        private System.Windows.Forms.Label lbNoOfDestinationFiles;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TextBox txtSourceFolderName;
        private System.Windows.Forms.TextBox txtDestinationFolderName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLeftSideFolderSize;
        private System.Windows.Forms.Label lbSourceFolderName;
        private System.Windows.Forms.Label lbSourceFolderPath;
        private System.Windows.Forms.Panel panelBottom1;
        private System.Windows.Forms.Panel panelBottom2;
        private System.Windows.Forms.Panel panelMiddel1;
        private System.Windows.Forms.PictureBox pbCopySourceFolderName;
        private System.Windows.Forms.PictureBox pbCopySourceFolderPath;
        private System.Windows.Forms.PictureBox pbCopyDestinationFolderPath;
        private System.Windows.Forms.PictureBox pbCopyDestinationFolderName;
        private System.Windows.Forms.Button btnAnalyseSettings;
        public System.Windows.Forms.TextBox txtSourceFolderPath;
        public System.Windows.Forms.TextBox txtDestinationFolderPath;
        private System.Windows.Forms.Panel panelSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbProgressBar;
        private System.Windows.Forms.Label lbProcessing;
        private System.Windows.Forms.Label lbDifferentTotalCountTXT;
        private System.Windows.Forms.Label lbDifferentTotalCount;
        private System.Windows.Forms.Label lbDuplicateTotalCount;
        private System.Windows.Forms.Label lbDuplicateTotalCountTXT;
        private System.Windows.Forms.Button btnGotoTOPDifferent;
        private System.Windows.Forms.Button btnGotoTOPDuplicate;
        private System.Windows.Forms.Button btnGotoBOTTOMDuplicate;
        private System.Windows.Forms.Button btnGotoBOTTOMDifferent;
    }
}

