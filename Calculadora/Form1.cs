using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double primeiroRegistro;
        string operador;


        public Form1()
        {
            InitializeComponent();

        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "3";
        }


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtPainel.Text += ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            primeiroRegistro = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text = "";
            operador = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            primeiroRegistro = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text = "";
            operador = "-";
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            primeiroRegistro = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text = "";
            operador = "%";
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            primeiroRegistro = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text = "";
            operador = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            primeiroRegistro = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text = "";
            operador = "/";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtPainel.Text = "";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double segundoRegistro;
            double resultado;

            segundoRegistro = Convert.ToDouble(txtPainel.Text);

            //if (operador == "+")
            //{
            //    resultado = (primeiroRegistro + segundoRegistro);
            //    txtPainel.Text = Convert.ToString(resultado);
            //    primeiroRegistro = resultado;
            //}
            //if (operador == "-")
            //{
            //    resultado = (primeiroRegistro - segundoRegistro);
            //    txtPainel.Text = Convert.ToString(resultado);
            //    primeiroRegistro = resultado;
            //}
            //if (operador == "*")
            //{
            //    resultado = (primeiroRegistro * segundoRegistro);
            //    txtPainel.Text = Convert.ToString(resultado);
            //    primeiroRegistro = resultado;
            //}
            //if (operador == "/")
            //{
            //    resultado = (primeiroRegistro / segundoRegistro);
            //    txtPainel.Text = Convert.ToString(resultado);
            //    primeiroRegistro = resultado;
            //}
            //if (operador == "%")
            //{
            //    resultado = (primeiroRegistro % segundoRegistro);
            //    txtPainel.Text = Convert.ToString(resultado);
            //    primeiroRegistro = resultado;
            //}

            switch (operador)
            {
                case "+":
                resultado = (primeiroRegistro + segundoRegistro);
                    txtPainel.Text = Convert.ToString(resultado);
                    primeiroRegistro = resultado;
                    break;

                case "-":
                    resultado = (primeiroRegistro - segundoRegistro);
                    txtPainel.Text = Convert.ToString(resultado);
                    primeiroRegistro = resultado;
                    break;

                case "*":
                    resultado = (primeiroRegistro * segundoRegistro);
                    txtPainel.Text = Convert.ToString(resultado);
                    primeiroRegistro = resultado;
                    break;

                case "/":
                    resultado = (primeiroRegistro / segundoRegistro);
                    txtPainel.Text = Convert.ToString(resultado);
                    primeiroRegistro = resultado;
                    break;

                case "%":
                    resultado = (primeiroRegistro % segundoRegistro);
                    txtPainel.Text = Convert.ToString(resultado);
                    primeiroRegistro = resultado;
                    break;
            }
        }
    }
    }


