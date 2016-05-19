using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using H7_RekeningSaldo;

namespace frmRekeningSaldo
{
    public partial class frmRekeningSaldo : Form
    {
        Controller _controller = new Controller();

        public frmRekeningSaldo()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.addVerrichting(Convert.ToDouble(txtBedrag.Text), Convert.ToDateTime(txtDatum.Text), Convert.ToString(txtOmschrijving.Text));
                foreach (TextBox box in this.Controls.OfType<TextBox>())
                {
                    box.Clear();
                }
                lstVerrichtingen.DataSource = _controller.getVerrichtingen();
                lblStand.Text = Convert.ToString(_controller.getRekeningStand());
            }
            catch
            {
                MessageBox.Show("Zorg dat je alle waarden op de juiste manier hebt ingegeven");
                
            }
        }
    }
}
