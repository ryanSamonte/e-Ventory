namespace projectTemp
{
    partial class ticketscanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.noResFoundLbl = new System.Windows.Forms.Label();
            this.searchTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.eventNameLbl = new System.Windows.Forms.Label();
            this.changeLbl = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.webcamList = new MetroFramework.Controls.MetroComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.invalidLbl = new System.Windows.Forms.Label();
            this.validLbl = new System.Windows.Forms.Label();
            this.ticketDsntExistLbl = new System.Windows.Forms.Label();
            this.ticketScanAlrdyLbl = new System.Windows.Forms.Label();
            this.checkOutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.validIcon = new System.Windows.Forms.PictureBox();
            this.invalidIcon = new System.Windows.Forms.PictureBox();
            this.stopCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cameraPreview = new System.Windows.Forms.PictureBox();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.sucssflChkOutLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // noResFoundLbl
            // 
            this.noResFoundLbl.AutoSize = true;
            this.noResFoundLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResFoundLbl.Location = new System.Drawing.Point(391, 155);
            this.noResFoundLbl.Name = "noResFoundLbl";
            this.noResFoundLbl.Size = new System.Drawing.Size(205, 88);
            this.noResFoundLbl.TabIndex = 72;
            this.noResFoundLbl.Text = "NO RESULT\r\n   FOUND";
            this.noResFoundLbl.Visible = false;
            // 
            // searchTxt
            // 
            this.searchTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.searchTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.searchTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.searchTxt.BorderThickness = 3;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTxt.ForeColor = System.Drawing.Color.Black;
            this.searchTxt.isPassword = false;
            this.searchTxt.Location = new System.Drawing.Point(331, 14);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(315, 42);
            this.searchTxt.TabIndex = 70;
            this.searchTxt.Text = "Event Name";
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTxt.OnValueChanged += new System.EventHandler(this.searchTxt_OnValueChanged);
            this.searchTxt.Enter += new System.EventHandler(this.searchTxt_Enter);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.searchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.searchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchResult.ColumnHeadersHeight = 20;
            this.searchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.searchResult.DoubleBuffered = false;
            this.searchResult.EnableHeadersVisualStyles = false;
            this.searchResult.GridColor = System.Drawing.Color.Black;
            this.searchResult.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.searchResult.HeaderForeColor = System.Drawing.Color.White;
            this.searchResult.Location = new System.Drawing.Point(331, 98);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.Size = new System.Drawing.Size(316, 213);
            this.searchResult.TabIndex = 69;
            this.searchResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResult_CellMouseClick);
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Scanning Ticket for:";
            // 
            // eventNameLbl
            // 
            this.eventNameLbl.AutoSize = true;
            this.eventNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLbl.Location = new System.Drawing.Point(18, 536);
            this.eventNameLbl.Name = "eventNameLbl";
            this.eventNameLbl.Size = new System.Drawing.Size(0, 19);
            this.eventNameLbl.TabIndex = 92;
            // 
            // changeLbl
            // 
            this.changeLbl.AutoSize = true;
            this.changeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLbl.Location = new System.Drawing.Point(410, 233);
            this.changeLbl.Name = "changeLbl";
            this.changeLbl.Size = new System.Drawing.Size(0, 19);
            this.changeLbl.TabIndex = 84;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(317, 20);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 565);
            this.bunifuSeparator1.TabIndex = 77;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // webcamList
            // 
            this.webcamList.FormattingEnabled = true;
            this.webcamList.ItemHeight = 23;
            this.webcamList.Location = new System.Drawing.Point(22, 20);
            this.webcamList.Name = "webcamList";
            this.webcamList.Size = new System.Drawing.Size(274, 29);
            this.webcamList.TabIndex = 73;
            this.webcamList.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // invalidLbl
            // 
            this.invalidLbl.AutoSize = true;
            this.invalidLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidLbl.Location = new System.Drawing.Point(376, 329);
            this.invalidLbl.Name = "invalidLbl";
            this.invalidLbl.Size = new System.Drawing.Size(162, 44);
            this.invalidLbl.TabIndex = 95;
            this.invalidLbl.Text = "INVALID";
            this.invalidLbl.Visible = false;
            // 
            // validLbl
            // 
            this.validLbl.AutoSize = true;
            this.validLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validLbl.ForeColor = System.Drawing.Color.Green;
            this.validLbl.Location = new System.Drawing.Point(399, 330);
            this.validLbl.Name = "validLbl";
            this.validLbl.Size = new System.Drawing.Size(125, 44);
            this.validLbl.TabIndex = 97;
            this.validLbl.Text = "VALID";
            this.validLbl.Visible = false;
            // 
            // ticketDsntExistLbl
            // 
            this.ticketDsntExistLbl.AutoSize = true;
            this.ticketDsntExistLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketDsntExistLbl.ForeColor = System.Drawing.Color.Red;
            this.ticketDsntExistLbl.Location = new System.Drawing.Point(352, 458);
            this.ticketDsntExistLbl.Name = "ticketDsntExistLbl";
            this.ticketDsntExistLbl.Size = new System.Drawing.Size(270, 32);
            this.ticketDsntExistLbl.TabIndex = 99;
            this.ticketDsntExistLbl.Text = "Ticket doesn\'t exists";
            this.ticketDsntExistLbl.Visible = false;
            // 
            // ticketScanAlrdyLbl
            // 
            this.ticketScanAlrdyLbl.AutoSize = true;
            this.ticketScanAlrdyLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketScanAlrdyLbl.ForeColor = System.Drawing.Color.Red;
            this.ticketScanAlrdyLbl.Location = new System.Drawing.Point(345, 458);
            this.ticketScanAlrdyLbl.Name = "ticketScanAlrdyLbl";
            this.ticketScanAlrdyLbl.Size = new System.Drawing.Size(285, 28);
            this.ticketScanAlrdyLbl.TabIndex = 100;
            this.ticketScanAlrdyLbl.Text = "Ticket scanned already";
            this.ticketScanAlrdyLbl.Visible = false;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Activecolor = System.Drawing.Color.Red;
            this.checkOutBtn.BackColor = System.Drawing.Color.Red;
            this.checkOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkOutBtn.BorderRadius = 0;
            this.checkOutBtn.ButtonText = "Check-out";
            this.checkOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.checkOutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkOutBtn.Iconimage = global::projectTemp.Properties.Resources.exit;
            this.checkOutBtn.Iconimage_right = null;
            this.checkOutBtn.Iconimage_right_Selected = null;
            this.checkOutBtn.Iconimage_Selected = null;
            this.checkOutBtn.IconMarginLeft = 16;
            this.checkOutBtn.IconMarginRight = 0;
            this.checkOutBtn.IconRightVisible = true;
            this.checkOutBtn.IconRightZoom = 0D;
            this.checkOutBtn.IconVisible = true;
            this.checkOutBtn.IconZoom = 70D;
            this.checkOutBtn.IsTab = true;
            this.checkOutBtn.Location = new System.Drawing.Point(412, 496);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Normalcolor = System.Drawing.Color.Red;
            this.checkOutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkOutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkOutBtn.selected = false;
            this.checkOutBtn.Size = new System.Drawing.Size(151, 45);
            this.checkOutBtn.TabIndex = 101;
            this.checkOutBtn.Text = "Check-out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.Textcolor = System.Drawing.Color.White;
            this.checkOutBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.Visible = false;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // validIcon
            // 
            this.validIcon.Image = global::projectTemp.Properties.Resources._22414747_1509503205798200_558630736_n;
            this.validIcon.Location = new System.Drawing.Point(519, 326);
            this.validIcon.Name = "validIcon";
            this.validIcon.Size = new System.Drawing.Size(71, 50);
            this.validIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.validIcon.TabIndex = 98;
            this.validIcon.TabStop = false;
            this.validIcon.Visible = false;
            // 
            // invalidIcon
            // 
            this.invalidIcon.Image = global::projectTemp.Properties.Resources._unchecked;
            this.invalidIcon.Location = new System.Drawing.Point(530, 326);
            this.invalidIcon.Name = "invalidIcon";
            this.invalidIcon.Size = new System.Drawing.Size(71, 50);
            this.invalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invalidIcon.TabIndex = 96;
            this.invalidIcon.TabStop = false;
            this.invalidIcon.Visible = false;
            // 
            // stopCamera
            // 
            this.stopCamera.Activecolor = System.Drawing.Color.Red;
            this.stopCamera.BackColor = System.Drawing.Color.Red;
            this.stopCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopCamera.BorderRadius = 0;
            this.stopCamera.ButtonText = "  Stop Camera";
            this.stopCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopCamera.DisabledColor = System.Drawing.Color.Gray;
            this.stopCamera.Iconcolor = System.Drawing.Color.Transparent;
            this.stopCamera.Iconimage = global::projectTemp.Properties.Resources.no_picture_taking_allowed;
            this.stopCamera.Iconimage_right = null;
            this.stopCamera.Iconimage_right_Selected = null;
            this.stopCamera.Iconimage_Selected = null;
            this.stopCamera.IconMarginLeft = 10;
            this.stopCamera.IconMarginRight = 0;
            this.stopCamera.IconRightVisible = true;
            this.stopCamera.IconRightZoom = 0D;
            this.stopCamera.IconVisible = true;
            this.stopCamera.IconZoom = 50D;
            this.stopCamera.IsTab = true;
            this.stopCamera.Location = new System.Drawing.Point(83, 422);
            this.stopCamera.Name = "stopCamera";
            this.stopCamera.Normalcolor = System.Drawing.Color.Red;
            this.stopCamera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopCamera.OnHoverTextColor = System.Drawing.Color.White;
            this.stopCamera.selected = false;
            this.stopCamera.Size = new System.Drawing.Size(151, 35);
            this.stopCamera.TabIndex = 90;
            this.stopCamera.Text = "  Stop Camera";
            this.stopCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopCamera.Textcolor = System.Drawing.Color.White;
            this.stopCamera.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCamera.Click += new System.EventHandler(this.stopCamera_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBtn.BorderRadius = 0;
            this.checkBtn.ButtonText = "Scan QR Code";
            this.checkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBtn.DisabledColor = System.Drawing.Color.Gray;
            this.checkBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkBtn.Iconimage = global::projectTemp.Properties.Resources.qr_code_scan;
            this.checkBtn.Iconimage_right = null;
            this.checkBtn.Iconimage_right_Selected = null;
            this.checkBtn.Iconimage_Selected = null;
            this.checkBtn.IconMarginLeft = 10;
            this.checkBtn.IconMarginRight = 0;
            this.checkBtn.IconRightVisible = true;
            this.checkBtn.IconRightZoom = 0D;
            this.checkBtn.IconVisible = true;
            this.checkBtn.IconZoom = 50D;
            this.checkBtn.IsTab = true;
            this.checkBtn.Location = new System.Drawing.Point(83, 381);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkBtn.selected = false;
            this.checkBtn.Size = new System.Drawing.Size(151, 35);
            this.checkBtn.TabIndex = 89;
            this.checkBtn.Text = "Scan QR Code";
            this.checkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBtn.Textcolor = System.Drawing.Color.White;
            this.checkBtn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // openCamera
            // 
            this.openCamera.Activecolor = System.Drawing.Color.SeaGreen;
            this.openCamera.BackColor = System.Drawing.Color.SeaGreen;
            this.openCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openCamera.BorderRadius = 0;
            this.openCamera.ButtonText = "Open Camera";
            this.openCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCamera.DisabledColor = System.Drawing.Color.Gray;
            this.openCamera.Iconcolor = System.Drawing.Color.Transparent;
            this.openCamera.Iconimage = global::projectTemp.Properties.Resources.opening_aperture;
            this.openCamera.Iconimage_right = null;
            this.openCamera.Iconimage_right_Selected = null;
            this.openCamera.Iconimage_Selected = null;
            this.openCamera.IconMarginLeft = 10;
            this.openCamera.IconMarginRight = 0;
            this.openCamera.IconRightVisible = true;
            this.openCamera.IconRightZoom = 0D;
            this.openCamera.IconVisible = true;
            this.openCamera.IconZoom = 50D;
            this.openCamera.IsTab = true;
            this.openCamera.Location = new System.Drawing.Point(83, 341);
            this.openCamera.Name = "openCamera";
            this.openCamera.Normalcolor = System.Drawing.Color.SeaGreen;
            this.openCamera.OnHovercolor = System.Drawing.Color.Green;
            this.openCamera.OnHoverTextColor = System.Drawing.Color.White;
            this.openCamera.selected = false;
            this.openCamera.Size = new System.Drawing.Size(151, 35);
            this.openCamera.TabIndex = 88;
            this.openCamera.Text = "Open Camera";
            this.openCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCamera.Textcolor = System.Drawing.Color.White;
            this.openCamera.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCamera.Click += new System.EventHandler(this.openCamera_Click);
            // 
            // cameraPreview
            // 
            this.cameraPreview.Location = new System.Drawing.Point(22, 74);
            this.cameraPreview.Name = "cameraPreview";
            this.cameraPreview.Size = new System.Drawing.Size(274, 253);
            this.cameraPreview.TabIndex = 74;
            this.cameraPreview.TabStop = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.BorderRadius = 0;
            this.refreshBtn.ButtonText = "  Refresh";
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.DisabledColor = System.Drawing.Color.Gray;
            this.refreshBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshBtn.Iconimage = global::projectTemp.Properties.Resources.refresh_icon;
            this.refreshBtn.Iconimage_right = null;
            this.refreshBtn.Iconimage_right_Selected = null;
            this.refreshBtn.Iconimage_Selected = null;
            this.refreshBtn.IconMarginLeft = 16;
            this.refreshBtn.IconMarginRight = 0;
            this.refreshBtn.IconRightVisible = true;
            this.refreshBtn.IconRightZoom = 0D;
            this.refreshBtn.IconVisible = true;
            this.refreshBtn.IconZoom = 60D;
            this.refreshBtn.IsTab = false;
            this.refreshBtn.Location = new System.Drawing.Point(519, 56);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshBtn.selected = false;
            this.refreshBtn.Size = new System.Drawing.Size(128, 36);
            this.refreshBtn.TabIndex = 71;
            this.refreshBtn.Text = "  Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.Green;
            this.welcomeLbl.Location = new System.Drawing.Point(389, 383);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(200, 44);
            this.welcomeLbl.TabIndex = 102;
            this.welcomeLbl.Text = "WELCOME";
            this.welcomeLbl.Visible = false;
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLbl.ForeColor = System.Drawing.Color.Green;
            this.partNameLbl.Location = new System.Drawing.Point(340, 442);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(93, 32);
            this.partNameLbl.TabIndex = 103;
            this.partNameLbl.Text = "VALID";
            this.partNameLbl.Visible = false;
            // 
            // sucssflChkOutLbl
            // 
            this.sucssflChkOutLbl.AutoSize = true;
            this.sucssflChkOutLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucssflChkOutLbl.ForeColor = System.Drawing.Color.Green;
            this.sucssflChkOutLbl.Location = new System.Drawing.Point(369, 544);
            this.sucssflChkOutLbl.Name = "sucssflChkOutLbl";
            this.sucssflChkOutLbl.Size = new System.Drawing.Size(229, 23);
            this.sucssflChkOutLbl.TabIndex = 104;
            this.sucssflChkOutLbl.Text = "Successful Check-out!";
            this.sucssflChkOutLbl.Visible = false;
            // 
            // ticketscanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sucssflChkOutLbl);
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.ticketScanAlrdyLbl);
            this.Controls.Add(this.ticketDsntExistLbl);
            this.Controls.Add(this.validIcon);
            this.Controls.Add(this.validLbl);
            this.Controls.Add(this.invalidIcon);
            this.Controls.Add(this.invalidLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eventNameLbl);
            this.Controls.Add(this.stopCamera);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.openCamera);
            this.Controls.Add(this.changeLbl);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cameraPreview);
            this.Controls.Add(this.webcamList);
            this.Controls.Add(this.noResFoundLbl);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchResult);
            this.Name = "ticketscanner";
            this.Size = new System.Drawing.Size(655, 609);
            this.Load += new System.EventHandler(this.ticketscanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label noResFoundLbl;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label eventNameLbl;
        private Bunifu.Framework.UI.BunifuFlatButton stopCamera;
        private Bunifu.Framework.UI.BunifuFlatButton checkBtn;
        private Bunifu.Framework.UI.BunifuFlatButton openCamera;
        private System.Windows.Forms.Label changeLbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox cameraPreview;
        private MetroFramework.Controls.MetroComboBox webcamList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label invalidLbl;
        private System.Windows.Forms.PictureBox invalidIcon;
        private System.Windows.Forms.Label validLbl;
        private System.Windows.Forms.PictureBox validIcon;
        private System.Windows.Forms.Label ticketDsntExistLbl;
        private System.Windows.Forms.Label ticketScanAlrdyLbl;
        private Bunifu.Framework.UI.BunifuFlatButton checkOutBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label partNameLbl;
        private System.Windows.Forms.Label sucssflChkOutLbl;
    }
}
