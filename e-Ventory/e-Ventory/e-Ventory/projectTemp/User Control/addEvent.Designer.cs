namespace projectTemp.User_Control
{
    partial class addEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEvent));
            this.eventNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.eventCodeTxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.eventDescTxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.venueTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateFinish = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hrStart = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minStart = new System.Windows.Forms.TextBox();
            this.minFinish = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hrFinish = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.capacityTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.priceTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.freeChkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fbGrpIdTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // eventNameTxt
            // 
            this.eventNameTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.eventNameTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.eventNameTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.eventNameTxt.BorderThickness = 3;
            this.eventNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.eventNameTxt.ForeColor = System.Drawing.Color.Black;
            this.eventNameTxt.isPassword = false;
            this.eventNameTxt.Location = new System.Drawing.Point(16, 105);
            this.eventNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.eventNameTxt.Name = "eventNameTxt";
            this.eventNameTxt.Size = new System.Drawing.Size(286, 41);
            this.eventNameTxt.TabIndex = 1;
            this.eventNameTxt.Text = "Event Name";
            this.eventNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eventNameTxt.Enter += new System.EventHandler(this.eventNameTxt_Enter);
            this.eventNameTxt.Leave += new System.EventHandler(this.eventNameTxt_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Event Code:";
            // 
            // eventCodeTxt
            // 
            this.eventCodeTxt.AutoSize = true;
            this.eventCodeTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCodeTxt.Location = new System.Drawing.Point(130, 57);
            this.eventCodeTxt.Name = "eventCodeTxt";
            this.eventCodeTxt.Size = new System.Drawing.Size(0, 21);
            this.eventCodeTxt.TabIndex = 2;
            // 
            // eventDescTxt
            // 
            this.eventDescTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.eventDescTxt.Location = new System.Drawing.Point(20, 209);
            this.eventDescTxt.Multiline = true;
            this.eventDescTxt.Name = "eventDescTxt";
            this.eventDescTxt.Size = new System.Drawing.Size(283, 132);
            this.eventDescTxt.TabIndex = 2;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(19, 185);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 21);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Description";
            // 
            // venueTxt
            // 
            this.venueTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.venueTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.venueTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.venueTxt.BorderThickness = 3;
            this.venueTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.venueTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.venueTxt.ForeColor = System.Drawing.Color.Black;
            this.venueTxt.isPassword = false;
            this.venueTxt.Location = new System.Drawing.Point(351, 45);
            this.venueTxt.Margin = new System.Windows.Forms.Padding(4);
            this.venueTxt.Name = "venueTxt";
            this.venueTxt.Size = new System.Drawing.Size(286, 41);
            this.venueTxt.TabIndex = 9;
            this.venueTxt.Text = "Venue";
            this.venueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.venueTxt.Enter += new System.EventHandler(this.venueTxt_Enter);
            this.venueTxt.Leave += new System.EventHandler(this.venueTxt_Leave);
            // 
            // dateStart
            // 
            this.dateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.dateStart.BorderRadius = 0;
            this.dateStart.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.ForeColor = System.Drawing.Color.White;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.FormatCustom = "yyyy-MM-dd";
            this.dateStart.Location = new System.Drawing.Point(11, 413);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(159, 31);
            this.dateStart.TabIndex = 3;
            this.dateStart.Value = new System.DateTime(2017, 9, 23, 0, 0, 0, 0);
            // 
            // dateFinish
            // 
            this.dateFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.dateFinish.BorderRadius = 0;
            this.dateFinish.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.ForeColor = System.Drawing.Color.White;
            this.dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinish.FormatCustom = "yyyy-MM-dd";
            this.dateFinish.Location = new System.Drawing.Point(174, 413);
            this.dateFinish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(159, 31);
            this.dateFinish.TabIndex = 4;
            this.dateFinish.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 389);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(73, 17);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Date Start";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(177, 389);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Date Finish";
            // 
            // hrStart
            // 
            this.hrStart.Location = new System.Drawing.Point(20, 516);
            this.hrStart.Name = "hrStart";
            this.hrStart.Size = new System.Drawing.Size(34, 20);
            this.hrStart.TabIndex = 5;
            this.hrStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrStart_KeyPress);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(55, 517);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(12, 17);
            this.bunifuCustomLabel6.TabIndex = 11;
            this.bunifuCustomLabel6.Text = ":";
            // 
            // minStart
            // 
            this.minStart.Location = new System.Drawing.Point(67, 517);
            this.minStart.Name = "minStart";
            this.minStart.Size = new System.Drawing.Size(34, 20);
            this.minStart.TabIndex = 6;
            this.minStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrStart_KeyPress);
            // 
            // minFinish
            // 
            this.minFinish.Location = new System.Drawing.Point(216, 518);
            this.minFinish.Name = "minFinish";
            this.minFinish.Size = new System.Drawing.Size(34, 20);
            this.minFinish.TabIndex = 8;
            this.minFinish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrStart_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(204, 518);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(12, 17);
            this.bunifuCustomLabel7.TabIndex = 15;
            this.bunifuCustomLabel7.Text = ":";
            // 
            // hrFinish
            // 
            this.hrFinish.Location = new System.Drawing.Point(169, 517);
            this.hrFinish.Name = "hrFinish";
            this.hrFinish.Size = new System.Drawing.Size(34, 20);
            this.hrFinish.TabIndex = 7;
            this.hrFinish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrStart_KeyPress);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(20, 496);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(70, 17);
            this.bunifuCustomLabel8.TabIndex = 18;
            this.bunifuCustomLabel8.Text = "Time Start";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(172, 498);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel9.TabIndex = 19;
            this.bunifuCustomLabel9.Text = "Time Finish";
            // 
            // capacityTxt
            // 
            this.capacityTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.capacityTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.capacityTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.capacityTxt.BorderThickness = 3;
            this.capacityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacityTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.capacityTxt.ForeColor = System.Drawing.Color.Black;
            this.capacityTxt.isPassword = false;
            this.capacityTxt.Location = new System.Drawing.Point(351, 132);
            this.capacityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.capacityTxt.Name = "capacityTxt";
            this.capacityTxt.Size = new System.Drawing.Size(152, 41);
            this.capacityTxt.TabIndex = 10;
            this.capacityTxt.Text = "Capacity";
            this.capacityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.capacityTxt.Enter += new System.EventHandler(this.capacityTxt_Enter);
            this.capacityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrStart_KeyPress);
            this.capacityTxt.Leave += new System.EventHandler(this.capacityTxt_Leave);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(510, 146);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel10.TabIndex = 22;
            this.bunifuCustomLabel10.Text = "participants";
            // 
            // priceTxt
            // 
            this.priceTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.priceTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.priceTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.priceTxt.BorderThickness = 3;
            this.priceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.priceTxt.ForeColor = System.Drawing.Color.Black;
            this.priceTxt.isPassword = false;
            this.priceTxt.Location = new System.Drawing.Point(351, 218);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(176, 41);
            this.priceTxt.TabIndex = 11;
            this.priceTxt.Text = "Price";
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTxt.Enter += new System.EventHandler(this.priceTxt_Enter);
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            this.priceTxt.Leave += new System.EventHandler(this.priceTxt_Leave);
            // 
            // freeChkbox
            // 
            this.freeChkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.freeChkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.freeChkbox.Checked = false;
            this.freeChkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.freeChkbox.ForeColor = System.Drawing.Color.White;
            this.freeChkbox.Location = new System.Drawing.Point(535, 230);
            this.freeChkbox.Name = "freeChkbox";
            this.freeChkbox.Size = new System.Drawing.Size(20, 20);
            this.freeChkbox.TabIndex = 13;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(561, 231);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(36, 17);
            this.bunifuCustomLabel11.TabIndex = 25;
            this.bunifuCustomLabel11.Text = "FREE";
            // 
            // fbGrpIdTxt
            // 
            this.fbGrpIdTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.fbGrpIdTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.fbGrpIdTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.fbGrpIdTxt.BorderThickness = 3;
            this.fbGrpIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fbGrpIdTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fbGrpIdTxt.ForeColor = System.Drawing.Color.Black;
            this.fbGrpIdTxt.isPassword = false;
            this.fbGrpIdTxt.Location = new System.Drawing.Point(351, 305);
            this.fbGrpIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fbGrpIdTxt.Name = "fbGrpIdTxt";
            this.fbGrpIdTxt.Size = new System.Drawing.Size(286, 41);
            this.fbGrpIdTxt.TabIndex = 12;
            this.fbGrpIdTxt.Text = "Facebook Group ID";
            this.fbGrpIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fbGrpIdTxt.Enter += new System.EventHandler(this.fbGrpIdTxt_Enter);
            this.fbGrpIdTxt.Leave += new System.EventHandler(this.fbGrpIdTxt_Leave);
            // 
            // clearBtn
            // 
            this.clearBtn.Activecolor = System.Drawing.Color.Red;
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.BorderRadius = 0;
            this.clearBtn.ButtonText = "    Clear";
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DisabledColor = System.Drawing.Color.Gray;
            this.clearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.clearBtn.Iconimage = global::projectTemp.Properties.Resources.clearButton;
            this.clearBtn.Iconimage_right = null;
            this.clearBtn.Iconimage_right_Selected = null;
            this.clearBtn.Iconimage_Selected = null;
            this.clearBtn.IconMarginLeft = 20;
            this.clearBtn.IconMarginRight = 0;
            this.clearBtn.IconRightVisible = true;
            this.clearBtn.IconRightZoom = 0D;
            this.clearBtn.IconVisible = true;
            this.clearBtn.IconZoom = 55D;
            this.clearBtn.IsTab = false;
            this.clearBtn.Location = new System.Drawing.Point(497, 489);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.Red;
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearBtn.selected = false;
            this.clearBtn.Size = new System.Drawing.Size(134, 46);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "    Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.ButtonText = "Save";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveBtn.Iconimage")));
            this.saveBtn.Iconimage_right = null;
            this.saveBtn.Iconimage_right_Selected = null;
            this.saveBtn.Iconimage_Selected = null;
            this.saveBtn.IconMarginLeft = 2;
            this.saveBtn.IconMarginRight = 0;
            this.saveBtn.IconRightVisible = true;
            this.saveBtn.IconRightZoom = 0D;
            this.saveBtn.IconVisible = true;
            this.saveBtn.IconZoom = 140D;
            this.saveBtn.IsTab = false;
            this.saveBtn.Location = new System.Drawing.Point(357, 489);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveBtn.OnHovercolor = System.Drawing.Color.Green;
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(134, 46);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fbGrpIdTxt);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.freeChkbox);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.capacityTxt);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.minFinish);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.hrFinish);
            this.Controls.Add(this.minStart);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.hrStart);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dateFinish);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.venueTxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.eventDescTxt);
            this.Controls.Add(this.eventCodeTxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.eventNameTxt);
            this.Name = "addEvent";
            this.Size = new System.Drawing.Size(655, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox eventNameTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel eventCodeTxt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox eventDescTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox venueTxt;
        private Bunifu.Framework.UI.BunifuDatepicker dateStart;
        private Bunifu.Framework.UI.BunifuDatepicker dateFinish;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox hrStart;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox minStart;
        private System.Windows.Forms.TextBox minFinish;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.TextBox hrFinish;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox capacityTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMetroTextbox priceTxt;
        private Bunifu.Framework.UI.BunifuCheckbox freeChkbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox fbGrpIdTxt;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
    }
}
