﻿namespace ProjectClientSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtBox5 = new System.Windows.Forms.Label();
            this.boxFilepath = new System.Windows.Forms.TextBox();
            this.btnOpenfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boxServer = new System.Windows.Forms.TextBox();
            this.boxHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFilename = new System.Windows.Forms.Label();
            this.boxLog = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSharedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxRename = new System.Windows.Forms.TextBox();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userListBtn = new System.Windows.Forms.Button();
            this.refreshUserBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSelectedUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSelectedFile = new System.Windows.Forms.Label();
            this.shareBtn = new System.Windows.Forms.Button();
            this.unshareBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.Location = new System.Drawing.Point(15, 45);
            this.boxName.Margin = new System.Windows.Forms.Padding(2);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(400, 23);
            this.boxName.TabIndex = 2;
            this.boxName.Text = "Keriman";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(140, 143);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 19);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select File: ";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(336, 58);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(96, 19);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtBox5
            // 
            this.txtBox5.AutoSize = true;
            this.txtBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox5.Location = new System.Drawing.Point(20, 318);
            this.txtBox5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(59, 13);
            this.txtBox5.TabIndex = 9;
            this.txtBox5.Text = "Activities";
            // 
            // boxFilepath
            // 
            this.boxFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFilepath.Location = new System.Drawing.Point(16, 58);
            this.boxFilepath.Margin = new System.Windows.Forms.Padding(2);
            this.boxFilepath.Name = "boxFilepath";
            this.boxFilepath.Size = new System.Drawing.Size(283, 23);
            this.boxFilepath.TabIndex = 10;
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.Location = new System.Drawing.Point(336, 22);
            this.btnOpenfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(96, 21);
            this.btnOpenfile.TabIndex = 11;
            this.btnOpenfile.Text = "Open File";
            this.btnOpenfile.UseVisualStyleBackColor = true;
            this.btnOpenfile.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Server IP";
            // 
            // boxServer
            // 
            this.boxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxServer.Location = new System.Drawing.Point(15, 101);
            this.boxServer.Margin = new System.Windows.Forms.Padding(2);
            this.boxServer.Name = "boxServer";
            this.boxServer.Size = new System.Drawing.Size(284, 23);
            this.boxServer.TabIndex = 14;
            this.boxServer.Text = "192.168.1.30";
            // 
            // boxHost
            // 
            this.boxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHost.Location = new System.Drawing.Point(318, 101);
            this.boxHost.Margin = new System.Windows.Forms.Padding(2);
            this.boxHost.Name = "boxHost";
            this.boxHost.Size = new System.Drawing.Size(97, 23);
            this.boxHost.TabIndex = 15;
            this.boxHost.Text = "8888";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Server Host";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.boxServer);
            this.groupBox1.Controls.Add(this.boxHost);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(22, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(448, 192);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 143);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 19);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFilename);
            this.groupBox2.Controls.Add(this.btnOpenfile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.boxFilepath);
            this.groupBox2.Location = new System.Drawing.Point(22, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(448, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // txtFilename
            // 
            this.txtFilename.AutoSize = true;
            this.txtFilename.Location = new System.Drawing.Point(92, 24);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(58, 13);
            this.txtFilename.TabIndex = 12;
            this.txtFilename.Text = "Open a file";
            // 
            // boxLog
            // 
            this.boxLog.FormattingEnabled = true;
            this.boxLog.Location = new System.Drawing.Point(22, 343);
            this.boxLog.Margin = new System.Windows.Forms.Padding(2);
            this.boxLog.Name = "boxLog";
            this.boxLog.Size = new System.Drawing.Size(450, 160);
            this.boxLog.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewFiles);
            this.groupBox3.Controls.Add(this.btnDownload);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnRename);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.labelSelected);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.boxRename);
            this.groupBox3.Controls.Add(this.btnGetFiles);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(505, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(319, 495);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Operations";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFile,
            this.columnDate,
            this.columnSize,
            this.columnSharedBy});
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFiles.Location = new System.Drawing.Point(15, 45);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(1);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(279, 282);
            this.listViewFiles.TabIndex = 21;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // columnFile
            // 
            this.columnFile.Text = "Name";
            this.columnFile.Width = 180;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 120;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.Width = 50;
            // 
            // columnSharedBy
            // 
            this.columnSharedBy.Text = "Shared By";
            this.columnSharedBy.Width = 50;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(181, 399);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(111, 20);
            this.btnDownload.TabIndex = 25;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 399);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 20);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(215, 438);
            this.btnRename.Margin = new System.Windows.Forms.Padding(1);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(77, 19);
            this.btnRename.TabIndex = 23;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelected.Location = new System.Drawing.Point(104, 370);
            this.labelSelected.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(19, 13);
            this.labelSelected.TabIndex = 21;
            this.labelSelected.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected file: ";
            // 
            // boxRename
            // 
            this.boxRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRename.Location = new System.Drawing.Point(15, 438);
            this.boxRename.Margin = new System.Windows.Forms.Padding(1);
            this.boxRename.Name = "boxRename";
            this.boxRename.Size = new System.Drawing.Size(187, 23);
            this.boxRename.TabIndex = 19;
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(15, 337);
            this.btnGetFiles.Margin = new System.Windows.Forms.Padding(1);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(89, 19);
            this.btnGetFiles.TabIndex = 18;
            this.btnGetFiles.Text = "Show file list";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Files";
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(15, 38);
            this.userList.Margin = new System.Windows.Forms.Padding(2);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(254, 277);
            this.userList.TabIndex = 21;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "User List";
            // 
            // userListBtn
            // 
            this.userListBtn.Location = new System.Drawing.Point(15, 330);
            this.userListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.userListBtn.Name = "userListBtn";
            this.userListBtn.Size = new System.Drawing.Size(120, 19);
            this.userListBtn.TabIndex = 23;
            this.userListBtn.Text = "Show user list";
            this.userListBtn.UseVisualStyleBackColor = true;
            this.userListBtn.Click += new System.EventHandler(this.userListBtn_Click);
            // 
            // refreshUserBtn
            // 
            this.refreshUserBtn.Location = new System.Drawing.Point(165, 330);
            this.refreshUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshUserBtn.Name = "refreshUserBtn";
            this.refreshUserBtn.Size = new System.Drawing.Size(102, 19);
            this.refreshUserBtn.TabIndex = 24;
            this.refreshUserBtn.Text = "Refresh";
            this.refreshUserBtn.UseVisualStyleBackColor = true;
            this.refreshUserBtn.Click += new System.EventHandler(this.refreshUserBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Selected User:";
            // 
            // labelSelectedUser
            // 
            this.labelSelectedUser.AutoSize = true;
            this.labelSelectedUser.Location = new System.Drawing.Point(107, 370);
            this.labelSelectedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedUser.Name = "labelSelectedUser";
            this.labelSelectedUser.Size = new System.Drawing.Size(16, 13);
            this.labelSelectedUser.TabIndex = 26;
            this.labelSelectedUser.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 405);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Selected File:";
            // 
            // labelSelectedFile
            // 
            this.labelSelectedFile.AutoSize = true;
            this.labelSelectedFile.Location = new System.Drawing.Point(107, 405);
            this.labelSelectedFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedFile.Name = "labelSelectedFile";
            this.labelSelectedFile.Size = new System.Drawing.Size(16, 13);
            this.labelSelectedFile.TabIndex = 28;
            this.labelSelectedFile.Text = "...";
            // 
            // shareBtn
            // 
            this.shareBtn.Location = new System.Drawing.Point(17, 438);
            this.shareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(117, 21);
            this.shareBtn.TabIndex = 29;
            this.shareBtn.Text = "Share";
            this.shareBtn.UseVisualStyleBackColor = true;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // unshareBtn
            // 
            this.unshareBtn.Location = new System.Drawing.Point(165, 436);
            this.unshareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.unshareBtn.Name = "unshareBtn";
            this.unshareBtn.Size = new System.Drawing.Size(102, 23);
            this.unshareBtn.TabIndex = 30;
            this.unshareBtn.Text = "Unshare";
            this.unshareBtn.UseVisualStyleBackColor = true;
            this.unshareBtn.Click += new System.EventHandler(this.unshareBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.userList);
            this.groupBox4.Controls.Add(this.unshareBtn);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.shareBtn);
            this.groupBox4.Controls.Add(this.userListBtn);
            this.groupBox4.Controls.Add(this.labelSelectedFile);
            this.groupBox4.Controls.Add(this.refreshUserBtn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.labelSelectedUser);
            this.groupBox4.Location = new System.Drawing.Point(839, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(289, 494);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Share Operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 482);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.boxLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBox5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ClientGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label txtBox5;
        private System.Windows.Forms.TextBox boxFilepath;
        private System.Windows.Forms.Button btnOpenfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxServer;
        private System.Windows.Forms.TextBox boxHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtFilename;
        private System.Windows.Forms.ListBox boxLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxRename;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button userListBtn;
        private System.Windows.Forms.Button refreshUserBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSelectedUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSelectedFile;
        private System.Windows.Forms.Button shareBtn;
        private System.Windows.Forms.Button unshareBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ColumnHeader columnSharedBy;
    }
}

