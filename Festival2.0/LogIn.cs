using Festival2._0.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival2._0
{
    public partial class LogIn : Form
    {
        private ServiceUsers service;
        private ServiceBilete servBilete;
        private ServiceClienti servClienti;
        private ServiceSpectacole servSpectacole;

        public LogIn(ServiceUsers servUsers, ServiceBilete sb, ServiceClienti sc, ServiceSpectacole ss)
        {
            this.servClienti = sc;
            this.servSpectacole = ss;
            this.servBilete = sb;
            this.service = servUsers;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (service.Exists(new Festival.Model.User(bunifuMaterialTextbox1.Text,bunifuMaterialTextbox2.Text)))
            {
                bunifuMaterialTextbox1.BackColor = Color.MediumSeaGreen;
                bunifuMaterialTextbox2.BackColor = Color.MediumSeaGreen;
                this.Hide();
                var form2 = new Festivapp(servClienti,servBilete,servSpectacole, this);
                form2.ShowDialog();

            }
            else
            {
                bunifuMaterialTextbox1.BackColor = Color.DarkRed;
                bunifuMaterialTextbox2.BackColor = Color.DarkRed;

            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
