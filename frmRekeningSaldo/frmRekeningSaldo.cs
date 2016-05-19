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
            _controller.addVerrichting(Convert.ToDouble(txtBedrag.Text), Convert.ToDateTime(txtDatum.Text), Convert.ToString(txtOmschrijving.Text));
            foreach ( TextBox box in this.Controls.OfType<TextBox>())
            {
                box.Clear();
            }
            lstVerrichtingen.Text = Convert.ToString(_controller.getVerrichtingen());
        }
    }
}
