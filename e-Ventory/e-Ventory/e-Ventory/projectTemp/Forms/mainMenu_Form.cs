using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eVentoryLibraries;

namespace projectTemp
{
    public partial class mainMenu_Form : Form
    {
        public mainMenu_Form()
        {
            InitializeComponent();
        }

        private void mainMenu_Form_Load(object sender, EventArgs e)
        {
            updateStatement.updateEventStatus(DBConnection.connect());
            //adminNameLbl.Text = dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())) + " !";
            dashboard1.BringToFront();
            dashBoardbtn.selected = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to exit?", "e-Ventory", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                insertStatements.insertSystemLog(DBConnection.connect(), "Log-out", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                deleteStatement.deleteAllLoggedAdmin(DBConnection.connect());
                Application.Exit();
            }
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.FromArgb(41, 128, 185);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {//245
            if(panelMenu.Width == 80)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 245;
                smallSystemLogo.Visible = false;
                systemLogo.Visible = true;
                panelMenu.Visible = true;
                //adminNameLbl.Visible = true;
                wlcmLbl.Visible = true;
                //change location
                dashboard1.Location = new Point(245, 46);
                addEvent1.Location = new Point(245, 46);
                monitorEvent1.Location = new Point(245, 46);
                systemLogs1.Location = new Point(245, 46);
                announcementUserControl1.Location = new Point(245, 46);
                registration1.Location = new Point(245, 46);
                payment1.Location = new Point(245, 46);
                participants1.Location = new Point(245, 46);
                ticketscanner1.Location = new Point(245, 46);
                sideMenu.Visible = false;
            }

            else
            {
                logoTransition.Hide(systemLogo);
                smallSystemLogo.Visible = true;
                //adminNameLbl.Visible = false;
                wlcmLbl.Visible = false;
                //panelMenu.Visible = false;
                panelMenu.Width = 80;
                panelTransition.ShowSync(panelMenu);
                //change location
                dashboard1.Location = new Point(80, 46);
                addEvent1.Location = new Point(80, 46);
                monitorEvent1.Location = new Point(80, 46);
                systemLogs1.Location = new Point(80, 46);
                announcementUserControl1.Location = new Point(80, 46);
                registration1.Location = new Point(80, 46);
                payment1.Location = new Point(80, 46);
                participants1.Location = new Point(80, 46);
                ticketscanner1.Location = new Point(80, 46);
                sideMenu.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void smallSystemLogo_Click(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void announcementBtn_Click(object sender, EventArgs e)
        {
            announcementUserControl1.BringToFront();
        }

        private void systemLogsBtn_Click(object sender, EventArgs e)
        {
            systemLogs1.BringToFront();
        }

        private void addEventbtn_Click(object sender, EventArgs e)
        {
            addEvent1.BringToFront();
        }

        private void monitorEventbtn_Click(object sender, EventArgs e)
        {
            monitorEvent1.BringToFront();
        }

        private void dashBoardbtn_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void logOutBtn_MouseHover(object sender, EventArgs e)
        {
            logOutLbl.Visible = true;
        }

        private void logOutBtn_MouseLeave(object sender, EventArgs e)
        {
            logOutLbl.Visible = false;
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitLbl.Visible = true;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitLbl.Visible = false;
        }

        private void showBtn_MouseHover(object sender, EventArgs e)
        {
            sideMenu.Width = 174;
            hideBtn.Visible = true;
            showBtn.Visible = false;
        }

        private void showBtn_MouseClick(object sender, MouseEventArgs e)
        {
            sideMenu.Width = 174;
            hideBtn.Visible = true;
            showBtn.Visible = false;
        }

        private void hideBtn_MouseHover(object sender, EventArgs e)
        {
            sideMenu.Width = 35;
            hideBtn.Visible = false;
            showBtn.Visible = true;
        }

        private void hideBtn_MouseClick(object sender, MouseEventArgs e)
        {
            sideMenu.Width = 35;
            hideBtn.Visible = false;
            showBtn.Visible = true;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to log-out?", "e-Ventory", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                insertStatements.insertSystemLog(DBConnection.connect(), "Log-out", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                deleteStatement.deleteAllLoggedAdmin(DBConnection.connect());
                this.Hide();
                logIn_Form logIn_Obj = new logIn_Form();
                logIn_Obj.Show();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to exit?", "e-Ventory", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                insertStatements.insertSystemLog(DBConnection.connect(), "Log-out", dataLib.loggedAdminName(DBConnection.connect(), dataLib.getLoggedAdminID(DBConnection.connect())), dataLib.currentDateAndTime());
                deleteStatement.deleteAllLoggedAdmin(DBConnection.connect());
                Application.Exit();
            }
        }

        private void eventCountLbl_Click(object sender, EventArgs e)
        {

        }

        private void regiBtn_Click(object sender, EventArgs e)
        {
            registration1.BringToFront();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            payment1.BringToFront();
        }

        private void participantBtn_Click(object sender, EventArgs e)
        {
            participants1.BringToFront();
        }

        private void tickVouchbtn_Click(object sender, EventArgs e)
        {
            ticketscanner1.BringToFront();
        }
    }
}
