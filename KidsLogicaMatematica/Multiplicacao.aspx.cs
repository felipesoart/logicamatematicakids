using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KidsLogicaMatematica
{
    public partial class Multiplicacao : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                quantidadeCalculos.Value = "10";
                multiplicacao();
            }
        }

        public void multiplicacao()
        {
            Random numeroAliaturio = new Random();
            if (quantidadeCalculos.Value != "0")
            {
                int valorInicial1 = numeroAliaturio.Next(0, 11);
                int valorFinal1 = numeroAliaturio.Next(0, 11);
                valorIni.Value = valorInicial1.ToString();
                valorFim.Value = valorFinal1.ToString();

                calcula.InnerText = valorInicial1.ToString() + " X " + valorFinal1.ToString() + " = ?";
                numeroImagem.Value = "0";
                numeroImagem2.Value = "0";
                ltImg.Text = string.Empty;
                txtnumero.Text= string.Empty;
                quantidadeCalculos.Value = (int.Parse(quantidadeCalculos.Value) - 1).ToString();
            }
            else
            {
                var qntAcerto = acertos.Value;
                var qntErros = erros.Value;

                if (qntAcerto.Length >= qntErros.Length)
                {
                    imgVerificacao.Visible = true;
                    verificar.Visible = true;
                    verificar.InnerText = "Parabéns";
                    imgVerificacao.Attributes.Remove("src");
                    imgVerificacao.Attributes.Add("src", "img/feliz.jpeg");
                    ltImg.Text = string.Empty;
                    txtnumero.Text = string.Empty;
                }
                else
                {
                    imgVerificacao.Visible = true;
                    verificar.Visible = true;
                    verificar.InnerText = "Ahh tente fazer o teste novamente";
                    imgVerificacao.Attributes.Remove("src");
                    imgVerificacao.Attributes.Add("src", "img/triste.jpeg");
                    ltImg.Text = string.Empty;
                    txtnumero.Text = string.Empty;
                }

            }
        }

        protected void btnMenosImg_Click(object sender, EventArgs e)
        {
            if (valorIni.Value != "0" && valorFim.Value != "0")
            {
                StringBuilder sb = new StringBuilder();
                if (valorIni.Value != numeroImagem2.Value)
                {
                    ltImg.Text += sb.Append("<img src='img/pirulito.jpeg' height='50' />").ToString();
                    numeroImagem.Value = (int.Parse(numeroImagem.Value) + 1).ToString();
                    if (numeroImagem.Value == valorFim.Value)
                    {
                        StringBuilder sbp = new StringBuilder();
                        ltImg.Text += sbp.Append("•<br>").ToString();
                        numeroImagem.Value = "0";
                        numeroImagem2.Value = (int.Parse(numeroImagem2.Value) + 1).ToString();
                    }
                }
            }            
        }

        protected void btnverificar_Click(object sender, EventArgs e)
        {
            var numero = string.IsNullOrEmpty(txtnumero.Text) ? "0" : txtnumero.Text;
            var total = int.Parse(valorIni.Value) * int.Parse(valorFim.Value);
            if (total == int.Parse(numero))
            {

                acertos.Value += "1";
                multiplicacao();
            }
            else
            {

                erros.Value += "1";
                multiplicacao();
            }
        }
    }
}