using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Operaciones_Matemáticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox y convertirlos a números
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                // Realizar la suma y mostrar resultado
                double resultado = num1 + num2;
                results.Items.Add($"Suma: {num1} + {num2} = {resultado:F2}");
            }
            else
            {
                MessageBox.Show("-Ingrese numeros validos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double resultado = num1 - num2;
                results.Items.Add($"Resta: {num1} - {num2} = {resultado:F2}");
            }
            else
            {
                MessageBox.Show("-Ingrese numeros validos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double resultado = num1 * num2;
                results.Items.Add($"Multiplicación: {num1} x {num2} = {resultado:F2}");
            }
            else
            {
                MessageBox.Show("-Ingrese numeros validos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double resultado = num1 / num2;
                results.Items.Add($"División: {num1} / {num2} = {resultado:F2}");
            }
            else
            {
                MessageBox.Show("-Ingrese numeros validos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double resultado = (num1 * num2) / 100;
                    results.Items.Add($"Porcentaje: {num1} % de {num2} = {resultado:F2}");
                }
                else
                {
                    MessageBox.Show("El segundo número debe ser distinto de cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1))
            {
                double resultado = Math.Sqrt(num1);
                results.Items.Add($"Raiz: {num1} = {resultado:F2}");
            }
            else
            {
                MessageBox.Show("-Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            results.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
