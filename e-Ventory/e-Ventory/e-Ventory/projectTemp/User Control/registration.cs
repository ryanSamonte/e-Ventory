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
using System.Data;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Media;

namespace projectTemp
{
    public partial class registration : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        public string ticketAmount = "";
        public string dateStart = "";
        public string dateEnd = "";
        public string timeStart = "";
        public string timeEnd = "";
        public string venue = "";
        public string fbGroupID = "";
        public string amountType = "";
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            fillResult();
            idGenerator();
        }

        void fillResult()
        {
            searchResult.DataSource = dataLib.viewAllNotFullEvents(DBConnection.connect());
            searchResult.Columns["scheduleID"].Visible = false;
            searchResult.Columns["eventName"].HeaderText = "EVENT NAME";
            searchResult.Columns["description"].HeaderText = "DESCRIPTION";
            searchResult.Columns["dateStart"].HeaderText = "START DATE";
            searchResult.Columns["dateEnd"].HeaderText = "END DATE";
            searchResult.Columns["timeStart"].HeaderText = "START TIME";
            searchResult.Columns["timeEnd"].HeaderText = "END TIME";
            searchResult.Columns["venueName"].HeaderText = "VENUE";
            searchResult.Columns["ticketCapacity"].HeaderText = "PARTICIPANTS";
            searchResult.Columns["ticketAmount"].HeaderText = "TICKET FEE";
            searchResult.Columns["fbGroupCode"].HeaderText = "FB GROUP CODE";
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            if (searchResult.CurrentRow.Index != -1)
            {
                schedIDLbl.Text = searchResult.CurrentRow.Cells[0].Value.ToString();
                eventNameLbl.Text = searchResult.CurrentRow.Cells[1].Value.ToString();
                ticketAmount = searchResult.CurrentRow.Cells[9].Value.ToString();
                dateStart = searchResult.CurrentRow.Cells[3].Value.ToString();
                dateEnd = searchResult.CurrentRow.Cells[4].Value.ToString();
                timeStart = searchResult.CurrentRow.Cells[5].Value.ToString();
                timeEnd = searchResult.CurrentRow.Cells[6].Value.ToString();
                venue = searchResult.CurrentRow.Cells[7].Value.ToString();
                fbGroupID = searchResult.CurrentRow.Cells[10].Value.ToString();
                searchResult.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                searchResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        void idGenerator()
        {
            int count = 0;
            int lastID = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand getPartTCount = new SqlCommand(@"SELECT COUNT(*) AS 'partTcount' FROM tb_participantInformations", con);

                    SqlDataReader reader = getPartTCount.ExecuteReader();

                    while (reader.Read())
                    {
                        count = (int)reader["partTcount"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            if (count == 0)
            {
                participantIdLbl.Text = "1";
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                        SqlCommand getID = new SqlCommand(@"SELECT TOP 1 participantID FROM tb_participantInformations ORDER BY participantID DESC", con);

                        SqlDataReader reader2 = getID.ExecuteReader();

                        while (reader2.Read())
                        {
                            lastID = (int)reader2["participantID"];
                        }
                        int nextID = lastID + 1;
                        participantIdLbl.Text = nextID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void lastNameTxt_Enter(object sender, EventArgs e)
        {
            if (lastNameTxt.Text.Trim().Equals("Last Name"))
            {
                lastNameTxt.Text = "";
            }
        }

        private void lastNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTxt.Text))
            {
                lastNameTxt.Text = "Last Name";
            }
        }

        private void firstNameTxt_Enter(object sender, EventArgs e)
        {
            if (firstNameTxt.Text.Trim().Equals("First Name"))
            {
                firstNameTxt.Text = "";
            }
        }

        private void firstNameTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTxt.Text))
            {
                firstNameTxt.Text = "First Name";
            }
        }

        private void ageTxt_Enter(object sender, EventArgs e)
        {
            if (ageTxt.Text.Trim().Equals("Age"))
            {
                ageTxt.Text = "";
            }
        }

        private void ageTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ageTxt.Text))
            {
                ageTxt.Text = "Age";
            }
        }

        private void contactNoTxt_Enter(object sender, EventArgs e)
        {
            if (contactNoTxt.Text.Trim().Equals("Contact Number"))
            {
                contactNoTxt.Text = "";
            }
        }

        private void contactNoTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(contactNoTxt.Text))
            {
                contactNoTxt.Text = "Contact Number";
            }
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

        private void searchTxt_OnValueChanged(object sender, EventArgs e)
        {
            DataTable eventNameResult = new DataTable(); ;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter resultSet = new SqlDataAdapter(@"SELECT EI.scheduleID, eventName, [description], 
                                                                    dateStart, dateEnd, timeStart, timeEnd, 
                                                                    venueName, ticketCapacity, ticketAmount, fbGroupCode
                                                                    FROM tb_EventInfo EI JOIN tb_Schedule S ON EI.scheduleID = s.scheduleID
                                                                    WHERE eventName LIKE '%" + searchTxt.Text + "%' AND isPastEvent != 1 ORDER BY 4 ASC", con);

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
                        searchResult.Columns["venueName"].HeaderText = "VENUE";
                        searchResult.Columns["ticketCapacity"].HeaderText = "PARTICIPANTS";
                        searchResult.Columns["ticketAmount"].HeaderText = "TICKET FEE";
                        searchResult.Columns["fbGroupCode"].HeaderText = "FB GROUP CODE";
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            bool emptyField = lastNameTxt.Text.Equals("Last Name") || firstNameTxt.Text.Equals("First Name") || ageTxt.Text.Equals("Age") || contactNoTxt.Text.Equals("Contact Number");
            bool noChosenEvent = participantIdLbl.Text.Equals("") || schedIDLbl.Text.Equals("") || eventNameLbl.Text.Equals(""); 

            if (noChosenEvent == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly choose the event you want to join", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (emptyField == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Kindly fill out all fields", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Register " + firstNameTxt.Text + " " + lastNameTxt.Text + " to " + eventNameLbl.Text + " event?", "e-Ventory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        double amount = Convert.ToDouble(ticketAmount);
                        searchResult.Enabled = false;
                        insertStatements.insertTicket(DBConnection.connect(), Convert.ToInt32(schedIDLbl.Text), participantIdLbl.Text, participantIdLbl.Text + schedIDLbl.Text, amount, false);
                        insertStatements.insertParticipant(DBConnection.connect(), participantIdLbl.Text, lastNameTxt.Text, firstNameTxt.Text, ageTxt.Text, contactNoTxt.Text, Convert.ToInt32(schedIDLbl.Text));

                        QRCodeEncoder encoder = new QRCodeEncoder();
                        encoder.QRCodeScale = 15;
                        Bitmap qr = encoder.Encode(participantIdLbl.Text + schedIDLbl.Text);
                        qr = new Bitmap(qr, new Size(197, 175));
                        qrCodePic.Image = qr;

                        if (amount == 0)
                        {
                            updateStatement.updateTicketBought(DBConnection.connect(), dataLib.ticketBoughtCount(DBConnection.connect(), Convert.ToInt32(schedIDLbl.Text)) + 1, Convert.ToInt32(schedIDLbl.Text));
                            insertStatements.insertSystemLog(DBConnection.connect(), "'" + firstNameTxt.Text.Trim() + " " + lastNameTxt.Text.Trim()+ "' register for event '" + eventNameLbl.Text.Trim() + "' (FREE ADMISSION)", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                            saveTicket.Enabled = true;
                            saveVoucher.Enabled = false;
                            amountType = "FREE";
                        }
                        else
                        {
                            insertStatements.insertSystemLog(DBConnection.connect(), "'" + firstNameTxt.Text.Trim() + " " + lastNameTxt.Text.Trim() + "' register for event '" + eventNameLbl.Text.Trim() + "'", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                            saveVoucher.Enabled = true;
                            saveTicket.Enabled = false;
                            amountType = ticketAmount;
                        }
                    }
                }
            }
        }

        private void saveTicket_Click(object sender, EventArgs e)
        {  
            if(qrCodePic.Image == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Register first before printing the ticket", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPageTicket;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                    MetroFramework.MetroMessageBox.Show(this, "QR Code Ticket successfully saved/printed!", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    clearInputs();
                    idGenerator();
                }
            }
        }

        private void saveVoucher_Click(object sender, EventArgs e)
        {
            if (qrCodePic.Image == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Register first before printing the voucher", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPageVoucher;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                    MetroFramework.MetroMessageBox.Show(this, "QR Code Voucher successfully saved/printed!\n\n*Make sure to pay the ticket fee as soon as possible to complete your registration.", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    clearInputs();
                    idGenerator();
                }
            }
        }

        private void Doc_PrintPageTicket(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(qrCodePic.Width, qrCodePic.Height);
            qrCodePic.DrawToBitmap(bm, new Rectangle(0, 0, qrCodePic.Width, qrCodePic.Height));
            e.Graphics.DrawImage(bm, 600, 50);
            e.Graphics.DrawString(eventNameLbl.Text + " " + "TICKET", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 50));
            e.Graphics.DrawString("Date of Purchase:"+" "+DateTime.Now.ToString("MMMM dd, yyyy"), new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 80));
            e.Graphics.DrawString("NAME:"+" "+firstNameTxt.Text+" "+lastNameTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 110));
            e.Graphics.DrawString("AGE:"+" "+ageTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 140));
            e.Graphics.DrawString("CONTACT NO.:"+" "+contactNoTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 170));
            e.Graphics.DrawString("EVENT INFO", new Font("Century Gothic", 14, FontStyle.Underline), Brushes.Black, new PointF(50, 270));
            e.Graphics.DrawString("START DATE:"+" "+dateStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 300));
            e.Graphics.DrawString("END DATE:" + " " + dateEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 330));
            e.Graphics.DrawString("START TIME:" + " " + timeStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 360));
            e.Graphics.DrawString("END TIME:" + " " + timeEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 390));
            e.Graphics.DrawString("VENUE:"+" "+venue, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 420));
            e.Graphics.DrawString("TICKET AMOUNT:" + " " + amountType, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 450));
            e.Graphics.DrawString("Join the Facebook Group 'https://www.facebook.com/groups/" + fbGroupID + "/'\nTo keep updated about your chosen event", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new PointF(50,480));
            e.Graphics.DrawString("POWERED BY: e-Ventory: EVENT MANAGEMENT SYSTEM", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 900));
            e.Graphics.DrawString("'Manage Events e-Ven Better'", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(470, 920));
            e.Graphics.DrawString("DEVELOPERS:", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 940));
            e.Graphics.DrawString("Bryan Julius A. Alano\nKenneth H. Canada\nJohn Roderick T. Pepino\nRyan Joseph R. Samonte\nLowell Jay F. Vasquez", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(470, 960));
            bm.Dispose();
        }

        private void Doc_PrintPageVoucher(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(qrCodePic.Width, qrCodePic.Height);
            qrCodePic.DrawToBitmap(bm, new Rectangle(0, 0, qrCodePic.Width, qrCodePic.Height));
            e.Graphics.DrawImage(bm, 600, 50);
            e.Graphics.DrawString(eventNameLbl.Text + " " + "PAYMENT VOUCHER", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 50));
            e.Graphics.DrawString("Date of Registration:" + " " + DateTime.Now.ToString("MMMM dd, yyyy"), new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 80));
            e.Graphics.DrawString("NAME:" + " " + firstNameTxt.Text + " " + lastNameTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 110));
            e.Graphics.DrawString("AGE:" + " " + ageTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 140));
            e.Graphics.DrawString("CONTACT NO.:" + " " + contactNoTxt.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 170));
            e.Graphics.DrawString("EVENT INFO", new Font("Century Gothic", 14, FontStyle.Underline), Brushes.Black, new PointF(50, 270));
            e.Graphics.DrawString("START DATE:" + " " + dateStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 300));
            e.Graphics.DrawString("END DATE:" + " " + dateEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 330));
            e.Graphics.DrawString("START TIME:" + " " + timeStart, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 360));
            e.Graphics.DrawString("END TIME:" + " " + timeEnd, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 390));
            e.Graphics.DrawString("VENUE:" + " " + venue, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 420));
            e.Graphics.DrawString("TICKET AMOUNT:" + " Php " + amountType, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 450));
            e.Graphics.DrawString("Join the Facebook Group 'https://www.facebook.com/groups/" + fbGroupID + "/'\nTo keep updated about your chosen event", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 480));
            e.Graphics.DrawString("NOTE: Make sure to pay as soon as possible to reserve your ticket and complete your registration", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(50, 560));
            e.Graphics.DrawString("POWERED BY: e-Ventory: EVENT MANAGEMENT SYSTEM", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 900));
            e.Graphics.DrawString("'Manage Events e-Ven Better'", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(470, 920));
            e.Graphics.DrawString("DEVELOPERS:", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new PointF(440, 940));
            e.Graphics.DrawString("Bryan Julius A. Alano\nKenneth H. Canada\nJohn Roderick T. Pepino\nRyan Joseph R. Samonte\nLowell Jay F. Vasquez", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(470, 960));
            bm.Dispose();
        }

        void clearInputs()
        {
            searchResult.Enabled = true;
            lastNameTxt.Text = "Last Name";
            firstNameTxt.Text = "First Name";
            ageTxt.Text = "Age";
            contactNoTxt.Text = "Contact Number";
            schedIDLbl.Text = "";
            eventNameLbl.Text = "";
            qrCodePic.Image = null;
            saveTicket.Enabled = true;
            saveVoucher.Enabled = true;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillResult();
            idGenerator();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void searchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            searchResult.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            searchResult.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void ageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void contactNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void lastNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }

        private void firstNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || Char.IsSymbol(e.KeyChar) == true || Char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
