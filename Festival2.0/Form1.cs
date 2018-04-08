using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Festival2._0.Service;
using System.Runtime.InteropServices;

namespace Festival2._0
{
    public partial class Festivapp : MetroForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private ServiceBilete servBilete;
        private ServiceClienti servClienti;
        private ServiceSpectacole servSpectacole;
        private LogIn login;

        public Festivapp(ServiceClienti servC, ServiceBilete servB, ServiceSpectacole servS, LogIn login)
        {
            this.servBilete = servB;
            this.servClienti = servC;
            this.servSpectacole = servS;
            this.login = login;

            InitializeComponent();
            shows1.BringToFront();
            shows1.loadService(servS);
            search1.loadService(servS);
            tickets1.loadService(servB, servS);

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_DragEnter(object sender, DragEventArgs e)
        {

        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Close();
            Application.Exit();
            
        }

        private void logIn1_Load(object sender, EventArgs e)
        {

        }

        private void logIn1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            search1.BringToFront();
            search1.loadService(servSpectacole);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            this.Close();
            login.Show();           
        
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            shows1.BringToFront();
            shows1.loadService(servSpectacole);
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            tickets1.BringToFront();
            tickets1.loadService(servBilete, servSpectacole);
        }

        private void tickets1_Load(object sender, EventArgs e)
        {

        }

        private void tickets1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void search1_Load(object sender, EventArgs e)
        {
            search1.loadService(servSpectacole);
        }

        private void shows1_Load(object sender, EventArgs e)
        {
            shows1.loadService(servSpectacole);
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
