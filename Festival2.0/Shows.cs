using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Festival2._0.Service;
using Festival.Model;

namespace Festival2._0
{
    public partial class Shows : UserControl
    {
        private ServiceSpectacole servS;

        public Shows()
        {
            InitializeComponent();
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadService(ServiceSpectacole servS)
        {
            this.servS = servS;
            bunifuCustomDataGrid1.DataSource = servS.GetAll();

            for (int i = 0; i < servS.GetAll().Count; i++)
            {
                if (servS.GetAll().ElementAt(i).NrLocuri == 0)
                {
                    bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
        }
    }
}
