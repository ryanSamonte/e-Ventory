using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void close_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to exit?", "System Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
                panelTransition.ShowSync(panelMenu);
            }

            else
            {
                logoTransition.Hide(systemLogo);
                smallSystemLogo.Visible = true;
                //panelMenu.Visible = false;
                panelMenu.Width = 80;
                panelTransition.ShowSync(panelMenu);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
