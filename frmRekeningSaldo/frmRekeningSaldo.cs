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
            try//foutafhandeling
            {
                //het bedrag, de datum en de omschrijving worden weggeschreven naar de controller
                _controller.addVerrichting(Convert.ToDouble(txtBedrag.Text), Convert.ToDateTime(txtDatum.Text), Convert.ToString(txtOmschrijving.Text));
                //alle textboxes worden gecleared zodat er een nieuwe verrichting kan worden toegevoegd
                foreach (TextBox box in this.Controls.OfType<TextBox>())
                {
                    box.Clear();
                }
                //de verrichting wordt toegevoegd aan de listbox
                lstVerrichtingen.DataSource = _controller.getVerrichtingen();
                //de rekeningstand wordt geupdate
                lblStand.Text = Convert.ToString(_controller.getRekeningStand());
            }
            catch
            {
                MessageBox.Show("Zorg dat je alle waarden op de juiste manier hebt ingegeven");//messagebox wordt getoond indien er een fout opgetreden is               
            }
        }
    }
}
