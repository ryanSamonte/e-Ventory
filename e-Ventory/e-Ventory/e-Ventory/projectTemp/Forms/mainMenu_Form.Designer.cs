namespace projectTemp
{
    partial class mainMenu_Form
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu_Form));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.regiBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.wlcmLbl = new System.Windows.Forms.Label();
            this.announcementBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.systemLogsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.participantBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tickVouchbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.paymentBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.monitorEventbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addEventbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.smallSystemLogo = new System.Windows.Forms.PictureBox();
            this.dashBoardbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.systemLogo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.showBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.hideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logOutLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.logOutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.participants1 = new projectTemp.participants();
            this.payment1 = new projectTemp.payment();
            this.registration1 = new projectTemp.registration();
            this.dashboard1 = new projectTemp.dashboard();
            this.monitorEvent1 = new projectTemp.User_Control.monitorEvent();
            this.addEvent1 = new projectTemp.User_Control.addEvent();
            this.systemLogs1 = new projectTemp.User_Control.systemLogs();
            this.announcementUserControl1 = new projectTemp.Forms.announcementUserControl();
            this.ticketscanner1 = new projectTemp.ticketscanner();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallSystemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLogo)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.panelTransition.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.close.Location = new System.Drawing.Point(857, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 39);
            this.close.TabIndex = 2;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.logoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 46);
            this.panel1.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.panelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 33);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "e-Ventory";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::projectTemp.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.panelTransition.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.minimize.Location = new System.Drawing.Point(829, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 33);
            this.minimize.TabIndex = 1;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.regiBtn);
            this.panelMenu.Controls.Add(this.wlcmLbl);
            this.panelMenu.Controls.Add(this.announcementBtn);
            this.panelMenu.Controls.Add(this.systemLogsBtn);
            this.panelMenu.Controls.Add(this.participantBtn);
            this.panelMenu.Controls.Add(this.tickVouchbtn);
            this.panelMenu.Controls.Add(this.paymentBtn);
            this.panelMenu.Controls.Add(this.monitorEventbtn);
            this.panelMenu.Controls.Add(this.addEventbtn);
            this.panelMenu.Controls.Add(this.smallSystemLogo);
            this.panelMenu.Controls.Add(this.dashBoardbtn);
            this.panelMenu.Controls.Add(this.menuButton);
            this.panelMenu.Controls.Add(this.systemLogo);
            this.logoTransition.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 609);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // regiBtn
            // 
            this.regiBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.regiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.regiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regiBtn.BorderRadius = 0;
            this.regiBtn.ButtonText = "     Registration";
            this.regiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.regiBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.regiBtn, BunifuAnimatorNS.DecorationType.None);
            this.regiBtn.DisabledColor = System.Drawing.Color.Gray;
            this.regiBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.regiBtn.Iconimage = global::projectTemp.Properties.Resources.note1;
            this.regiBtn.Iconimage_right = null;
            this.regiBtn.Iconimage_right_Selected = null;
            this.regiBtn.Iconimage_Selected = null;
            this.regiBtn.IconMarginLeft = 23;
            this.regiBtn.IconMarginRight = 0;
            this.regiBtn.IconRightVisible = true;
            this.regiBtn.IconRightZoom = 0D;
            this.regiBtn.IconVisible = true;
            this.regiBtn.IconZoom = 70D;
            this.regiBtn.IsTab = true;
            this.regiBtn.Location = new System.Drawing.Point(0, 390);
            this.regiBtn.Name = "regiBtn";
            this.regiBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.regiBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.regiBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.regiBtn.selected = false;
            this.regiBtn.Size = new System.Drawing.Size(246, 43);
            this.regiBtn.TabIndex = 18;
            this.regiBtn.Text = "     Registration";
            this.regiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regiBtn.Textcolor = System.Drawing.Color.White;
            this.regiBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiBtn.Click += new System.EventHandler(this.regiBtn_Click);
            // 
            // wlcmLbl
            // 
            this.wlcmLbl.AutoSize = true;
            this.panelTransition.SetDecoration(this.wlcmLbl, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.wlcmLbl, BunifuAnimatorNS.DecorationType.None);
            this.wlcmLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcmLbl.ForeColor = System.Drawing.Color.White;
            this.wlcmLbl.Location = new System.Drawing.Point(34, 119);
            this.wlcmLbl.Name = "wlcmLbl";
            this.wlcmLbl.Size = new System.Drawing.Size(165, 22);
            this.wlcmLbl.TabIndex = 17;
            this.wlcmLbl.Text = "Welcome Admin!";
            // 
            // announcementBtn
            // 
            this.announcementBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.announcementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.announcementBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.announcementBtn.BorderRadius = 0;
            this.announcementBtn.ButtonText = "     Announcement";
            this.announcementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.announcementBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.announcementBtn, BunifuAnimatorNS.DecorationType.None);
            this.announcementBtn.DisabledColor = System.Drawing.Color.Gray;
            this.announcementBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.announcementBtn.Iconimage = global::projectTemp.Properties.Resources.newspaper;
            this.announcementBtn.Iconimage_right = null;
            this.announcementBtn.Iconimage_right_Selected = null;
            this.announcementBtn.Iconimage_Selected = null;
            this.announcementBtn.IconMarginLeft = 22;
            this.announcementBtn.IconMarginRight = 0;
            this.announcementBtn.IconRightVisible = true;
            this.announcementBtn.IconRightZoom = 0D;
            this.announcementBtn.IconVisible = true;
            this.announcementBtn.IconZoom = 78D;
            this.announcementBtn.IsTab = true;
            this.announcementBtn.Location = new System.Drawing.Point(0, 479);
            this.announcementBtn.Name = "announcementBtn";
            this.announcementBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.announcementBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.announcementBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.announcementBtn.selected = false;
            this.announcementBtn.Size = new System.Drawing.Size(246, 43);
            this.announcementBtn.TabIndex = 15;
            this.announcementBtn.Text = "     Announcement";
            this.announcementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.announcementBtn.Textcolor = System.Drawing.Color.White;
            this.announcementBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementBtn.Click += new System.EventHandler(this.announcementBtn_Click);
            // 
            // systemLogsBtn
            // 
            this.systemLogsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.systemLogsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.systemLogsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.systemLogsBtn.BorderRadius = 0;
            this.systemLogsBtn.ButtonText = "    System Logs";
            this.systemLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.systemLogsBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.systemLogsBtn, BunifuAnimatorNS.DecorationType.None);
            this.systemLogsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.systemLogsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.systemLogsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("systemLogsBtn.Iconimage")));
            this.systemLogsBtn.Iconimage_right = null;
            this.systemLogsBtn.Iconimage_right_Selected = null;
            this.systemLogsBtn.Iconimage_Selected = null;
            this.systemLogsBtn.IconMarginLeft = 23;
            this.systemLogsBtn.IconMarginRight = 0;
            this.systemLogsBtn.IconRightVisible = true;
            this.systemLogsBtn.IconRightZoom = 0D;
            this.systemLogsBtn.IconVisible = true;
            this.systemLogsBtn.IconZoom = 84D;
            this.systemLogsBtn.IsTab = true;
            this.systemLogsBtn.Location = new System.Drawing.Point(0, 525);
            this.systemLogsBtn.Name = "systemLogsBtn";
            this.systemLogsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.systemLogsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.systemLogsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.systemLogsBtn.selected = false;
            this.systemLogsBtn.Size = new System.Drawing.Size(246, 43);
            this.systemLogsBtn.TabIndex = 13;
            this.systemLogsBtn.Text = "    System Logs";
            this.systemLogsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.systemLogsBtn.Textcolor = System.Drawing.Color.White;
            this.systemLogsBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLogsBtn.Click += new System.EventHandler(this.systemLogsBtn_Click);
            // 
            // participantBtn
            // 
            this.participantBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.participantBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.participantBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.participantBtn.BorderRadius = 0;
            this.participantBtn.ButtonText = "     Participants";
            this.participantBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.participantBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.participantBtn, BunifuAnimatorNS.DecorationType.None);
            this.participantBtn.DisabledColor = System.Drawing.Color.Gray;
            this.participantBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.participantBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("participantBtn.Iconimage")));
            this.participantBtn.Iconimage_right = null;
            this.participantBtn.Iconimage_right_Selected = null;
            this.participantBtn.Iconimage_Selected = null;
            this.participantBtn.IconMarginLeft = 22;
            this.participantBtn.IconMarginRight = 0;
            this.participantBtn.IconRightVisible = true;
            this.participantBtn.IconRightZoom = 0D;
            this.participantBtn.IconVisible = true;
            this.participantBtn.IconZoom = 78D;
            this.participantBtn.IsTab = true;
            this.participantBtn.Location = new System.Drawing.Point(0, 433);
            this.participantBtn.Name = "participantBtn";
            this.participantBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.participantBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.participantBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.participantBtn.selected = false;
            this.participantBtn.Size = new System.Drawing.Size(246, 43);
            this.participantBtn.TabIndex = 11;
            this.participantBtn.Text = "     Participants";
            this.participantBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.participantBtn.Textcolor = System.Drawing.Color.White;
            this.participantBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantBtn.Click += new System.EventHandler(this.participantBtn_Click);
            // 
            // tickVouchbtn
            // 
            this.tickVouchbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.tickVouchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.tickVouchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tickVouchbtn.BorderRadius = 0;
            this.tickVouchbtn.ButtonText = "     Ticket Scanner";
            this.tickVouchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.tickVouchbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.tickVouchbtn, BunifuAnimatorNS.DecorationType.None);
            this.tickVouchbtn.DisabledColor = System.Drawing.Color.Gray;
            this.tickVouchbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.tickVouchbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("tickVouchbtn.Iconimage")));
            this.tickVouchbtn.Iconimage_right = null;
            this.tickVouchbtn.Iconimage_right_Selected = null;
            this.tickVouchbtn.Iconimage_Selected = null;
            this.tickVouchbtn.IconMarginLeft = 23;
            this.tickVouchbtn.IconMarginRight = 0;
            this.tickVouchbtn.IconRightVisible = true;
            this.tickVouchbtn.IconRightZoom = 0D;
            this.tickVouchbtn.IconVisible = true;
            this.tickVouchbtn.IconZoom = 70D;
            this.tickVouchbtn.IsTab = true;
            this.tickVouchbtn.Location = new System.Drawing.Point(0, 345);
            this.tickVouchbtn.Name = "tickVouchbtn";
            this.tickVouchbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.tickVouchbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.tickVouchbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.tickVouchbtn.selected = false;
            this.tickVouchbtn.Size = new System.Drawing.Size(246, 43);
            this.tickVouchbtn.TabIndex = 10;
            this.tickVouchbtn.Text = "     Ticket Scanner";
            this.tickVouchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tickVouchbtn.Textcolor = System.Drawing.Color.White;
            this.tickVouchbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickVouchbtn.Click += new System.EventHandler(this.tickVouchbtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.paymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.paymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paymentBtn.BorderRadius = 0;
            this.paymentBtn.ButtonText = "    Payment";
            this.paymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.paymentBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.paymentBtn, BunifuAnimatorNS.DecorationType.None);
            this.paymentBtn.DisabledColor = System.Drawing.Color.Gray;
            this.paymentBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.paymentBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("paymentBtn.Iconimage")));
            this.paymentBtn.Iconimage_right = null;
            this.paymentBtn.Iconimage_right_Selected = null;
            this.paymentBtn.Iconimage_Selected = null;
            this.paymentBtn.IconMarginLeft = 23;
            this.paymentBtn.IconMarginRight = 0;
            this.paymentBtn.IconRightVisible = true;
            this.paymentBtn.IconRightZoom = 0D;
            this.paymentBtn.IconVisible = true;
            this.paymentBtn.IconZoom = 85D;
            this.paymentBtn.IsTab = true;
            this.paymentBtn.Location = new System.Drawing.Point(0, 299);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.paymentBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.paymentBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.paymentBtn.selected = false;
            this.paymentBtn.Size = new System.Drawing.Size(246, 43);
            this.paymentBtn.TabIndex = 9;
            this.paymentBtn.Text = "    Payment";
            this.paymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentBtn.Textcolor = System.Drawing.Color.White;
            this.paymentBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // monitorEventbtn
            // 
            this.monitorEventbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.monitorEventbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.monitorEventbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monitorEventbtn.BorderRadius = 0;
            this.monitorEventbtn.ButtonText = "     Monitor Event";
            this.monitorEventbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.monitorEventbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.monitorEventbtn, BunifuAnimatorNS.DecorationType.None);
            this.monitorEventbtn.DisabledColor = System.Drawing.Color.Gray;
            this.monitorEventbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.monitorEventbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("monitorEventbtn.Iconimage")));
            this.monitorEventbtn.Iconimage_right = null;
            this.monitorEventbtn.Iconimage_right_Selected = null;
            this.monitorEventbtn.Iconimage_Selected = null;
            this.monitorEventbtn.IconMarginLeft = 23;
            this.monitorEventbtn.IconMarginRight = 0;
            this.monitorEventbtn.IconRightVisible = true;
            this.monitorEventbtn.IconRightZoom = 0D;
            this.monitorEventbtn.IconVisible = true;
            this.monitorEventbtn.IconZoom = 70D;
            this.monitorEventbtn.IsTab = true;
            this.monitorEventbtn.Location = new System.Drawing.Point(0, 253);
            this.monitorEventbtn.Name = "monitorEventbtn";
            this.monitorEventbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.monitorEventbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.monitorEventbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.monitorEventbtn.selected = false;
            this.monitorEventbtn.Size = new System.Drawing.Size(246, 43);
            this.monitorEventbtn.TabIndex = 8;
            this.monitorEventbtn.Text = "     Monitor Event";
            this.monitorEventbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorEventbtn.Textcolor = System.Drawing.Color.White;
            this.monitorEventbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorEventbtn.Click += new System.EventHandler(this.monitorEventbtn_Click);
            // 
            // addEventbtn
            // 
            this.addEventbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.addEventbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.addEventbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEventbtn.BorderRadius = 0;
            this.addEventbtn.ButtonText = "     Add Event";
            this.addEventbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.addEventbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.addEventbtn, BunifuAnimatorNS.DecorationType.None);
            this.addEventbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addEventbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addEventbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addEventbtn.Iconimage")));
            this.addEventbtn.Iconimage_right = null;
            this.addEventbtn.Iconimage_right_Selected = null;
            this.addEventbtn.Iconimage_Selected = null;
            this.addEventbtn.IconMarginLeft = 23;
            this.addEventbtn.IconMarginRight = 0;
            this.addEventbtn.IconRightVisible = true;
            this.addEventbtn.IconRightZoom = 0D;
            this.addEventbtn.IconVisible = true;
            this.addEventbtn.IconZoom = 70D;
            this.addEventbtn.IsTab = true;
            this.addEventbtn.Location = new System.Drawing.Point(0, 207);
            this.addEventbtn.Name = "addEventbtn";
            this.addEventbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.addEventbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.addEventbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.addEventbtn.selected = false;
            this.addEventbtn.Size = new System.Drawing.Size(246, 43);
            this.addEventbtn.TabIndex = 7;
            this.addEventbtn.Text = "     Add Event";
            this.addEventbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEventbtn.Textcolor = System.Drawing.Color.White;
            this.addEventbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventbtn.Click += new System.EventHandler(this.addEventbtn_Click);
            // 
            // smallSystemLogo
            // 
            this.smallSystemLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.smallSystemLogo, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.smallSystemLogo, BunifuAnimatorNS.DecorationType.None);
            this.smallSystemLogo.Image = global::projectTemp.Properties.Resources.icon;
            this.smallSystemLogo.Location = new System.Drawing.Point(17, 72);
            this.smallSystemLogo.Name = "smallSystemLogo";
            this.smallSystemLogo.Size = new System.Drawing.Size(46, 47);
            this.smallSystemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallSystemLogo.TabIndex = 6;
            this.smallSystemLogo.TabStop = false;
            this.smallSystemLogo.Visible = false;
            this.smallSystemLogo.Click += new System.EventHandler(this.smallSystemLogo_Click);
            // 
            // dashBoardbtn
            // 
            this.dashBoardbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.dashBoardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.dashBoardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashBoardbtn.BorderRadius = 0;
            this.dashBoardbtn.ButtonText = "     Dashboard";
            this.dashBoardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.dashBoardbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.dashBoardbtn, BunifuAnimatorNS.DecorationType.None);
            this.dashBoardbtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashBoardbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashBoardbtn.Iconimage = global::projectTemp.Properties.Resources.dashboard;
            this.dashBoardbtn.Iconimage_right = null;
            this.dashBoardbtn.Iconimage_right_Selected = null;
            this.dashBoardbtn.Iconimage_Selected = null;
            this.dashBoardbtn.IconMarginLeft = 23;
            this.dashBoardbtn.IconMarginRight = 0;
            this.dashBoardbtn.IconRightVisible = true;
            this.dashBoardbtn.IconRightZoom = 0D;
            this.dashBoardbtn.IconVisible = true;
            this.dashBoardbtn.IconZoom = 70D;
            this.dashBoardbtn.IsTab = true;
            this.dashBoardbtn.Location = new System.Drawing.Point(0, 161);
            this.dashBoardbtn.Name = "dashBoardbtn";
            this.dashBoardbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.dashBoardbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.dashBoardbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.dashBoardbtn.selected = false;
            this.dashBoardbtn.Size = new System.Drawing.Size(246, 43);
            this.dashBoardbtn.TabIndex = 2;
            this.dashBoardbtn.Text = "     Dashboard";
            this.dashBoardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoardbtn.Textcolor = System.Drawing.Color.White;
            this.dashBoardbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardbtn.Click += new System.EventHandler(this.dashBoardbtn_Click);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = global::projectTemp.Properties.Resources.menuButton;
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(194, 17);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(29, 25);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // systemLogo
            // 
            this.systemLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.systemLogo, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.systemLogo, BunifuAnimatorNS.DecorationType.None);
            this.systemLogo.Image = global::projectTemp.Properties.Resources.icon;
            this.systemLogo.Location = new System.Drawing.Point(70, 24);
            this.systemLogo.Name = "systemLogo";
            this.systemLogo.Size = new System.Drawing.Size(96, 76);
            this.systemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.systemLogo.TabIndex = 0;
            this.systemLogo.TabStop = false;
            this.systemLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panelMenu;
            this.bunifuDragControl3.Vertical = true;
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.panelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.panelTransition.DefaultAnimation = animation1;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.sideMenu.Controls.Add(this.showBtn);
            this.sideMenu.Controls.Add(this.hideBtn);
            this.sideMenu.Controls.Add(this.exitLbl);
            this.sideMenu.Controls.Add(this.logOutLbl);
            this.sideMenu.Controls.Add(this.exitBtn);
            this.sideMenu.Controls.Add(this.logOutBtn);
            this.logoTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideMenu.Location = new System.Drawing.Point(726, 46);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(174, 609);
            this.sideMenu.TabIndex = 30;
            this.sideMenu.Visible = false;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.showBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.showBtn, BunifuAnimatorNS.DecorationType.None);
            this.showBtn.Image = global::projectTemp.Properties.Resources.play2;
            this.showBtn.ImageActive = null;
            this.showBtn.Location = new System.Drawing.Point(1, 276);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(32, 39);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showBtn.TabIndex = 5;
            this.showBtn.TabStop = false;
            this.showBtn.Visible = false;
            this.showBtn.Zoom = 10;
            this.showBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showBtn_MouseClick);
            this.showBtn.MouseHover += new System.EventHandler(this.showBtn_MouseHover);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.hideBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.hideBtn, BunifuAnimatorNS.DecorationType.None);
            this.hideBtn.Image = global::projectTemp.Properties.Resources.play_button;
            this.hideBtn.ImageActive = null;
            this.hideBtn.Location = new System.Drawing.Point(1, 276);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(32, 39);
            this.hideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideBtn.TabIndex = 4;
            this.hideBtn.TabStop = false;
            this.hideBtn.Zoom = 10;
            this.hideBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hideBtn_MouseClick);
            this.hideBtn.MouseHover += new System.EventHandler(this.hideBtn_MouseHover);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.panelTransition.SetDecoration(this.exitLbl, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.exitLbl, BunifuAnimatorNS.DecorationType.None);
            this.exitLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLbl.Location = new System.Drawing.Point(71, 393);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(62, 33);
            this.exitLbl.TabIndex = 3;
            this.exitLbl.Text = "EXIT";
            this.exitLbl.Visible = false;
            // 
            // logOutLbl
            // 
            this.logOutLbl.AutoSize = true;
            this.panelTransition.SetDecoration(this.logOutLbl, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.logOutLbl, BunifuAnimatorNS.DecorationType.None);
            this.logOutLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLbl.Location = new System.Drawing.Point(38, 166);
            this.logOutLbl.Name = "logOutLbl";
            this.logOutLbl.Size = new System.Drawing.Size(134, 33);
            this.logOutLbl.TabIndex = 2;
            this.logOutLbl.Text = "LOG-OUT";
            this.logOutLbl.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.exitBtn.Image = global::projectTemp.Properties.Resources.cancel;
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(39, 300);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 88);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 6;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.logOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.logOutBtn, BunifuAnimatorNS.DecorationType.None);
            this.logOutBtn.Image = global::projectTemp.Properties.Resources.logout;
            this.logOutBtn.ImageActive = null;
            this.logOutBtn.Location = new System.Drawing.Point(41, 201);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(127, 90);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Zoom = 10;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            this.logOutBtn.MouseLeave += new System.EventHandler(this.logOutBtn_MouseLeave);
            this.logOutBtn.MouseHover += new System.EventHandler(this.logOutBtn_MouseHover);
            // 
            // participants1
            // 
            this.participants1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.participants1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.participants1, BunifuAnimatorNS.DecorationType.None);
            this.participants1.Location = new System.Drawing.Point(245, 46);
            this.participants1.Name = "participants1";
            this.participants1.Size = new System.Drawing.Size(655, 609);
            this.participants1.TabIndex = 33;
            // 
            // payment1
            // 
            this.payment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.payment1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.payment1, BunifuAnimatorNS.DecorationType.None);
            this.payment1.Location = new System.Drawing.Point(245, 46);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(655, 609);
            this.payment1.TabIndex = 32;
            // 
            // registration1
            // 
            this.registration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.registration1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.registration1, BunifuAnimatorNS.DecorationType.None);
            this.registration1.Location = new System.Drawing.Point(245, 46);
            this.registration1.Name = "registration1";
            this.registration1.Size = new System.Drawing.Size(655, 609);
            this.registration1.TabIndex = 31;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.dashboard1.Location = new System.Drawing.Point(245, 46);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(655, 609);
            this.dashboard1.TabIndex = 10;
            // 
            // monitorEvent1
            // 
            this.monitorEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.monitorEvent1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.monitorEvent1, BunifuAnimatorNS.DecorationType.None);
            this.monitorEvent1.Location = new System.Drawing.Point(245, 46);
            this.monitorEvent1.Name = "monitorEvent1";
            this.monitorEvent1.Size = new System.Drawing.Size(655, 609);
            this.monitorEvent1.TabIndex = 9;
            // 
            // addEvent1
            // 
            this.addEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.addEvent1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.addEvent1, BunifuAnimatorNS.DecorationType.None);
            this.addEvent1.Location = new System.Drawing.Point(245, 46);
            this.addEvent1.Name = "addEvent1";
            this.addEvent1.Size = new System.Drawing.Size(655, 609);
            this.addEvent1.TabIndex = 8;
            // 
            // systemLogs1
            // 
            this.systemLogs1.AutoSize = true;
            this.systemLogs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.systemLogs1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.systemLogs1, BunifuAnimatorNS.DecorationType.None);
            this.systemLogs1.Location = new System.Drawing.Point(245, 46);
            this.systemLogs1.Name = "systemLogs1";
            this.systemLogs1.Size = new System.Drawing.Size(655, 609);
            this.systemLogs1.TabIndex = 7;
            // 
            // announcementUserControl1
            // 
            this.announcementUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.announcementUserControl1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.announcementUserControl1, BunifuAnimatorNS.DecorationType.None);
            this.announcementUserControl1.Location = new System.Drawing.Point(245, 46);
            this.announcementUserControl1.Name = "announcementUserControl1";
            this.announcementUserControl1.Size = new System.Drawing.Size(655, 609);
            this.announcementUserControl1.TabIndex = 6;
            // 
            // ticketscanner1
            // 
            this.ticketscanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelTransition.SetDecoration(this.ticketscanner1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.ticketscanner1, BunifuAnimatorNS.DecorationType.None);
            this.ticketscanner1.Location = new System.Drawing.Point(245, 46);
            this.ticketscanner1.Name = "ticketscanner1";
            this.ticketscanner1.Size = new System.Drawing.Size(655, 609);
            this.ticketscanner1.TabIndex = 34;
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.logoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation2;
            // 
            // mainMenu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(900, 655);
            this.Controls.Add(this.ticketscanner1);
            this.Controls.Add(this.participants1);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.registration1);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.monitorEvent1);
            this.Controls.Add(this.addEvent1);
            this.Controls.Add(this.systemLogs1);
            this.Controls.Add(this.announcementUserControl1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainMenu_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallSystemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLogo)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel close;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.PictureBox systemLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuFlatButton dashBoardbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private System.Windows.Forms.PictureBox smallSystemLogo;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
        public Bunifu.Framework.UI.BunifuFlatButton participantBtn;
        public Bunifu.Framework.UI.BunifuFlatButton tickVouchbtn;
        public Bunifu.Framework.UI.BunifuFlatButton paymentBtn;
        public Bunifu.Framework.UI.BunifuFlatButton monitorEventbtn;
        public Bunifu.Framework.UI.BunifuFlatButton addEventbtn;
        public Bunifu.Framework.UI.BunifuFlatButton systemLogsBtn;
        public Bunifu.Framework.UI.BunifuFlatButton announcementBtn;
        private Forms.announcementUserControl announcementUserControl1;
        private User_Control.systemLogs systemLogs1;
        private User_Control.addEvent addEvent1;
        private User_Control.monitorEvent monitorEvent1;
        private dashboard dashboard1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuImageButton showBtn;
        private Bunifu.Framework.UI.BunifuImageButton hideBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel exitLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel logOutLbl;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuImageButton logOutBtn;
        private System.Windows.Forms.Label wlcmLbl;
        public Bunifu.Framework.UI.BunifuFlatButton regiBtn;
        private registration registration1;
        private payment payment1;
        private participants participants1;
        private ticketscanner ticketscanner1;
    }
}