namespace projectTemp
{
    partial class signUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lastNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.genderGroup = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ageTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contactNumTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.houseNumTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.streetNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.brgyTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cityTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.uNametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passWordtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adminIDTxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.submitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.showBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.hideBtn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.showBtn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.genderGroup.SuspendLayout();
            this.address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNameTxt.ForeColor = System.Drawing.Color.White;
            this.lastNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.lastNameTxt.HintText = "";
            this.lastNameTxt.isPassword = false;
            this.lastNameTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.lastNameTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.lastNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.lastNameTxt.LineThickness = 3;
            this.lastNameTxt.Location = new System.Drawing.Point(201, 52);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(198, 33);
            this.lastNameTxt.TabIndex = 1;
            this.lastNameTxt.Text = "Last Name";
            this.lastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastNameTxt.Enter += new System.EventHandler(this.lastNameTxt_Enter);
            this.lastNameTxt.Leave += new System.EventHandler(this.lastNameTxt_Leave);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstNameTxt.ForeColor = System.Drawing.Color.White;
            this.firstNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.firstNameTxt.HintText = "";
            this.firstNameTxt.isPassword = false;
            this.firstNameTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.firstNameTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.firstNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.firstNameTxt.LineThickness = 3;
            this.firstNameTxt.Location = new System.Drawing.Point(412, 52);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(198, 33);
            this.firstNameTxt.TabIndex = 2;
            this.firstNameTxt.Text = "First Name";
            this.firstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstNameTxt.Enter += new System.EventHandler(this.firstNameTxt_Enter);
            this.firstNameTxt.Leave += new System.EventHandler(this.firstNameTxt_Leave);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.White;
            this.male.Location = new System.Drawing.Point(58, 38);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(57, 21);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.White;
            this.female.Location = new System.Drawing.Point(142, 37);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 21);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // genderGroup
            // 
            this.genderGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.genderGroup.BorderRadius = 5;
            this.genderGroup.BottomSahddow = true;
            this.genderGroup.color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.genderGroup.Controls.Add(this.bunifuCustomLabel1);
            this.genderGroup.Controls.Add(this.male);
            this.genderGroup.Controls.Add(this.female);
            this.genderGroup.LeftSahddow = true;
            this.genderGroup.Location = new System.Drawing.Point(35, 104);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.RightSahddow = true;
            this.genderGroup.ShadowDepth = 20;
            this.genderGroup.Size = new System.Drawing.Size(264, 74);
            this.genderGroup.TabIndex = 17;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Gender";
            // 
            // ageTxt
            // 
            this.ageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ageTxt.ForeColor = System.Drawing.Color.White;
            this.ageTxt.HintForeColor = System.Drawing.Color.Empty;
            this.ageTxt.HintText = "";
            this.ageTxt.isPassword = false;
            this.ageTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ageTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ageTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ageTxt.LineThickness = 3;
            this.ageTxt.Location = new System.Drawing.Point(351, 139);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(66, 33);
            this.ageTxt.TabIndex = 5;
            this.ageTxt.Text = "Age";
            this.ageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ageTxt.Enter += new System.EventHandler(this.ageTxt_Enter);
            this.ageTxt.Leave += new System.EventHandler(this.ageTxt_Leave);
            // 
            // contactNumTxt
            // 
            this.contactNumTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNumTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactNumTxt.ForeColor = System.Drawing.Color.White;
            this.contactNumTxt.HintForeColor = System.Drawing.Color.Empty;
            this.contactNumTxt.HintText = "";
            this.contactNumTxt.isPassword = false;
            this.contactNumTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.contactNumTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.contactNumTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.contactNumTxt.LineThickness = 3;
            this.contactNumTxt.Location = new System.Drawing.Point(465, 139);
            this.contactNumTxt.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumTxt.Name = "contactNumTxt";
            this.contactNumTxt.Size = new System.Drawing.Size(145, 33);
            this.contactNumTxt.TabIndex = 6;
            this.contactNumTxt.Text = "Contact Number";
            this.contactNumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNumTxt.Enter += new System.EventHandler(this.contactNumTxt_Enter);
            this.contactNumTxt.Leave += new System.EventHandler(this.contactNumTxt_Leave);
            // 
            // houseNumTxt
            // 
            this.houseNumTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.houseNumTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.houseNumTxt.ForeColor = System.Drawing.Color.White;
            this.houseNumTxt.HintForeColor = System.Drawing.Color.Empty;
            this.houseNumTxt.HintText = "";
            this.houseNumTxt.isPassword = false;
            this.houseNumTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.houseNumTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.houseNumTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.houseNumTxt.LineThickness = 3;
            this.houseNumTxt.Location = new System.Drawing.Point(50, 222);
            this.houseNumTxt.Margin = new System.Windows.Forms.Padding(4);
            this.houseNumTxt.Name = "houseNumTxt";
            this.houseNumTxt.Size = new System.Drawing.Size(101, 33);
            this.houseNumTxt.TabIndex = 7;
            this.houseNumTxt.Text = "House No";
            this.houseNumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.houseNumTxt.Enter += new System.EventHandler(this.houseNumTxt_Enter);
            this.houseNumTxt.Leave += new System.EventHandler(this.houseNumTxt_Leave);
            // 
            // streetNameTxt
            // 
            this.streetNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.streetNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.streetNameTxt.ForeColor = System.Drawing.Color.White;
            this.streetNameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.streetNameTxt.HintText = "";
            this.streetNameTxt.isPassword = false;
            this.streetNameTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.streetNameTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.streetNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.streetNameTxt.LineThickness = 3;
            this.streetNameTxt.Location = new System.Drawing.Point(175, 222);
            this.streetNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.streetNameTxt.Name = "streetNameTxt";
            this.streetNameTxt.Size = new System.Drawing.Size(141, 33);
            this.streetNameTxt.TabIndex = 8;
            this.streetNameTxt.Text = "Street Name";
            this.streetNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.streetNameTxt.Enter += new System.EventHandler(this.streetNameTxt_Enter);
            this.streetNameTxt.Leave += new System.EventHandler(this.streetNameTxt_Leave);
            // 
            // brgyTxt
            // 
            this.brgyTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brgyTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brgyTxt.ForeColor = System.Drawing.Color.White;
            this.brgyTxt.HintForeColor = System.Drawing.Color.Empty;
            this.brgyTxt.HintText = "";
            this.brgyTxt.isPassword = false;
            this.brgyTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.brgyTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.brgyTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.brgyTxt.LineThickness = 3;
            this.brgyTxt.Location = new System.Drawing.Point(340, 222);
            this.brgyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.brgyTxt.Name = "brgyTxt";
            this.brgyTxt.Size = new System.Drawing.Size(128, 33);
            this.brgyTxt.TabIndex = 9;
            this.brgyTxt.Text = "Barangay";
            this.brgyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brgyTxt.Enter += new System.EventHandler(this.brgyTxt_Enter);
            this.brgyTxt.Leave += new System.EventHandler(this.brgyTxt_Leave);
            // 
            // cityTxt
            // 
            this.cityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cityTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cityTxt.ForeColor = System.Drawing.Color.White;
            this.cityTxt.HintForeColor = System.Drawing.Color.Empty;
            this.cityTxt.HintText = "";
            this.cityTxt.isPassword = false;
            this.cityTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.cityTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.cityTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.cityTxt.LineThickness = 3;
            this.cityTxt.Location = new System.Drawing.Point(455, 29);
            this.cityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(120, 33);
            this.cityTxt.TabIndex = 10;
            this.cityTxt.Text = "City";
            this.cityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cityTxt.Enter += new System.EventHandler(this.cityTxt_Enter);
            this.cityTxt.Leave += new System.EventHandler(this.cityTxt_Leave);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.address.BorderRadius = 15;
            this.address.BottomSahddow = true;
            this.address.color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.address.Controls.Add(this.bunifuCustomLabel2);
            this.address.Controls.Add(this.cityTxt);
            this.address.LeftSahddow = true;
            this.address.Location = new System.Drawing.Point(35, 193);
            this.address.Name = "address";
            this.address.RightSahddow = true;
            this.address.ShadowDepth = 20;
            this.address.Size = new System.Drawing.Size(586, 91);
            this.address.TabIndex = 20;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "e-Ventory Sign-Up";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(35, 60);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(25, 17);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "ID:";
            // 
            // uNametxt
            // 
            this.uNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uNametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uNametxt.ForeColor = System.Drawing.Color.White;
            this.uNametxt.HintForeColor = System.Drawing.Color.Empty;
            this.uNametxt.HintText = "";
            this.uNametxt.isPassword = false;
            this.uNametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.uNametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.uNametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.uNametxt.LineThickness = 3;
            this.uNametxt.Location = new System.Drawing.Point(41, 345);
            this.uNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.uNametxt.Name = "uNametxt";
            this.uNametxt.Size = new System.Drawing.Size(195, 33);
            this.uNametxt.TabIndex = 13;
            this.uNametxt.Text = "Username";
            this.uNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uNametxt.Enter += new System.EventHandler(this.uNametxt_Enter);
            this.uNametxt.Leave += new System.EventHandler(this.uNametxt_Leave);
            // 
            // passWordtxt
            // 
            this.passWordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passWordtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passWordtxt.ForeColor = System.Drawing.Color.White;
            this.passWordtxt.HintForeColor = System.Drawing.Color.Empty;
            this.passWordtxt.HintText = "";
            this.passWordtxt.isPassword = false;
            this.passWordtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.passWordtxt.LineThickness = 3;
            this.passWordtxt.Location = new System.Drawing.Point(258, 345);
            this.passWordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passWordtxt.Name = "passWordtxt";
            this.passWordtxt.Size = new System.Drawing.Size(147, 33);
            this.passWordtxt.TabIndex = 14;
            this.passWordtxt.Text = "Password";
            this.passWordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWordtxt.Enter += new System.EventHandler(this.passWtxt_Enter);
            this.passWordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWordtxt_KeyDown);
            this.passWordtxt.Leave += new System.EventHandler(this.passWtxt_Leave);
            // 
            // adminIDTxt
            // 
            this.adminIDTxt.AutoSize = true;
            this.adminIDTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.adminIDTxt.Location = new System.Drawing.Point(61, 55);
            this.adminIDTxt.Name = "adminIDTxt";
            this.adminIDTxt.Size = new System.Drawing.Size(0, 23);
            this.adminIDTxt.TabIndex = 16;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = global::projectTemp.Properties.Resources.backButton;
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(608, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(30, 37);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 0;
            this.backBtn.TabStop = false;
            this.backBtn.Zoom = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitButton
            // 
            this.submitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitButton.BorderRadius = 0;
            this.submitButton.ButtonText = "  Submit";
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.DisabledColor = System.Drawing.Color.Gray;
            this.submitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.submitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("submitButton.Iconimage")));
            this.submitButton.Iconimage_right = null;
            this.submitButton.Iconimage_right_Selected = null;
            this.submitButton.Iconimage_Selected = null;
            this.submitButton.IconMarginLeft = 18;
            this.submitButton.IconMarginRight = 0;
            this.submitButton.IconRightVisible = false;
            this.submitButton.IconRightZoom = 0D;
            this.submitButton.IconVisible = true;
            this.submitButton.IconZoom = 60D;
            this.submitButton.IsTab = false;
            this.submitButton.Location = new System.Drawing.Point(463, 330);
            this.submitButton.Name = "submitButton";
            this.submitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.submitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.submitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.submitButton.selected = false;
            this.submitButton.Size = new System.Drawing.Size(147, 45);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "  Submit";
            this.submitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitButton.Textcolor = System.Drawing.Color.White;
            this.submitButton.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // fbPassword
            // 
            this.fbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fbPassword.ForeColor = System.Drawing.Color.White;
            this.fbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.fbPassword.HintText = "";
            this.fbPassword.isPassword = false;
            this.fbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbPassword.LineThickness = 3;
            this.fbPassword.Location = new System.Drawing.Point(258, 294);
            this.fbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.Size = new System.Drawing.Size(146, 33);
            this.fbPassword.TabIndex = 12;
            this.fbPassword.Text = "FB Password";
            this.fbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fbPassword.Enter += new System.EventHandler(this.fbPassword_Enter);
            this.fbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fbPassword_KeyDown);
            this.fbPassword.Leave += new System.EventHandler(this.fbPassword_Leave);
            // 
            // fbUsername
            // 
            this.fbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fbUsername.ForeColor = System.Drawing.Color.White;
            this.fbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.fbUsername.HintText = "";
            this.fbUsername.isPassword = false;
            this.fbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.fbUsername.LineThickness = 3;
            this.fbUsername.Location = new System.Drawing.Point(41, 295);
            this.fbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.fbUsername.Name = "fbUsername";
            this.fbUsername.Size = new System.Drawing.Size(195, 33);
            this.fbUsername.TabIndex = 11;
            this.fbUsername.Text = "Facebook Username";
            this.fbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fbUsername.Enter += new System.EventHandler(this.fbUsername_Enter);
            this.fbUsername.Leave += new System.EventHandler(this.fbUsername_Leave);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Transparent;
            this.hideBtn.Image = global::projectTemp.Properties.Resources.hide__1_;
            this.hideBtn.ImageActive = null;
            this.hideBtn.Location = new System.Drawing.Point(408, 284);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(30, 35);
            this.hideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideBtn.TabIndex = 21;
            this.hideBtn.TabStop = false;
            this.hideBtn.Visible = false;
            this.hideBtn.Zoom = 10;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.Transparent;
            this.showBtn.Image = global::projectTemp.Properties.Resources.view__1_;
            this.showBtn.ImageActive = null;
            this.showBtn.Location = new System.Drawing.Point(408, 284);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(30, 35);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showBtn.TabIndex = 20;
            this.showBtn.TabStop = false;
            this.showBtn.Visible = false;
            this.showBtn.Zoom = 10;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(404, 308);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(36, 35);
            this.bunifuSeparator2.TabIndex = 19;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // hideBtn1
            // 
            this.hideBtn1.BackColor = System.Drawing.Color.Transparent;
            this.hideBtn1.Image = global::projectTemp.Properties.Resources.hide__1_;
            this.hideBtn1.ImageActive = null;
            this.hideBtn1.Location = new System.Drawing.Point(409, 335);
            this.hideBtn1.Name = "hideBtn1";
            this.hideBtn1.Size = new System.Drawing.Size(30, 35);
            this.hideBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideBtn1.TabIndex = 25;
            this.hideBtn1.TabStop = false;
            this.hideBtn1.Visible = false;
            this.hideBtn1.Zoom = 10;
            this.hideBtn1.Click += new System.EventHandler(this.hideBtn1_Click);
            // 
            // showBtn1
            // 
            this.showBtn1.BackColor = System.Drawing.Color.Transparent;
            this.showBtn1.Image = global::projectTemp.Properties.Resources.view__1_;
            this.showBtn1.ImageActive = null;
            this.showBtn1.Location = new System.Drawing.Point(409, 335);
            this.showBtn1.Name = "showBtn1";
            this.showBtn1.Size = new System.Drawing.Size(30, 35);
            this.showBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showBtn1.TabIndex = 24;
            this.showBtn1.TabStop = false;
            this.showBtn1.Visible = false;
            this.showBtn1.Zoom = 10;
            this.showBtn1.Click += new System.EventHandler(this.showBtn1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(405, 359);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(36, 35);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // signUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(650, 402);
            this.Controls.Add(this.hideBtn1);
            this.Controls.Add(this.showBtn1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.fbPassword);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.fbUsername);
            this.Controls.Add(this.adminIDTxt);
            this.Controls.Add(this.passWordtxt);
            this.Controls.Add(this.uNametxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.brgyTxt);
            this.Controls.Add(this.streetNameTxt);
            this.Controls.Add(this.houseNumTxt);
            this.Controls.Add(this.contactNumTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.genderGroup);
            this.Controls.Add(this.address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUp_Form";
            this.genderGroup.ResumeLayout(false);
            this.genderGroup.PerformLayout();
            this.address.ResumeLayout(false);
            this.address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastNameTxt;
        private Bunifu.Framework.UI.BunifuFlatButton submitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox brgyTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox streetNameTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox houseNumTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactNumTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstNameTxt;
        private Bunifu.Framework.UI.BunifuCards genderGroup;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private Bunifu.Framework.UI.BunifuCards address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cityTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton backBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passWordtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uNametxt;
        private Bunifu.Framework.UI.BunifuCustomLabel adminIDTxt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fbUsername;
        private Bunifu.Framework.UI.BunifuImageButton hideBtn;
        private Bunifu.Framework.UI.BunifuImageButton showBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton hideBtn1;
        private Bunifu.Framework.UI.BunifuImageButton showBtn1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}