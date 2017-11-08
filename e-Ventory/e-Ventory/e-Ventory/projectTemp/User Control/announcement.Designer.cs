namespace projectTemp.Forms
{
    partial class announcementUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fbCodeLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.postBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.showBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.hideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.noResFoundLbl = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).BeginInit();
            this.SuspendLayout();
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
            this.searchTxt.Location = new System.Drawing.Point(20, 16);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(364, 42);
            this.searchTxt.TabIndex = 48;
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
            this.searchResult.Location = new System.Drawing.Point(15, 69);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.Size = new System.Drawing.Size(624, 213);
            this.searchResult.TabIndex = 47;
            this.searchResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResult_CellMouseClick);
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(328, 315);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(305, 212);
            this.messageTxt.TabIndex = 3;
            this.messageTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 506);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 21);
            this.bunifuCustomLabel1.TabIndex = 58;
            this.bunifuCustomLabel1.Text = "FB Group ID:";
            // 
            // fbCodeLbl
            // 
            this.fbCodeLbl.AutoSize = true;
            this.fbCodeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbCodeLbl.Location = new System.Drawing.Point(132, 506);
            this.fbCodeLbl.Name = "fbCodeLbl";
            this.fbCodeLbl.Size = new System.Drawing.Size(0, 21);
            this.fbCodeLbl.TabIndex = 59;
            // 
            // clearBtn
            // 
            this.clearBtn.Activecolor = System.Drawing.Color.Red;
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.BorderRadius = 0;
            this.clearBtn.ButtonText = "  Clear";
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
            this.clearBtn.Location = new System.Drawing.Point(485, 542);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.Red;
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearBtn.selected = false;
            this.clearBtn.Size = new System.Drawing.Size(135, 44);
            this.clearBtn.TabIndex = 61;
            this.clearBtn.Text = "  Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.refreshBtn.Location = new System.Drawing.Point(455, 14);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshBtn.selected = false;
            this.refreshBtn.Size = new System.Drawing.Size(134, 46);
            this.refreshBtn.TabIndex = 60;
            this.refreshBtn.Text = "  Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // postBtn
            // 
            this.postBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.postBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.postBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postBtn.BorderRadius = 0;
            this.postBtn.ButtonText = "  Post";
            this.postBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBtn.DisabledColor = System.Drawing.Color.Gray;
            this.postBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.postBtn.Iconimage = global::projectTemp.Properties.Resources.post_it__1_;
            this.postBtn.Iconimage_right = null;
            this.postBtn.Iconimage_right_Selected = null;
            this.postBtn.Iconimage_Selected = null;
            this.postBtn.IconMarginLeft = 23;
            this.postBtn.IconMarginRight = 0;
            this.postBtn.IconRightVisible = true;
            this.postBtn.IconRightZoom = 0D;
            this.postBtn.IconVisible = true;
            this.postBtn.IconZoom = 70D;
            this.postBtn.IsTab = false;
            this.postBtn.Location = new System.Drawing.Point(342, 542);
            this.postBtn.Name = "postBtn";
            this.postBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.postBtn.OnHovercolor = System.Drawing.Color.Green;
            this.postBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.postBtn.selected = false;
            this.postBtn.Size = new System.Drawing.Size(135, 44);
            this.postBtn.TabIndex = 54;
            this.postBtn.Text = "  Post";
            this.postBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postBtn.Textcolor = System.Drawing.Color.White;
            this.postBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Black;
            this.password.LineIdleColor = System.Drawing.Color.Black;
            this.password.LineMouseHoverColor = System.Drawing.Color.Black;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(24, 419);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(231, 33);
            this.password.TabIndex = 62;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // userName
            // 
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.HintForeColor = System.Drawing.Color.Empty;
            this.userName.HintText = "";
            this.userName.isPassword = false;
            this.userName.LineFocusedColor = System.Drawing.Color.Black;
            this.userName.LineIdleColor = System.Drawing.Color.Black;
            this.userName.LineMouseHoverColor = System.Drawing.Color.Black;
            this.userName.LineThickness = 3;
            this.userName.Location = new System.Drawing.Point(24, 354);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(276, 33);
            this.userName.TabIndex = 63;
            this.userName.Text = "FB Username";
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(255, 433);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(45, 35);
            this.bunifuSeparator2.TabIndex = 64;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.Transparent;
            this.showBtn.Image = global::projectTemp.Properties.Resources.view;
            this.showBtn.ImageActive = null;
            this.showBtn.Location = new System.Drawing.Point(259, 402);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(37, 37);
            this.showBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showBtn.TabIndex = 65;
            this.showBtn.TabStop = false;
            this.showBtn.Visible = false;
            this.showBtn.Zoom = 10;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Transparent;
            this.hideBtn.Image = global::projectTemp.Properties.Resources.hide;
            this.hideBtn.ImageActive = null;
            this.hideBtn.Location = new System.Drawing.Point(259, 402);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(37, 37);
            this.hideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideBtn.TabIndex = 66;
            this.hideBtn.TabStop = false;
            this.hideBtn.Visible = false;
            this.hideBtn.Zoom = 10;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // noResFoundLbl
            // 
            this.noResFoundLbl.AutoSize = true;
            this.noResFoundLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResFoundLbl.Location = new System.Drawing.Point(223, 142);
            this.noResFoundLbl.Name = "noResFoundLbl";
            this.noResFoundLbl.Size = new System.Drawing.Size(205, 88);
            this.noResFoundLbl.TabIndex = 67;
            this.noResFoundLbl.Text = "NO RESULT\r\n   FOUND";
            this.noResFoundLbl.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(27, 283);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(602, 26);
            this.bunifuSeparator1.TabIndex = 68;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // announcementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.noResFoundLbl);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.fbCodeLbl);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchResult);
            this.Name = "announcementUserControl";
            this.Size = new System.Drawing.Size(655, 609);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox searchTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResult;
        private System.Windows.Forms.TextBox messageTxt;
        private Bunifu.Framework.UI.BunifuFlatButton postBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel fbCodeLbl;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton showBtn;
        private Bunifu.Framework.UI.BunifuImageButton hideBtn;
        private System.Windows.Forms.Label noResFoundLbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
