using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region propiedades
        ServiceReference1.WebService1SoapClient cliente = new ServiceReference1.WebService1SoapClient();
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = cliente.Areatriangulo(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
            label8.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = cliente.Areacirculo(Convert.ToDouble(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = cliente.Areacuadrado(Convert.ToDecimal(textBox4.Text)).ToString();
        }
    }
}
