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
    public partial class Tickets : UserControl
    {
        ServiceBilete servB;
        ServiceSpectacole servS;

        public Tickets()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadService(ServiceBilete servBil, ServiceSpectacole servS)
        {
            this.servB = servBil;
            this.servS = servS;
            bunifuCustomDataGrid1.DataSource = servS.GetAll();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (bunifuCustomDataGrid1.SelectedRows.Count == 1)
            {
                if (bunifuMaterialTextbox1.Text !="" && bunifuMaterialTextbox2.Text!="")
                {
                    try
                    {
                        var idSpec = int.Parse(bunifuCustomDataGrid1.SelectedRows[0].Cells["IdSpectacol"].Value.ToString());
                        var nrBileteDisponibile = int.Parse(bunifuCustomDataGrid1.SelectedRows[0].Cells["NrLocuri"].Value.ToString());

                        if (nrBileteDisponibile == 0)
                        {
                            MessageBox.Show("Sold Out!");
                        }
                        else
                        {

                            servB.Add(new Bilet(0, new Client(rand.Next(), bunifuMaterialTextbox1.Text), new Spectacol(idSpec, null, "", "", "", 0, 0), int.Parse(bunifuMaterialTextbox2.Text)));

                            MessageBox.Show("Adaugare efectuata!");
                            bunifuMaterialTextbox1.Text = "";
                            bunifuMaterialTextbox2.Text = "";
                            bunifuCustomDataGrid1.DataSource = servS.GetAll();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Eroare adaugare bilet!");
                    }
                    
                }
            }
        }
    }
}
