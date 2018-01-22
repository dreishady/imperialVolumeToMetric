using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TempConverterClient
{
    public partial class frmTempConverterClient : Form
    {
        public frmTempConverterClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTempConverterClient_Load(object sender, EventArgs e)
        {
            cbxFrom.SelectedIndex = 1;
            cbxTo.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.WebService1SoapClient();
            string from = cbxFrom.SelectedItem.ToString();
            string to = cbxTo.SelectedItem.ToString();
            float value;
            if (!Single.TryParse(txtValue.Text, out value))
            {
                MessageBox.Show("Please enter a valid temperature.", "Invalid Temperature");
            }
            if (from == "Fluid" && to == "Ounce")
            {
                txtResult.Text = client.fluidToOunce(value).ToString();
            }
            if (from == "Gallon" && to == "Pint")
            {
                txtResult.Text = client.gallToPint(value).ToString();
            }
            if (from == "Cup" && to == "Mill")
            {
                txtResult.Text = client.cupToMill(value).ToString();
            }
            if (from == "Pint" && to == "Gill")
            {
                txtResult.Text = client.pintToGill(value).ToString();
            }
            if (from == "Pint" && to == "Ounce")
            {
                txtResult.Text = client.pintToFluidOunce(value).ToString();
            }
            if (from == "Quart" && to == "Mill")
            {
                txtResult.Text = client.quartToMill(value).ToString();
            }
            if (from == "Gallon" && to == "Quart")
            {
                txtResult.Text = client.gallToQuart(value).ToString();
            }
            if (from == "Gallon" && to == "Pint")
            {
                txtResult.Text = client.gallToPint(value).ToString();
            }
            if (from == "Barrel" && to == "Litres")
            {
                txtResult.Text = client.BarToLitres(value).ToString();
            }
            if (from == to)
            {
                txtResult.Text = txtValue.Text;
            }
        }
    }
}
