namespace projectTemp
{
    partial class payment
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
            this.webcamList = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketAmountLbl = new System.Windows.Forms.Label();
            this.changeLbl = new System.Windows.Forms.Label();
            this.amountTenderedTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.qrCodePic = new System.Windows.Forms.PictureBox();
            this.cameraPreview = new System.Windows.Forms.PictureBox();
            this.proceedBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.stopCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.participantIDLbl = new System.Windows.Forms.Label();
            this.eventNameLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // webcamList
            // 
            this.webcamList.FormattingEnabled = true;
            this.webcamList.ItemHeight = 23;
            this.webcamList.Location = new System.Drawing.Point(22, 20);
            this.webcamList.Name = "webcamList";
            this.webcamList.Size = new System.Drawing.Size(274, 29);
            this.webcamList.TabIndex = 0;
            this.webcamList.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Participant ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Participant Name:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(317, 20);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 565);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = " Amount\r\nTendered:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Change:";
            // 
            // ticketAmountLbl
            // 
            this.ticketAmountLbl.AutoSize = true;
            this.ticketAmountLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketAmountLbl.Location = new System.Drawing.Point(414, 49);
            this.ticketAmountLbl.Name = "ticketAmountLbl";
            this.ticketAmountLbl.Size = new System.Drawing.Size(0, 19);
            this.ticketAmountLbl.TabIndex = 53;
            // 
            // changeLbl
            // 
            this.changeLbl.AutoSize = true;
            this.changeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLbl.Location = new System.Drawing.Point(414, 231);
            this.changeLbl.Name = "changeLbl";
            this.changeLbl.Size = new System.Drawing.Size(0, 19);
            this.changeLbl.TabIndex = 54;
            // 
            // amountTenderedTxt
            // 
            this.amountTenderedTxt.BorderColorFocused = System.Drawing.Color.Black;
            this.amountTenderedTxt.BorderColorIdle = System.Drawing.Color.Black;
            this.amountTenderedTxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.amountTenderedTxt.BorderThickness = 3;
            this.amountTenderedTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTenderedTxt.Enabled = false;
            this.amountTenderedTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.amountTenderedTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amountTenderedTxt.isPassword = false;
            this.amountTenderedTxt.Location = new System.Drawing.Point(418, 118);
            this.amountTenderedTxt.Margin = new System.Windows.Forms.Padding(4);
            this.amountTenderedTxt.Name = "amountTenderedTxt";
            this.amountTenderedTxt.Size = new System.Drawing.Size(215, 44);
            this.amountTenderedTxt.TabIndex = 55;
            this.amountTenderedTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amountTenderedTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTenderedTxt_KeyPress);
            this.amountTenderedTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.amountTenderedTxt_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.saveTicket.Location = new System.Drawing.Point(438, 519);
            this.saveTicket.Name = "saveTicket";
            this.saveTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.saveTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.saveTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.saveTicket.selected = false;
            this.saveTicket.Size = new System.Drawing.Size(169, 42);
            this.saveTicket.TabIndex = 52;
            this.saveTicket.Text = "   Save Ticket";
            this.saveTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveTicket.Textcolor = System.Drawing.Color.White;
            this.saveTicket.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTicket.Click += new System.EventHandler(this.saveTicket_Click);
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
            this.clearBtn.IconZoom = 50D;
            this.clearBtn.IsTab = true;
            this.clearBtn.Location = new System.Drawing.Point(527, 269);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.Red;
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearBtn.selected = false;
            this.clearBtn.Size = new System.Drawing.Size(119, 35);
            this.clearBtn.TabIndex = 51;
            this.clearBtn.Text = "  Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // qrCodePic
            // 
            this.qrCodePic.Location = new System.Drawing.Point(418, 322);
            this.qrCodePic.Name = "qrCodePic";
            this.qrCodePic.Size = new System.Drawing.Size(197, 175);
            this.qrCodePic.TabIndex = 14;
            this.qrCodePic.TabStop = false;
            // 
            // cameraPreview
            // 
            this.cameraPreview.Location = new System.Drawing.Point(22, 74);
            this.cameraPreview.Name = "cameraPreview";
            this.cameraPreview.Size = new System.Drawing.Size(274, 253);
            this.cameraPreview.TabIndex = 1;
            this.cameraPreview.TabStop = false;
            // 
            // proceedBtn
            // 
            this.proceedBtn.Activecolor = System.Drawing.Color.SeaGreen;
            this.proceedBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.proceedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proceedBtn.BorderRadius = 0;
            this.proceedBtn.ButtonText = "  Save";
            this.proceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedBtn.DisabledColor = System.Drawing.Color.Gray;
            this.proceedBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.proceedBtn.Iconimage = global::projectTemp.Properties.Resources.success;
            this.proceedBtn.Iconimage_right = null;
            this.proceedBtn.Iconimage_right_Selected = null;
            this.proceedBtn.Iconimage_Selected = null;
            this.proceedBtn.IconMarginLeft = 20;
            this.proceedBtn.IconMarginRight = 0;
            this.proceedBtn.IconRightVisible = true;
            this.proceedBtn.IconRightZoom = 0D;
            this.proceedBtn.IconVisible = true;
            this.proceedBtn.IconZoom = 50D;
            this.proceedBtn.IsTab = true;
            this.proceedBtn.Location = new System.Drawing.Point(402, 269);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.proceedBtn.OnHovercolor = System.Drawing.Color.Green;
            this.proceedBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.proceedBtn.selected = false;
            this.proceedBtn.Size = new System.Drawing.Size(119, 35);
            this.proceedBtn.TabIndex = 59;
            this.proceedBtn.Text = "  Save";
            this.proceedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proceedBtn.Textcolor = System.Drawing.Color.White;
            this.proceedBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click_1);
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
            this.openCamera.TabIndex = 60;
            this.openCamera.Text = "Open Camera";
            this.openCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCamera.Textcolor = System.Drawing.Color.White;
            this.openCamera.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCamera.Click += new System.EventHandler(this.openCamera_Click);
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
            this.checkBtn.TabIndex = 61;
            this.checkBtn.Text = "Scan QR Code";
            this.checkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBtn.Textcolor = System.Drawing.Color.White;
            this.checkBtn.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
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
            this.stopCamera.TabIndex = 62;
            this.stopCamera.Text = "  Stop Camera";
            this.stopCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopCamera.Textcolor = System.Drawing.Color.White;
            this.stopCamera.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCamera.Click += new System.EventHandler(this.stopCamera_Click);
            // 
            // participantIDLbl
            // 
            this.participantIDLbl.AutoSize = true;
            this.participantIDLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantIDLbl.Location = new System.Drawing.Point(115, 468);
            this.participantIDLbl.Name = "participantIDLbl";
            this.participantIDLbl.Size = new System.Drawing.Size(0, 16);
            this.participantIDLbl.TabIndex = 63;
            // 
            // eventNameLbl
            // 
            this.eventNameLbl.AutoSize = true;
            this.eventNameLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLbl.Location = new System.Drawing.Point(108, 550);
            this.eventNameLbl.Name = "eventNameLbl";
            this.eventNameLbl.Size = new System.Drawing.Size(0, 16);
            this.eventNameLbl.TabIndex = 64;
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLbl.Location = new System.Drawing.Point(141, 508);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(0, 16);
            this.partNameLbl.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Event Name:";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eventNameLbl);
            this.Controls.Add(this.participantIDLbl);
            this.Controls.Add(this.stopCamera);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.openCamera);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.amountTenderedTxt);
            this.Controls.Add(this.changeLbl);
            this.Controls.Add(this.ticketAmountLbl);
            this.Controls.Add(this.saveTicket);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.qrCodePic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameraPreview);
            this.Controls.Add(this.webcamList);
            this.Name = "payment";
            this.Size = new System.Drawing.Size(655, 609);
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox webcamList;
        private System.Windows.Forms.PictureBox cameraPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox qrCodePic;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
        private Bunifu.Framework.UI.BunifuFlatButton saveTicket;
        private System.Windows.Forms.Label ticketAmountLbl;
        private System.Windows.Forms.Label changeLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox amountTenderedTxt;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton proceedBtn;
        private Bunifu.Framework.UI.BunifuFlatButton openCamera;
        private Bunifu.Framework.UI.BunifuFlatButton checkBtn;
        private Bunifu.Framework.UI.BunifuFlatButton stopCamera;
        private System.Windows.Forms.Label participantIDLbl;
        private System.Windows.Forms.Label eventNameLbl;
        private System.Windows.Forms.Label partNameLbl;
        private System.Windows.Forms.Label label7;
    }
}
