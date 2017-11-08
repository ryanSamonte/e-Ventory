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
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.submitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.genderGroup.SuspendLayout();
            this.address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
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
            this.lastNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lastNameTxt.LineThickness = 3;
            this.lastNameTxt.Location = new System.Drawing.Point(35, 81);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(264, 33);
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
            this.firstNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.firstNameTxt.LineThickness = 3;
            this.firstNameTxt.Location = new System.Drawing.Point(346, 81);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(264, 33);
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
            this.genderGroup.Location = new System.Drawing.Point(35, 133);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.RightSahddow = true;
            this.genderGroup.ShadowDepth = 20;
            this.genderGroup.Size = new System.Drawing.Size(264, 74);
            this.genderGroup.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel1.TabIndex = 5;
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
            this.ageTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ageTxt.LineThickness = 3;
            this.ageTxt.Location = new System.Drawing.Point(351, 168);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(66, 33);
            this.ageTxt.TabIndex = 6;
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
            this.contactNumTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.contactNumTxt.LineThickness = 3;
            this.contactNumTxt.Location = new System.Drawing.Point(465, 168);
            this.contactNumTxt.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumTxt.Name = "contactNumTxt";
            this.contactNumTxt.Size = new System.Drawing.Size(145, 33);
            this.contactNumTxt.TabIndex = 7;
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
            this.houseNumTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.houseNumTxt.LineThickness = 3;
            this.houseNumTxt.Location = new System.Drawing.Point(50, 251);
            this.houseNumTxt.Margin = new System.Windows.Forms.Padding(4);
            this.houseNumTxt.Name = "houseNumTxt";
            this.houseNumTxt.Size = new System.Drawing.Size(101, 33);
            this.houseNumTxt.TabIndex = 8;
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
            this.streetNameTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.streetNameTxt.LineThickness = 3;
            this.streetNameTxt.Location = new System.Drawing.Point(175, 251);
            this.streetNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.streetNameTxt.Name = "streetNameTxt";
            this.streetNameTxt.Size = new System.Drawing.Size(141, 33);
            this.streetNameTxt.TabIndex = 9;
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
            this.brgyTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.brgyTxt.LineThickness = 3;
            this.brgyTxt.Location = new System.Drawing.Point(340, 251);
            this.brgyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.brgyTxt.Name = "brgyTxt";
            this.brgyTxt.Size = new System.Drawing.Size(128, 33);
            this.brgyTxt.TabIndex = 10;
            this.brgyTxt.Text = "Barangay";
            this.brgyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.cityTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cityTxt.LineThickness = 3;
            this.cityTxt.Location = new System.Drawing.Point(455, 29);
            this.cityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(120, 33);
            this.cityTxt.TabIndex = 11;
            this.cityTxt.Text = "City";
            this.cityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.address.Location = new System.Drawing.Point(35, 222);
            this.address.Name = "address";
            this.address.RightSahddow = true;
            this.address.ShadowDepth = 20;
            this.address.Size = new System.Drawing.Size(586, 91);
            this.address.TabIndex = 12;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "e-Ventory Sign-Up";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = global::projectTemp.Properties.Resources.backButton;
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(607, 13);
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
            this.submitButton.Location = new System.Drawing.Point(250, 319);
            this.submitButton.Name = "submitButton";
            this.submitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.submitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.submitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.submitButton.selected = false;
            this.submitButton.Size = new System.Drawing.Size(149, 45);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "  Submit";
            this.submitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitButton.Textcolor = System.Drawing.Color.White;
            this.submitButton.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // signUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(650, 402);
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
            this.Name = "signUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUp_Form";
            this.genderGroup.ResumeLayout(false);
            this.genderGroup.PerformLayout();
            this.address.ResumeLayout(false);
            this.address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
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
    }
}