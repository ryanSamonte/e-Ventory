using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using eVentoryLibraries;
using MessagingToolkit.QRCode.Codec;
using System.Drawing.Printing;
using System.Media;

namespace projectTemp
{
    public partial class payment : UserControl
    {
        public string qrCode = "";
        double tenderedAmount = 0;
        string decoded = "";
        public string ticketAmount = "";
        public string age = "";
        public string contactNo = "";
        public string dateStart = "";
        public string dateEnd = "";
        public string timeStart = "";
        public string timeEnd = "";
        public string venue = "";
        public string fbGroupID = "";

        public payment()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraPreview.Image = (Image)eventArgs.Frame.Clone();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                webcamList.Items.Add(Device.Name);
            }
            webcamList.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }
        

        private void openCamera_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[webcamList.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            openCamera.Enabled = false;
            checkBtn.Enabled = true;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if(cameraPreview.Image == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Open camera first", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                timer1.Start();
                checkBtn.Enabled = false;
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)cameraPreview.Image);

            
            try
            {
                decoded = result.ToString().Trim();

                if((dataLib.isQRCodeExists(DBConnection.connect(), decoded) == false) || (dataLib.isPastEvent(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded))) == true)
                {
                    timer1.Stop();
                    MetroFramework.MetroMessageBox.Show(this, "QR Code doesn't exists", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBtn.Enabled = true;
                }
                else
                {
                    timer1.Stop();
                    if(dataLib.isAlreadyPaid(DBConnection.connect(), decoded) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Participant already paid", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkBtn.Enabled = true;
                    }
                    else
                    {
                        if (dataLib.isFullEvent(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded)) == true)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Event already full", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkBtn.Enabled = true;
                        }
                        else
                        {
                            participantIDLbl.Text = dataLib.participantID(DBConnection.connect(), decoded).ToString();
                            partNameLbl.Text = dataLib.participantName(DBConnection.connect(), dataLib.participantID(DBConnection.connect(), decoded));
                            eventNameLbl.Text = dataLib.eventName(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            ticketAmountLbl.Text = dataLib.ticketAmount(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded)).ToString();
                            age = dataLib.age(DBConnection.connect(), Convert.ToInt32(participantIDLbl.Text)).ToString();
                            contactNo = dataLib.contactNum(DBConnection.connect(), Convert.ToInt32(participantIDLbl.Text));
                            venue = dataLib.venue(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            dateStart = dataLib.dateStart(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            dateEnd = dataLib.dateEnd(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            timeStart = dataLib.timeStart(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            timeEnd = dataLib.timeEnd(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            venue = dataLib.venue(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            fbGroupID = dataLib.fbGroupID(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                            ticketAmount = ticketAmountLbl.Text;
                            amountTenderedTxt.Enabled = true;
                            checkBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MetroFramework.MetroMessageBox.Show(this, "No QR code detected", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBtn.Enabled = true;
            }
        }

        private void stopCamera_Click(object sender, EventArgs e)
        {
                FinalFrame.Stop();
                cameraPreview.Image = null;
                openCamera.Enabled = true;
                checkBtn.Enabled = true;
        }
        
        private void amountTenderedTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char gchar = e.KeyChar;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                if (gchar.Equals('.'))
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void proceedBtn_Click_1(object sender, EventArgs e)
        {
            if(amountTenderedTxt.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly input tendered amount", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string newQrCode = participantIDLbl.Text + dataLib.schedIDFromQR(DBConnection.connect(), decoded) + "PAID";
                QRCodeEncoder encoder = new QRCodeEncoder();
                encoder.QRCodeScale = 15;
                Bitmap qr = encoder.Encode(newQrCode);
                qr = new Bitmap(qr, new Size(197, 175));
                qrCodePic.Image = qr;

                updateStatement.updateTicketBought(DBConnection.connect(), (dataLib.ticketBoughtCount(DBConnection.connect(), dataLib.schedIDFromQR(DBConnection.connect(), decoded))) + 1, dataLib.schedIDFromQR(DBConnection.connect(), decoded));
                updateStatement.updateQRCode(DBConnection.connect(), newQrCode, Convert.ToInt32(participantIDLbl.Text));
                updateStatement.updatePaymentStatus(DBConnection.connect(), Convert.ToInt32(participantIDLbl.Text));
                insertStatements.insertSystemLog(DBConnection.connect(), "'" + partNameLbl.Text.Trim() + "'" + " paid for event '"+eventNameLbl.Text.Trim()+"'", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                amountTenderedTxt.Enabled = false;
                checkBtn.Enabled = false;
            }
        }

        private void amountTenderedTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (amountTenderedTxt.Text.Length >= 1)
            {
                tenderedAmount = double.Parse(amountTenderedTxt.Text);

                if (tenderedAmount >= Convert.ToDouble(ticketAmountLbl.Text))
                {
                    double compute = tenderedAmount - Convert.ToDouble(ticketAmountLbl.Text);
                    changeLbl.Text = compute.ToString();

                }
            }
            else
            {

            }
        }

        private void saveTicket_Click(object sender, EventArgs e)
        {
            if (qrCodePic.Image == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Pay first before printing the ticket", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPage;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                    MetroFramework.MetroMessageBox.Show(this, "QR Code Ticket successfully saved/printed!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    clearInputs();
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(qrCodePic.Width, qrCodePic.Height);
            qrCodePic.DrawToBitmap(bm, new Rectangle(0, 0, qrCodePic.Width, qrCodePic.Height));
            e.Graphics.DrawImage(bm, 600, 50);
            e.Graphics.DrawString(eventNameLbl.Text + " " + "TICKET", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 50));
            e.Graphics.DrawString("Date of Purchase:" + " " + DateTime.Now.ToString("MMMM dd, yyyy"), new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 80));
            e.Graphics.DrawString("NAME:" + " " + partNameLbl.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 110));
            e.Graphics.DrawString("AGE:" + " " + age, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 140));
            e.Graphics.DrawString("CONTACT NO.:" + " " + contactNo, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 170));
            e.Graphics.DrawString("EVENT INFO", new Font("Century Gothic", 14, FontStyle.Underline), Brushes.Black, new PointF(50, 270));
            e.Graphics.DrawString("START DATE:" + " " + dateStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 300));
            e.Graphics.DrawString("END DATE:" + " " + dateEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 330));
            e.Graphics.DrawString("START TIME:" + " " + timeStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 360));
            e.Graphics.DrawString("END TIME:" + " " + timeEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 390));
            e.Graphics.DrawString("VENUE:" + " " + venue, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 420));
            e.Graphics.DrawString("TICKET AMOUNT:" + " " + ticketAmount, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 450));
            e.Graphics.DrawString("Join the Facebook Group 'https://www.facebook.com/groups/" + fbGroupID + "/'\nTo keep updated about your chosen event", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 480));
            e.Graphics.DrawString("POWERED BY: e-Ventory: EVENT MANAGEMENT SYSTEM", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 900));
            e.Graphics.DrawString("'Manage Events e-Ven Better'", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(470, 920));
            e.Graphics.DrawString("DEVELOPERS:", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 940));
            e.Graphics.DrawString("Bryan Julius A. Alano\nKenneth H. Canada\nJohn Roderick T. Pepino\nRyan Joseph R. Samonte\nLowell Jay F. Vasquez", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(470, 960));
            bm.Dispose();
        }

        void clearInputs()
        {
            participantIDLbl.Text = "";
            partNameLbl.Text = "";
            eventNameLbl.Text = "";
            ticketAmountLbl.Text = "";
            amountTenderedTxt.Text = "";
            changeLbl.Text = "";
            qrCodePic.Image = null;
            amountTenderedTxt.Enabled = false;
            checkBtn.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearInputs();
        }
    }
}
