using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Limpia los valores al hacer click en el boton Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Limpia los valores cargando los elementos a cadenas vacias.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblLabel.Text = "";
            cmbOperador.Text = "";
        }
        /// <summary>
        /// Realiza una operacion matematica al hacer click en el boton operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblLabel.Text = Convert.ToString(resultado);
        }
        /// <summary>
        /// Realiza una operacion matematica entre dos numeros
        /// </summary>
        /// <param name="Numero1">string</param>
        /// <param name="Numero2">string</param>
        /// <param name="Operador">string</param>
        /// <returns>Retorna un double con el resultado de la operacion.</returns>
        private static double Operar(string Numero1, string Numero2, string Operador)
        {
            double resultado = 0;
            Numero num1 = new Numero(Numero1);
            Numero num2 = new Numero(Numero2);

            resultado = Calculadora.Operar(num1, num2, Operador);
            return resultado;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Cierra el programa al hacer click en el boton cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Convierte el resultado de una operacion de decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click_Click(object sender, EventArgs e)
        {
            lblLabel.Text = Numero.DecimalBinario(lblLabel.Text);
        }
        /// <summary>
        /// Convierte el resultado de una operacion de binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click_Click(object sender, EventArgs e)
        {
            lblLabel.Text = Numero.BinarioDecimal(lblLabel.Text);
        }

        
    }
}
