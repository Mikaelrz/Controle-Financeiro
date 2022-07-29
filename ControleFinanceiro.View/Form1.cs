using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class Form1 : Form
    {
        string email = "ceci@gmail.com", senha = "123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * O que é uma variável?
             * Tipos de variáveis
             * Declarar ou emitir o tipo
             */

           
            email = TextBox.Text;
            senha = TextBox.Text;
            


            MessageBox.Show("Vó Cecília seu email {email} está correto?)");
            MessageBox.Show("Olá C#!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }