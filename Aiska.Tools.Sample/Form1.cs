using System;
using System.Windows.Forms;

namespace Aiska.Tools.Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(InputTxt.Text);
                ResultTxt.Text = value.Terbilang();
            }
            catch (Exception)
            {
                ResultTxt.Text = "Angka yang anda masukkan salah.";
            }
        }
    }
}
