namespace projectTemp.User_Control
{
    partial class systemLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.systemLogsDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datetimeLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logIDtxt = new System.Windows.Forms.Label();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.noResFoundLbl = new System.Windows.Forms.Label();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemLogsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // systemLogsDGV
            // 
            this.systemLogsDGV.AllowUserToAddRows = false;
            this.systemLogsDGV.AllowUserToDeleteRows = false;
            this.systemLogsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.systemLogsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.systemLogsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.systemLogsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.systemLogsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.systemLogsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.systemLogsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.systemLogsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.systemLogsDGV.ColumnHeadersHeight = 40;
            this.systemLogsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.systemLogsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.systemLogsDGV.DoubleBuffered = false;
            this.systemLogsDGV.EnableHeadersVisualStyles = false;
            this.systemLogsDGV.GridColor = System.Drawing.Color.Black;
            this.systemLogsDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.systemLogsDGV.HeaderForeColor = System.Drawing.Color.White;
            this.systemLogsDGV.Location = new System.Drawing.Point(16, 92);
            this.systemLogsDGV.Name = "systemLogsDGV";
            this.systemLogsDGV.ReadOnly = true;
            this.systemLogsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.systemLogsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.systemLogsDGV.RowHeadersVisible = false;
            this.systemLogsDGV.Size = new System.Drawing.Size(621, 412);
            this.systemLogsDGV.TabIndex = 0;
            this.systemLogsDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.systemLogsDGV_CellMouseClick);
            this.systemLogsDGV.Click += new System.EventHandler(this.systemLogsDGV_Click);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(123, 523);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(0, 20);
            this.descLbl.TabIndex = 46;
            // 
            // datetimeLbl
            // 
            this.datetimeLbl.AutoSize = true;
            this.datetimeLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLbl.Location = new System.Drawing.Point(123, 563);
            this.datetimeLbl.Name = "datetimeLbl";
            this.datetimeLbl.Size = new System.Drawing.Size(0, 20);
            this.datetimeLbl.TabIndex = 47;
            // 
            // logIDtxt
            // 
            this.logIDtxt.AutoSize = true;
            this.logIDtxt.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIDtxt.Location = new System.Drawing.Point(69, 507);
            this.logIDtxt.Name = "logIDtxt";
            this.logIDtxt.Size = new System.Drawing.Size(0, 12);
            this.logIDtxt.TabIndex = 49;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(189, 16);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel5.TabIndex = 53;
            this.bunifuCustomLabel5.Text = "To Date:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 16);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(80, 17);
            this.bunifuCustomLabel4.TabIndex = 52;
            this.bunifuCustomLabel4.Text = "From Date:";
            // 
            // toDate
            // 
            this.toDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.toDate.BorderRadius = 0;
            this.toDate.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.ForeColor = System.Drawing.Color.White;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.FormatCustom = "yyyy-MM-dd";
            this.toDate.Location = new System.Drawing.Point(192, 45);
            this.toDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(163, 26);
            this.toDate.TabIndex = 51;
            this.toDate.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // fromDate
            // 
            this.fromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.fromDate.BorderRadius = 0;
            this.fromDate.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.White;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.FormatCustom = "yyyy-MM-dd";
            this.fromDate.Location = new System.Drawing.Point(16, 45);
            this.fromDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(163, 26);
            this.fromDate.TabIndex = 50;
            this.fromDate.Value = new System.DateTime(2017, 9, 7, 0, 0, 0, 0);
            // 
            // noResFoundLbl
            // 
            this.noResFoundLbl.AutoSize = true;
            this.noResFoundLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResFoundLbl.Location = new System.Drawing.Point(225, 244);
            this.noResFoundLbl.Name = "noResFoundLbl";
            this.noResFoundLbl.Size = new System.Drawing.Size(205, 88);
            this.noResFoundLbl.TabIndex = 68;
            this.noResFoundLbl.Text = "NO RESULT\r\n   FOUND";
            this.noResFoundLbl.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.MidnightBlue;
            this.searchBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 0;
            this.searchBtn.ButtonText = "  Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = global::projectTemp.Properties.Resources.search;
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 16;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 60D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(371, 25);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.searchBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(134, 46);
            this.searchBtn.TabIndex = 54;
            this.searchBtn.Text = "  Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.refreshBtn.Location = new System.Drawing.Point(512, 25);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshBtn.selected = false;
            this.refreshBtn.Size = new System.Drawing.Size(134, 46);
            this.refreshBtn.TabIndex = 39;
            this.refreshBtn.Text = "  Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "DATE and TIME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "LOG ID:";
            // 
            // systemLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.noResFoundLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.logIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetimeLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.systemLogsDGV);
            this.Name = "systemLogs";
            this.Size = new System.Drawing.Size(655, 609);
            this.Load += new System.EventHandler(this.systemLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemLogsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid systemLogsDGV;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel descLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel datetimeLbl;
        private System.Windows.Forms.Label logIDtxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker toDate;
        private Bunifu.Framework.UI.BunifuDatepicker fromDate;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private System.Windows.Forms.Label noResFoundLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
