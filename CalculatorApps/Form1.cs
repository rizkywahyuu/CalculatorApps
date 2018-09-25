using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            hasil.ReadOnly = true;

            operasiHitung.Items.Add("penambahan");
            operasiHitung.Items.Add("pengurangan");
            operasiHitung.Items.Add("perkalian");
            operasiHitung.Items.Add("pembagian");
            operasiHitung.SelectedItem = "penambahan";

        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtA.Text);
            var b = Convert.ToInt32(txtB.Text);
            string ambilOperasi = operasiHitung.Text;

            if (ambilOperasi == "penambahan")
            {
                hasil.Text = Convert.ToString(penambahan(a, b));
            }
            else if (ambilOperasi == "pengurangan")
            {
                hasil.Text = Convert.ToString(pengurangan(a, b));
            }
            else if (ambilOperasi == "perkalian")
            {
                hasil.Text = Convert.ToString(perkalian(a, b));
            }
            else
            {
                hasil.Text = Convert.ToString(pembagian(a, b));
            }
        }
    }
}
