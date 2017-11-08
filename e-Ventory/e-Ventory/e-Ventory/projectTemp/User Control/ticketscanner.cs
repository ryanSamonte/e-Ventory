using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eVentoryLibraries;
using System.Data.SqlClient;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace projectTemp
{
    public partial class ticketscanner : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public string qrCode = "";
        string decoded = "";
        int schedID = 0;

        public ticketscanner()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraPreview.Image = (Image)eventArgs.Frame.Clone();
        }

        private void searchTxt_OnValueChanged(object sender, EventArgs e)
        {
            DataTable eventNameResult = new DataTable(); ;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter resultSet = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description], 
                                                                    dateStart, dateEnd, timeStart, timeEnd
                                                                    FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                    WHERE (eventName LIKE '%" + searchTxt.Text + "%' AND isPastEvent != 1) AND @dateToday BETWEEN dateStart AND dateEnd ORDER BY 4 ASC", con);


                    resultSet.SelectCommand.Parameters.AddWithValue("@dateToday", DateTime.Today);
                    resultSet.Fill(eventNameResult);

                    if (eventNameResult.Rows.Count > 0 || searchTxt.Text.Equals("Event Name"))
                    {
                        searchResult.Visible = true;
                        searchResult.DataSource = eventNameResult;
                        searchResult.Columns["scheduleID"].Visible = false;
                        searchResult.Columns["eventName"].HeaderText = "EVENT NAME";
                        searchResult.Columns["description"].HeaderText = "DESCRIPTION";
                        searchResult.Columns["dateStart"].HeaderText = "START DATE";
                        searchResult.Columns["dateEnd"].HeaderText = "END DATE";
                        searchResult.Columns["timeStart"].HeaderText = "START TIME";
                        searchResult.Columns["timeEnd"].HeaderText = "END TIME";
                        noResFoundLbl.Visible = false;
                    }
                    else
                    {
                        searchResult.Visible = false;
                        noResFoundLbl.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        void fillResult()
        {
            searchResult.DataSource = dataLib.viewAllEventsToday(DBConnection.connect(), DateTime.Today);
            searchResult.Columns["scheduleID"].Visible = false;
            searchResult.Columns["eventName"].HeaderText = "EVENT NAME";
            searchResult.Columns["description"].HeaderText = "DESCRIPTION";
            searchResult.Columns["dateStart"].HeaderText = "START DATE";
            searchResult.Columns["dateEnd"].HeaderText = "END DATE";
            searchResult.Columns["timeStart"].HeaderText = "START TIME";
            searchResult.Columns["timeEnd"].HeaderText = "END TIME";
        }

        private void ticketscanner_Load(object sender, EventArgs e)
        {
            fillResult();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                webcamList.Items.Add(Device.Name);
            }
            webcamList.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillResult();
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text.Trim().Equals("Event Name"))
            {
                searchTxt.Text = "";
            }
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTxt.Text))
            {
                searchTxt.Text = "Event Name";
                fillResult();
            }
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
            if (cameraPreview.Image == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Open camera first", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (eventNameLbl.Text.Equals(""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Kindly choose an event", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    timer1.Start();
                    checkBtn.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)cameraPreview.Image);
            try
            {
                decoded = result.ToString().Trim();

                if (dataLib.isQRCodeExists(DBConnection.connect(), decoded) == false || dataLib.isAlreadyPaid(DBConnection.connect(), decoded) == false)
                {
                    timer1.Stop();
                    validLbl.Visible = false;
                    validIcon.Visible = false;
                    invalidLbl.Visible = true;
                    invalidIcon.Visible = true;
                    ticketDsntExistLbl.Visible = true;
                    ticketScanAlrdyLbl.Visible = false;
                    checkOutBtn.Visible = false;
                    checkBtn.Enabled = true;
                    welcomeLbl.Visible = false;
                    partNameLbl.Visible = false;
                    sucssflChkOutLbl.Visible = false;
                }
                else
                {
                    timer1.Stop();
                    if (schedID != dataLib.schedIDFromQR(DBConnection.connect(), decoded))
                    {
                        validLbl.Visible = false;
                        validIcon.Visible = false;
                        invalidLbl.Visible = true;
                        invalidIcon.Visible = true;
                        ticketDsntExistLbl.Visible = true;
                        ticketScanAlrdyLbl.Visible = false;
                        checkOutBtn.Visible = false;
                        checkBtn.Enabled = true;
                        welcomeLbl.Visible = false;
                        partNameLbl.Visible = false;
                        sucssflChkOutLbl.Visible = false;
                    }
                    else
                    {
                        if (dataLib.isScannedAlready(DBConnection.connect(), decoded) == true)
                        {
                            validLbl.Visible = false;
                            validIcon.Visible = false;
                            invalidLbl.Visible = true;
                            invalidIcon.Visible = true;
                            ticketDsntExistLbl.Visible = false;
                            ticketScanAlrdyLbl.Visible = true;
                            checkOutBtn.Visible = true;
                            checkBtn.Enabled = true;
                            welcomeLbl.Visible = false;
                            partNameLbl.Visible = false;
                            sucssflChkOutLbl.Visible = false;
                        }
                        else
                        {
                            validLbl.Visible = true;
                            validIcon.Visible = true;
                            invalidLbl.Visible = false;
                            invalidIcon.Visible = false;
                            ticketDsntExistLbl.Visible = false;
                            ticketScanAlrdyLbl.Visible = false;
                            checkOutBtn.Visible = false;
                            checkBtn.Enabled = true;
                            welcomeLbl.Visible = true;
                            partNameLbl.Visible = true;
                            sucssflChkOutLbl.Visible = false;
                            partNameLbl.Text = dataLib.participantName(DBConnection.connect(), dataLib.participantID(DBConnection.connect(), decoded));
                            updateStatement.updateIsScanned(DBConnection.connect(), dataLib.participantID(DBConnection.connect(), decoded), true);
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

        private void searchResult_Click(object sender, EventArgs e)
        {
            if (searchResult.CurrentRow.Index != -1)
            {
                eventNameLbl.Text = searchResult.CurrentRow.Cells[1].Value.ToString();
                schedID = Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value);
                searchResult.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                searchResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            updateStatement.updateIsScanned(DBConnection.connect(), dataLib.participantID(DBConnection.connect(), decoded), false);
            sucssflChkOutLbl.Visible = true;
            checkBtn.Enabled = true;
        }

        private void searchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            searchResult.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            searchResult.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
