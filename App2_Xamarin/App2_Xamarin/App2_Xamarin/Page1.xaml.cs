using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            botaoExecutar.Clicked += botaoExecutar_Clicked;
        }

         private void botaoExecutar_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(entradaValor.Text);
            string resp = "O número " + entradaValor.Text + "é: ";
            if (n%2 == 0)
            {
                resp += "par";
            }
            else
            {
                resp += "ímpar";
            }
            labelResposta.Text = resp;
        }
    }
}