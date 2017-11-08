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

namespace projectTemp
{
    public partial class participants : UserControl
    {
        SqlConnection con = new SqlConnection(DBConnection.connect());
        int schedID = 0;
        public participants()
        {
            InitializeComponent();  
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

        void fillResult()
        {
            searchResult.DataSource = dataLib.viewAll(DBConnection.connect());
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

        private void participants_Load(object sender, EventArgs e)
        {
            fillResult();
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
                                                                    WHERE eventName LIKE '%" + searchTxt.Text + "%' AND isPastEvent != 1  ORDER BY 4 ASC", con);

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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillResult();
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            if (searchResult.CurrentRow.Index != -1)
            {
                unpaidDGV.DataSource = dataLib.fillParticipantTable(DBConnection.connect(), Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value.ToString()), "UNPAID");
                unpaidDGV.Columns["firstName"].HeaderText = "FIRST NAME";
                unpaidDGV.Columns["lastName"].HeaderText = "LAST NAME";
                unpaidDGV.Columns["age"].HeaderText = "AGE";
                unpaidDGV.Columns["contactNum"].HeaderText = "CONTACT NUMBER";
                paidDGV.DataSource = dataLib.fillParticipantTable(DBConnection.connect(), Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value.ToString()), "PAID");
                paidDGV.Columns["firstName"].HeaderText = "FIRST NAME";
                paidDGV.Columns["lastName"].HeaderText = "LAST NAME";
                paidDGV.Columns["age"].HeaderText = "AGE";
                paidDGV.Columns["contactNum"].HeaderText = "CONTACT NUMBER";
                unpaidDGV.Columns[0].Width = 110;
                unpaidDGV.Columns[1].Width = 110;
                unpaidDGV.Columns[2].Width = 45;
                unpaidDGV.Columns[3].Width = 120;

                paidDGV.Columns[0].Width = 110;
                paidDGV.Columns[1].Width = 110;
                paidDGV.Columns[2].Width = 45;
                paidDGV.Columns[3].Width = 120;

                ticketLeftLbl.Text = (Convert.ToInt32(searchResult.CurrentRow.Cells[8].Value.ToString()) - dataLib.ticketBoughtCount(DBConnection.connect(), Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value.ToString()))).ToString();
                ticketBoughtLbl.Text = (dataLib.ticketBoughtCount(DBConnection.connect(), Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value.ToString()))).ToString();
                unpaidLbl.Text = (dataLib.countUnpaidParticipants(DBConnection.connect(), Convert.ToInt32(searchResult.CurrentRow.Cells[0].Value.ToString()))).ToString();
                searchResult.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                searchResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void searchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            searchResult.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            searchResult.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
