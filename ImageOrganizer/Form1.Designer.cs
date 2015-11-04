namespace ImageOrganizer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripRenameFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripRenameImage = new System.Windows.Forms.ToolStripMenuItem();
            this.createAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMuliSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMultiSelectOn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMultiSelectOff = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurrentFolder = new System.Windows.Forms.TextBox();
            this.txtFolderDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolderDestination = new System.Windows.Forms.Label();
            this.btnMoveOrCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(0, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 298);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(145, 65);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 298);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(580, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 451);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.menuStripAction,
            this.menuStripMuliSelect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openFolderToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // menuStripAction
            // 
            this.menuStripAction.BackColor = System.Drawing.Color.Black;
            this.menuStripAction.CheckOnClick = true;
            this.menuStripAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripCopy,
            this.menuStripMove,
            this.menuStripDelete,
            this.MenuStripRenameFolder,
            this.menuStripRenameImage,
            this.createAlbumToolStripMenuItem,
            this.addToAlbumToolStripMenuItem});
            this.menuStripAction.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripAction.ForeColor = System.Drawing.Color.White;
            this.menuStripAction.Name = "menuStripAction";
            this.menuStripAction.Size = new System.Drawing.Size(59, 20);
            this.menuStripAction.Text = "Action";
            this.menuStripAction.Click += new System.EventHandler(this.menuStripAction_Click);
            // 
            // menuStripCopy
            // 
            this.menuStripCopy.BackColor = System.Drawing.Color.Black;
            this.menuStripCopy.Enabled = false;
            this.menuStripCopy.ForeColor = System.Drawing.Color.White;
            this.menuStripCopy.Name = "menuStripCopy";
            this.menuStripCopy.Size = new System.Drawing.Size(222, 22);
            this.menuStripCopy.Text = "Copy Selected";
            this.menuStripCopy.Click += new System.EventHandler(this.menuStripCopy_Click);
            // 
            // menuStripMove
            // 
            this.menuStripMove.BackColor = System.Drawing.Color.Black;
            this.menuStripMove.Enabled = false;
            this.menuStripMove.ForeColor = System.Drawing.Color.White;
            this.menuStripMove.Name = "menuStripMove";
            this.menuStripMove.Size = new System.Drawing.Size(222, 22);
            this.menuStripMove.Text = "Move Selected";
            this.menuStripMove.Click += new System.EventHandler(this.menuStripMove_Click);
            // 
            // menuStripDelete
            // 
            this.menuStripDelete.BackColor = System.Drawing.Color.Black;
            this.menuStripDelete.Enabled = false;
            this.menuStripDelete.ForeColor = System.Drawing.Color.White;
            this.menuStripDelete.Name = "menuStripDelete";
            this.menuStripDelete.Size = new System.Drawing.Size(222, 22);
            this.menuStripDelete.Text = "Delete Selected";
            this.menuStripDelete.Click += new System.EventHandler(this.menuStripDelete_Click);
            // 
            // MenuStripRenameFolder
            // 
            this.MenuStripRenameFolder.BackColor = System.Drawing.Color.Black;
            this.MenuStripRenameFolder.ForeColor = System.Drawing.Color.White;
            this.MenuStripRenameFolder.Name = "MenuStripRenameFolder";
            this.MenuStripRenameFolder.Size = new System.Drawing.Size(222, 22);
            this.MenuStripRenameFolder.Text = "Rename Selected Folder";
            this.MenuStripRenameFolder.Click += new System.EventHandler(this.renameFolderToolStripMenuItem_Click);
            // 
            // menuStripRenameImage
            // 
            this.menuStripRenameImage.BackColor = System.Drawing.Color.Black;
            this.menuStripRenameImage.ForeColor = System.Drawing.Color.White;
            this.menuStripRenameImage.Name = "menuStripRenameImage";
            this.menuStripRenameImage.Size = new System.Drawing.Size(222, 22);
            this.menuStripRenameImage.Text = "Rename Selected Image";
            this.menuStripRenameImage.Click += new System.EventHandler(this.menuStripRenameImage_Click);
            // 
            // createAlbumToolStripMenuItem
            // 
            this.createAlbumToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.createAlbumToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createAlbumToolStripMenuItem.Name = "createAlbumToolStripMenuItem";
            this.createAlbumToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createAlbumToolStripMenuItem.Text = "Create Album";
            this.createAlbumToolStripMenuItem.Click += new System.EventHandler(this.createAlbumToolStripMenuItem_Click);
            // 
            // addToAlbumToolStripMenuItem
            // 
            this.addToAlbumToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.addToAlbumToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToAlbumToolStripMenuItem.Name = "addToAlbumToolStripMenuItem";
            this.addToAlbumToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addToAlbumToolStripMenuItem.Text = "Add To Album";
            this.addToAlbumToolStripMenuItem.Click += new System.EventHandler(this.addToAlbumToolStripMenuItem_Click);
            // 
            // menuStripMuliSelect
            // 
            this.menuStripMuliSelect.BackColor = System.Drawing.Color.Black;
            this.menuStripMuliSelect.Checked = true;
            this.menuStripMuliSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStripMuliSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripMultiSelectOn,
            this.menuStripMultiSelectOff});
            this.menuStripMuliSelect.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMuliSelect.ForeColor = System.Drawing.Color.White;
            this.menuStripMuliSelect.Name = "menuStripMuliSelect";
            this.menuStripMuliSelect.Size = new System.Drawing.Size(92, 20);
            this.menuStripMuliSelect.Text = "Multi-Select";
            // 
            // menuStripMultiSelectOn
            // 
            this.menuStripMultiSelectOn.BackColor = System.Drawing.Color.Black;
            this.menuStripMultiSelectOn.CheckOnClick = true;
            this.menuStripMultiSelectOn.ForeColor = System.Drawing.Color.White;
            this.menuStripMultiSelectOn.Name = "menuStripMultiSelectOn";
            this.menuStripMultiSelectOn.Size = new System.Drawing.Size(95, 22);
            this.menuStripMultiSelectOn.Text = "On";
            this.menuStripMultiSelectOn.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // menuStripMultiSelectOff
            // 
            this.menuStripMultiSelectOff.BackColor = System.Drawing.Color.Black;
            this.menuStripMultiSelectOff.Checked = true;
            this.menuStripMultiSelectOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStripMultiSelectOff.ForeColor = System.Drawing.Color.White;
            this.menuStripMultiSelectOff.Name = "menuStripMultiSelectOff";
            this.menuStripMultiSelectOff.Size = new System.Drawing.Size(95, 22);
            this.menuStripMultiSelectOff.Text = "Off";
            this.menuStripMultiSelectOff.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // txtCurrentFolder
            // 
            this.txtCurrentFolder.BackColor = System.Drawing.Color.Black;
            this.txtCurrentFolder.Enabled = false;
            this.txtCurrentFolder.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentFolder.ForeColor = System.Drawing.Color.White;
            this.txtCurrentFolder.Location = new System.Drawing.Point(0, 387);
            this.txtCurrentFolder.Name = "txtCurrentFolder";
            this.txtCurrentFolder.Size = new System.Drawing.Size(139, 22);
            this.txtCurrentFolder.TabIndex = 8;
            // 
            // txtFolderDestination
            // 
            this.txtFolderDestination.BackColor = System.Drawing.Color.Black;
            this.txtFolderDestination.Enabled = false;
            this.txtFolderDestination.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderDestination.ForeColor = System.Drawing.Color.White;
            this.txtFolderDestination.Location = new System.Drawing.Point(0, 427);
            this.txtFolderDestination.Name = "txtFolderDestination";
            this.txtFolderDestination.Size = new System.Drawing.Size(265, 21);
            this.txtFolderDestination.TabIndex = 9;
            this.txtFolderDestination.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Folder:";
            // 
            // lblFolderDestination
            // 
            this.lblFolderDestination.AutoSize = true;
            this.lblFolderDestination.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderDestination.Location = new System.Drawing.Point(12, 411);
            this.lblFolderDestination.Name = "lblFolderDestination";
            this.lblFolderDestination.Size = new System.Drawing.Size(127, 15);
            this.lblFolderDestination.TabIndex = 11;
            this.lblFolderDestination.Text = "Folder Destination:";
            this.lblFolderDestination.Visible = false;
            // 
            // btnMoveOrCopy
            // 
            this.btnMoveOrCopy.BackColor = System.Drawing.Color.Black;
            this.btnMoveOrCopy.Enabled = false;
            this.btnMoveOrCopy.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOrCopy.ForeColor = System.Drawing.Color.White;
            this.btnMoveOrCopy.Location = new System.Drawing.Point(145, 385);
            this.btnMoveOrCopy.Name = "btnMoveOrCopy";
            this.btnMoveOrCopy.Size = new System.Drawing.Size(75, 23);
            this.btnMoveOrCopy.TabIndex = 12;
            this.btnMoveOrCopy.Text = "button1";
            this.btnMoveOrCopy.UseVisualStyleBackColor = false;
            this.btnMoveOrCopy.Visible = false;
            this.btnMoveOrCopy.Click += new System.EventHandler(this.btnMoveOrCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Folders:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Images:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(226, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.Black;
            this.btnPath.ForeColor = System.Drawing.Color.White;
            this.btnPath.Location = new System.Drawing.Point(271, 424);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(30, 23);
            this.btnPath.TabIndex = 16;
            this.btnPath.Text = ". . .";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Visible = false;
            this.btnPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRename
            // 
            this.txtRename.BackColor = System.Drawing.Color.Black;
            this.txtRename.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRename.ForeColor = System.Drawing.Color.White;
            this.txtRename.Location = new System.Drawing.Point(0, 426);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(139, 21);
            this.txtRename.TabIndex = 17;
            this.txtRename.Visible = false;
            this.txtRename.TextChanged += new System.EventHandler(this.txtRename_TextChanged);
            this.txtRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRename_KeyPress);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.Black;
            this.btnRename.Enabled = false;
            this.btnRename.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.Color.White;
            this.btnRename.Location = new System.Drawing.Point(145, 387);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 18;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Visible = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.BackColor = System.Drawing.Color.Black;
            this.btnAddAlbum.Enabled = false;
            this.btnAddAlbum.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlbum.ForeColor = System.Drawing.Color.White;
            this.btnAddAlbum.Location = new System.Drawing.Point(145, 387);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlbum.TabIndex = 19;
            this.btnAddAlbum.Text = "Add";
            this.btnAddAlbum.UseVisualStyleBackColor = false;
            this.btnAddAlbum.Visible = false;
            this.btnAddAlbum.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Black;
            this.listBox3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Location = new System.Drawing.Point(290, 65);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(139, 298);
            this.listBox3.TabIndex = 20;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Albums:";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Black;
            this.listBox4.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.ForeColor = System.Drawing.Color.White;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 14;
            this.listBox4.Location = new System.Drawing.Point(435, 65);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(139, 298);
            this.listBox4.TabIndex = 22;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Image of Albums:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1166, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtRename);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoveOrCopy);
            this.Controls.Add(this.lblFolderDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderDestination);
            this.Controls.Add(this.txtCurrentFolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripAction;
        private System.Windows.Forms.ToolStripMenuItem menuStripMuliSelect;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripCopy;
        private System.Windows.Forms.ToolStripMenuItem menuStripMove;
        private System.Windows.Forms.ToolStripMenuItem menuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem menuStripMultiSelectOn;
        private System.Windows.Forms.ToolStripMenuItem menuStripMultiSelectOff;
        private System.Windows.Forms.TextBox txtCurrentFolder;
        private System.Windows.Forms.TextBox txtFolderDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolderDestination;
        private System.Windows.Forms.Button btnMoveOrCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRenameFolder;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ToolStripMenuItem menuStripRenameImage;
        private System.Windows.Forms.ToolStripMenuItem createAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToAlbumToolStripMenuItem;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
    }
}

