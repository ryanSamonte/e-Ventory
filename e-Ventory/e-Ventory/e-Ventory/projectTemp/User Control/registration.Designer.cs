namespace projectTemp
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.lastNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.firstNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ageTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contactNoTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.participantIdLbl = new System.Windows.Forms.Label();
            this.searchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.schedIDLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventNameLbl = new System.Windows.Forms.Label();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.registerBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveVoucher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.qrCodePic = new System.Windows.Forms.PictureBox();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.noResFoundLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.lastNameTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.lastNameTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.lastNameTxt.BorderThickness = 3;
            this.lastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNameTxt.ForeColor = System.Drawing.Color.Black;
            this.lastNameTxt.isPassword = false;
            this.lastNameTxt.Location = new System.Drawing.Point(15, 298);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(297, 42);
            this.lastNameTxt.TabIndex = 41;
            this.lastNameTxt.Text = "Last Name";
            this.lastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastNameTxt.Enter += new System.EventHandler(this.lastNameTxt_Enter);
            this.lastNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTxt_KeyPress);
            this.lastNameTxt.Leave += new System.EventHandler(this.lastNameTxt_Leave);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.firstNameTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.firstNameTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.firstNameTxt.BorderThickness = 3;
            this.firstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstNameTxt.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxt.isPassword = false;
            this.firstNameTxt.Location = new System.Drawing.Point(15, 362);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(297, 42);
            this.firstNameTxt.TabIndex = 42;
            this.firstNameTxt.Text = "First Name";
            this.firstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstNameTxt.Enter += new System.EventHandler(this.firstNameTxt_Enter);
            this.firstNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTxt_KeyPress);
            this.firstNameTxt.Leave += new System.EventHandler(this.firstNameTxt_Leave);
            // 
            // ageTxt
            // 
            this.ageTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.ageTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.ageTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.ageTxt.BorderThickness = 3;
            this.ageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ageTxt.ForeColor = System.Drawing.Color.Black;
            this.ageTxt.isPassword = false;
            this.ageTxt.Location = new System.Drawing.Point(15, 430);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(297, 42);
            this.ageTxt.TabIndex = 43;
            this.ageTxt.Text = "Age";
            this.ageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ageTxt.Enter += new System.EventHandler(this.ageTxt_Enter);
            this.ageTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTxt_KeyPress);
            this.ageTxt.Leave += new System.EventHandler(this.ageTxt_Leave);
            // 
            // contactNoTxt
            // 
            this.contactNoTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.contactNoTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.contactNoTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.contactNoTxt.BorderThickness = 3;
            this.contactNoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNoTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactNoTxt.ForeColor = System.Drawing.Color.Black;
            this.contactNoTxt.isPassword = false;
            this.contactNoTxt.Location = new System.Drawing.Point(15, 503);
            this.contactNoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.contactNoTxt.Name = "contactNoTxt";
            this.contactNoTxt.Size = new System.Drawing.Size(297, 42);
            this.contactNoTxt.TabIndex = 44;
            this.contactNoTxt.Text = "Contact Number";
            this.contactNoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNoTxt.Enter += new System.EventHandler(this.contactNoTxt_Enter);
            this.contactNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNoTxt_KeyPress);
            this.contactNoTxt.Leave += new System.EventHandler(this.contactNoTxt_Leave);
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
            this.searchTxt.TabIndex = 50;
            this.searchTxt.Text = "Event Name";
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTxt.OnValueChanged += new System.EventHandler(this.searchTxt_OnValueChanged);
            this.searchTxt.Enter += new System.EventHandler(this.searchTxt_Enter);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Participant ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Schedule ID:";
            // 
            // participantIdLbl
            // 
            this.participantIdLbl.AutoSize = true;
            this.participantIdLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantIdLbl.Location = new System.Drawing.Point(153, 264);
            this.participantIdLbl.Name = "participantIdLbl";
            this.participantIdLbl.Size = new System.Drawing.Size(139, 22);
            this.participantIdLbl.TabIndex = 53;
            this.participantIdLbl.Text = "Participant ID:";
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
            this.searchResult.Size = new System.Drawing.Size(624, 185);
            this.searchResult.TabIndex = 54;
            this.searchResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResult_CellMouseClick);
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // schedIDLbl
            // 
            this.schedIDLbl.AutoSize = true;
            this.schedIDLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedIDLbl.Location = new System.Drawing.Point(454, 263);
            this.schedIDLbl.Name = "schedIDLbl";
            this.schedIDLbl.Size = new System.Drawing.Size(0, 19);
            this.schedIDLbl.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Event Name:";
            // 
            // eventNameLbl
            // 
            this.eventNameLbl.AutoSize = true;
            this.eventNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLbl.Location = new System.Drawing.Point(454, 284);
            this.eventNameLbl.Name = "eventNameLbl";
            this.eventNameLbl.Size = new System.Drawing.Size(0, 19);
            this.eventNameLbl.TabIndex = 57;
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
            this.clearBtn.Location = new System.Drawing.Point(166, 552);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.Red;
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearBtn.selected = false;
            this.clearBtn.Size = new System.Drawing.Size(126, 42);
            this.clearBtn.TabIndex = 49;
            this.clearBtn.Text = "  Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerBtn.BorderRadius = 0;
            this.registerBtn.ButtonText = "Save";
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.DisabledColor = System.Drawing.Color.Gray;
            this.registerBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.registerBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("registerBtn.Iconimage")));
            this.registerBtn.Iconimage_right = null;
            this.registerBtn.Iconimage_right_Selected = null;
            this.registerBtn.Iconimage_Selected = null;
            this.registerBtn.IconMarginLeft = 2;
            this.registerBtn.IconMarginRight = 0;
            this.registerBtn.IconRightVisible = true;
            this.registerBtn.IconRightZoom = 0D;
            this.registerBtn.IconVisible = true;
            this.registerBtn.IconZoom = 140D;
            this.registerBtn.IsTab = false;
            this.registerBtn.Location = new System.Drawing.Point(34, 552);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registerBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.registerBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.registerBtn.selected = false;
            this.registerBtn.Size = new System.Drawing.Size(126, 42);
            this.registerBtn.TabIndex = 48;
            this.registerBtn.Text = "Save";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerBtn.Textcolor = System.Drawing.Color.White;
            this.registerBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // saveVoucher
            // 
            this.saveVoucher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveVoucher.BorderRadius = 0;
            this.saveVoucher.ButtonText = "Save Voucher";
            this.saveVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveVoucher.DisabledColor = System.Drawing.Color.Gray;
            this.saveVoucher.Iconcolor = System.Drawing.Color.Transparent;
            this.saveVoucher.Iconimage = global::projectTemp.Properties.Resources.voucherQR1;
            this.saveVoucher.Iconimage_right = null;
            this.saveVoucher.Iconimage_right_Selected = null;
            this.saveVoucher.Iconimage_Selected = null;
            this.saveVoucher.IconMarginLeft = 15;
            this.saveVoucher.IconMarginRight = 0;
            this.saveVoucher.IconRightVisible = true;
            this.saveVoucher.IconRightZoom = 0D;
            this.saveVoucher.IconVisible = true;
            this.saveVoucher.IconZoom = 65D;
            this.saveVoucher.IsTab = false;
            this.saveVoucher.Location = new System.Drawing.Point(406, 551);
            this.saveVoucher.Name = "saveVoucher";
            this.saveVoucher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveVoucher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.saveVoucher.OnHoverTextColor = System.Drawing.Color.White;
            this.saveVoucher.selected = false;
            this.saveVoucher.Size = new System.Drawing.Size(169, 42);
            this.saveVoucher.TabIndex = 47;
            this.saveVoucher.Text = "Save Voucher";
            this.saveVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveVoucher.Textcolor = System.Drawing.Color.White;
            this.saveVoucher.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveVoucher.Click += new System.EventHandler(this.saveVoucher_Click);
            // 
            // saveTicket
            // 
            this.saveTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveTicket.BorderRadius = 0;
            this.saveTicket.ButtonText = "   Save Ticket";
            this.saveTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTicket.DisabledColor = System.Drawing.Color.Gray;
            this.saveTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.saveTicket.Iconimage = global::projectTemp.Properties.Resources.ticketQR;
            this.saveTicket.Iconimage_right = null;
            this.saveTicket.Iconimage_right_Selected = null;
            this.saveTicket.Iconimage_Selected = null;
            this.saveTicket.IconMarginLeft = 15;
            this.saveTicket.IconMarginRight = 0;
            this.saveTicket.IconRightVisible = true;
            this.saveTicket.IconRightZoom = 0D;
            this.saveTicket.IconVisible = true;
            this.saveTicket.IconZoom = 65D;
            this.saveTicket.IsTab = false;
            this.saveTicket.Location = new System.Drawing.Point(406, 503);
            this.saveTicket.Name = "saveTicket";
            this.saveTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.saveTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.saveTicket.selected = false;
            this.saveTicket.Size = new System.Drawing.Size(169, 42);
            this.saveTicket.TabIndex = 46;
            this.saveTicket.Text = "   Save Ticket";
            this.saveTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveTicket.Textcolor = System.Drawing.Color.White;
            this.saveTicket.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTicket.Click += new System.EventHandler(this.saveTicket_Click);
            // 
            // qrCodePic
            // 
            this.qrCodePic.Location = new System.Drawing.Point(391, 320);
            this.qrCodePic.Name = "qrCodePic";
            this.qrCodePic.Size = new System.Drawing.Size(197, 175);
            this.qrCodePic.TabIndex = 45;
            this.qrCodePic.TabStop = false;
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
            this.refreshBtn.TabIndex = 58;
            this.refreshBtn.Text = "  Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // noResFoundLbl
            // 
            this.noResFoundLbl.AutoSize = true;
            this.noResFoundLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResFoundLbl.Location = new System.Drawing.Point(225, 114);
            this.noResFoundLbl.Name = "noResFoundLbl";
            this.noResFoundLbl.Size = new System.Drawing.Size(205, 88);
            this.noResFoundLbl.TabIndex = 68;
            this.noResFoundLbl.Text = "NO RESULT\r\n   FOUND";
            this.noResFoundLbl.Visible = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.noResFoundLbl);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.eventNameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.schedIDLbl);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.participantIdLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.saveVoucher);
            this.Controls.Add(this.saveTicket);
            this.Controls.Add(this.qrCodePic);
            this.Controls.Add(this.contactNoTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Name = "registration";
            this.Size = new System.Drawing.Size(655, 609);
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox lastNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox firstNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox ageTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox contactNoTxt;
        private System.Windows.Forms.PictureBox qrCodePic;
        private Bunifu.Framework.UI.BunifuFlatButton saveTicket;
        private Bunifu.Framework.UI.BunifuFlatButton saveVoucher;
        private Bunifu.Framework.UI.BunifuFlatButton registerBtn;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label participantIdLbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResult;
        private System.Windows.Forms.Label schedIDLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eventNameLbl;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
        private System.Windows.Forms.Label noResFoundLbl;
    }
}
