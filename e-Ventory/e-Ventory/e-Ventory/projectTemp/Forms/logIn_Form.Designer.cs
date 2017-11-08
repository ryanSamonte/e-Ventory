namespace projectTemp
{
    partial class logIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn_Form));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logInBtn = new System.Windows.Forms.Button();
            this.hideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.showBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.signUpbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passWordtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userNametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.minimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.form_FadeTimer = new System.Windows.Forms.Timer(this.components);
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.smallLabelTrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = global::projectTemp.Properties.Resources.systemLogo;
            this.smallLabelTrans.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 402);
            this.panel2.TabIndex = 6;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.logInBtn);
            this.panel1.Controls.Add(this.hideBtn);
            this.panel1.Controls.Add(this.showBtn);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.signUpbtn);
            this.panel1.Controls.Add(this.passWordtxt);
            this.panel1.Controls.Add(this.userNametxt);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.smallLabelTrans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(328, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 402);
            this.panel1.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.panelAnimator.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(29, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 16);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.panelAnimator.SetDecoration(this.lblUsername, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.lblUsername, BunifuAnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(29, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 16);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.panelAnimator.SetDecoration(this.logInBtn, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.logInBtn, BunifuAnimatorNS.DecorationType.None);
            this.logInBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.logInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.logInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.logInBtn.Location = new System.Drawing.Point(78, 276);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(171, 47);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "Log-in";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Transparent;
            this.smallLabelTrans.SetDecoration(this.hideBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.hideBtn, BunifuAnimatorNS.DecorationType.None);
            this.hideBtn.Image = global::projectTemp.Properties.Resources.hide__1_;
            this.hideBtn.ImageActive = null;
            this.hideBtn.Location = new System.Drawing.Point(256, 194);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(30, 35);
            this.hideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideBtn.TabIndex = 13;
            this.hideBtn.TabStop = false;
            this.hideBtn.Visible = false;
            this.hideBtn.Zoom = 10;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.Transparent;
            this.smallLabelTrans.SetDecoration(this.showBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.showBtn, BunifuAnimatorNS.DecorationType.None);
            this.showBtn.Image = global::projectTemp.Properties.Resources.view__1_;
            this.showBtn.ImageActive = null;
            this.showBtn.Location = new System.Drawing.Point(256, 194);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(30, 35);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showBtn.TabIndex = 12;
            this.showBtn.TabStop = false;
            this.showBtn.Visible = false;
            this.showBtn.Zoom = 10;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.smallLabelTrans.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(249, 215);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(44, 35);
            this.bunifuSeparator2.TabIndex = 11;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox1
            // 
            this.panelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::projectTemp.Properties.Resources.loginIcon;
            this.pictureBox1.Location = new System.Drawing.Point(115, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.smallLabelTrans.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-29, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(62, 271);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // signUpbtn
            // 
            this.signUpbtn.ActiveBorderThickness = 1;
            this.signUpbtn.ActiveCornerRadius = 20;
            this.signUpbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.signUpbtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.signUpbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.signUpbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.signUpbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpbtn.BackgroundImage")));
            this.signUpbtn.ButtonText = "Sign-up";
            this.signUpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smallLabelTrans.SetDecoration(this.signUpbtn, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.signUpbtn, BunifuAnimatorNS.DecorationType.None);
            this.signUpbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUpbtn.IdleBorderThickness = 1;
            this.signUpbtn.IdleCornerRadius = 20;
            this.signUpbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.signUpbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.signUpbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.signUpbtn.Location = new System.Drawing.Point(115, 330);
            this.signUpbtn.Margin = new System.Windows.Forms.Padding(5);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(99, 41);
            this.signUpbtn.TabIndex = 4;
            this.signUpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click_1);
            // 
            // passWordtxt
            // 
            this.passWordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smallLabelTrans.SetDecoration(this.passWordtxt, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.passWordtxt, BunifuAnimatorNS.DecorationType.None);
            this.passWordtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passWordtxt.ForeColor = System.Drawing.Color.White;
            this.passWordtxt.HintForeColor = System.Drawing.Color.Empty;
            this.passWordtxt.HintText = "";
            this.passWordtxt.isPassword = false;
            this.passWordtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineThickness = 3;
            this.passWordtxt.Location = new System.Drawing.Point(29, 201);
            this.passWordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passWordtxt.Name = "passWordtxt";
            this.passWordtxt.Size = new System.Drawing.Size(220, 33);
            this.passWordtxt.TabIndex = 1;
            this.passWordtxt.Text = "Password";
            this.passWordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWordtxt.Enter += new System.EventHandler(this.passWordtxt_Enter_1);
            this.passWordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWordtxt_KeyDown);
            this.passWordtxt.Leave += new System.EventHandler(this.passWordtxt_Leave_1);
            // 
            // userNametxt
            // 
            this.userNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smallLabelTrans.SetDecoration(this.userNametxt, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.userNametxt, BunifuAnimatorNS.DecorationType.None);
            this.userNametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userNametxt.ForeColor = System.Drawing.Color.White;
            this.userNametxt.HintForeColor = System.Drawing.Color.Empty;
            this.userNametxt.HintText = "";
            this.userNametxt.isPassword = false;
            this.userNametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.userNametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.userNametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.userNametxt.LineThickness = 3;
            this.userNametxt.Location = new System.Drawing.Point(29, 119);
            this.userNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.userNametxt.Name = "userNametxt";
            this.userNametxt.Size = new System.Drawing.Size(264, 33);
            this.userNametxt.TabIndex = 0;
            this.userNametxt.Text = "Username";
            this.userNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNametxt.Enter += new System.EventHandler(this.userNametxt_Enter_1);
            this.userNametxt.Leave += new System.EventHandler(this.userNametxt_Leave_1);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelAnimator.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.minimize.Location = new System.Drawing.Point(252, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 31);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelAnimator.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.smallLabelTrans.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.close.Location = new System.Drawing.Point(280, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 39);
            this.close.TabIndex = 7;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click_1);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave_1);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover_1);
            // 
            // form_FadeTimer
            // 
            this.form_FadeTimer.Tick += new System.EventHandler(this.form_FadeTimer_Tick);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation1;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = null;
            this.bunifuDragControl3.Vertical = true;
            // 
            // smallLabelTrans
            // 
            this.smallLabelTrans.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.smallLabelTrans.Cursor = null;
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
            this.smallLabelTrans.DefaultAnimation = animation2;
            this.smallLabelTrans.TimeStep = 0.05F;
            // 
            // logIn_Form
            // 
            this.AcceptButton = this.logInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.smallLabelTrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logIn_Form";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.logIn_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer form_FadeTimer;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel minimize;
        private Bunifu.Framework.UI.BunifuCustomLabel close;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passWordtxt;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpbtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton showBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton hideBtn;
        private System.Windows.Forms.Button logInBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private BunifuAnimatorNS.BunifuTransition smallLabelTrans;
    }
}

