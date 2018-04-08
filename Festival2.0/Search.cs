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
    public partial class Search : UserControl
    {
        private ServiceSpectacole servS;

        public Search()
        {
            
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }

        public void loadService(ServiceSpectacole servS)
        {
            this.servS = servS;
            bunifuCustomDataGrid1.DataSource = servS.GetAll();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            List<Spectacol> spectacole = new List<Spectacol>();

            foreach (var show in servS.GetAll())
            {
                if (show.DataSpectacol.Contains(bunifuMaterialTextbox1.Text))
                {
                    spectacole.Add(show);
                }
                
            }

            bunifuCustomDataGrid1.DataSource = spectacole;

            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuCustomDataGrid1.DataSource = servS.GetAll();
            }
        }
    }
}
