using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        int estadoAtual = 1;
        string operador;
        double primeiroNum, segundoNum;


        public MainPage()
        {
            InitializeComponent();
            botaoLimpar(new object(), new EventArgs());
        }

        void selecionaOperador(object sender, EventArgs e)
        {
            estadoAtual = -2;
            Button button = (Button)sender;
            string pressiona = button.Text;
        }

        void botaoLimpar(object sender, EventArgs e)
        {
            primeiroNum = 0;
            segundoNum = 0;
            estadoAtual = 1;
            this.resultText.Text = "0";
        }

        void selecionaBotao(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressiona = button.Text;

            if (this.resultText.Text == "0" || estadoAtual < 0)
            {
                this.resultText.Text = "";
                if (estadoAtual < 0)
                {
                    estadoAtual *= -1;
                }

            }
            this.resultText.Text = pressiona;
            double num;

            if (double.TryParse(this.resultText.Text, out num))
            {
                this.resultText.Text = num.ToString("N0");

                if (estadoAtual == 1)
                {
                    primeiroNum = num;
                }
                else
                {
                    segundoNum = num;
                }
            }

            void realizaOperacao(object sender, EventArgs e)
            {
                if (estadoAtual == 2)
                {
                    var resultado = 0;
                    if (operador == "+")
                    {
                        resultado = primeiroNum + segundoNum;
                    }
                    if (operador == "-")
                    {
                        resultado = primeiroNum - segundoNum;
                    }
                    if (operador == "X")
                    {
                        resultado = primeiroNum * segundoNum;
                    }
                    if (operador == "/")
                    {
                        resultado = primeiroNum / segundoNum;
                    }

                    this.resultText.Text = resultado.ToString();
                    primeiroNum = resultado;
                    estadoAtual = -1;
                }
            }
        }

    }

}
