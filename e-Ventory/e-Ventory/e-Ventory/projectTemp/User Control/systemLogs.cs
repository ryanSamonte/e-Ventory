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

namespace projectTemp.User_Control
{
    public partial class systemLogs : UserControl
    {
        public systemLogs()
        {
            InitializeComponent();
        }

        private void systemLogs_Load(object sender, EventArgs e)
        {
            fillSystemLogs();
            fromDate.Value = dataLib.currentDateAndTime();
            toDate.Value = dataLib.currentDateAndTime();
        }

        void fillSystemLogs()
        {
            systemLogsDGV.DataSource = dataLib.retrieveSystemLogs(DBConnection.connect());
            systemLogsDGV.Columns["logID"].Width = 35;
            systemLogsDGV.Columns["logID"].HeaderText = "LOG ID";
            systemLogsDGV.Columns["logDescription"].HeaderText = "DESCRIPTION";
            systemLogsDGV.Columns["adminName"].HeaderText = "ADMIN NAME";
            systemLogsDGV.Columns["timestamp"].HeaderText = "DATE & TIME";
            systemLogsDGV.Columns[2].Width = 150;
            systemLogsDGV.Columns[3].Width = 150;
            systemLogsDGV.Columns[1].Width = (systemLogsDGV.Width - (systemLogsDGV.Columns[0].Width + systemLogsDGV.Columns[2].Width + systemLogsDGV.Columns[3].Width)) - 41;
        }

        private void systemLogsDGV_Click(object sender, EventArgs e)
        {
            if (systemLogsDGV.CurrentRow.Index != -1)
            {
                logIDtxt.Text = systemLogsDGV.CurrentRow.Cells[0].Value.ToString();
                descLbl.Text = systemLogsDGV.CurrentRow.Cells[1].Value.ToString();
                datetimeLbl.Text = systemLogsDGV.CurrentRow.Cells[3].Value.ToString();
                systemLogsDGV.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(107, 185, 240);
                systemLogsDGV.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(fromDate.Value > toDate.Value)
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid date input", "e-Ventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dataLib.systemLogsSearchResult(DBConnection.connect(), fromDate.Value, toDate.Value).Rows.Count > 0)
                {
                    systemLogsDGV.Visible = true;
                    noResFoundLbl.Visible = false;
                    systemLogsDGV.DataSource = dataLib.systemLogsSearchResult(DBConnection.connect(), fromDate.Value, toDate.Value);
                }
                else
                {
                    systemLogsDGV.Visible = false;
                    noResFoundLbl.Visible = true;
                }
            }
        }

        private void systemLogsDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            systemLogsDGV.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 62, 80);
            systemLogsDGV.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if(noResFoundLbl.Visible == true)
            {
                noResFoundLbl.Visible = false;
                systemLogsDGV.Visible = true;
                fillSystemLogs();
            }
            else
            {
                fillSystemLogs();
            }
        }
    }
}
