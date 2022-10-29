using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KidsLogicaMatematica
{
    public partial class Subtracao : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                quantidadeCalculos.Value = "10";
                subtracao();
            }
        }

        public void subtracao()
        {
            Random numeroAliaturio = new Random();
            if (quantidadeCalculos.Value != "0")
            {
                int valorInicial1 = numeroAliaturio.Next(0, 11);
                int valorFinal1 = numeroAliaturio.Next(0, valorInicial1 + 1);
                valorIni.Value = valorInicial1.ToString();
                valorFim.Value = valorFinal1.ToString();

                calcula.InnerText = valorInicial1.ToString() + " - " + valorFinal1.ToString() + " = ?";
                numeroImagem.Value = valorIni.Value;
                numeroImagem2.Value = valorFim.Value;

                divimg.Visible = true;
                var qualImagem = "img/" + valorIni.Value + ".jpeg";
                img.Attributes.Remove("src");
                img.Attributes.Add("src", qualImagem);
                txtnumero.Text = string.Empty;
                if (valorIni.Value == "0")
                {
                    divimg.Visible = false;
                }
                img2.Visible = false;

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
                }
                else
                {
                    imgVerificacao.Visible = true;
                    verificar.Visible = true;
                    verificar.InnerText = "Ahh tente fazer o teste novamente";
                    imgVerificacao.Attributes.Remove("src");
                    imgVerificacao.Attributes.Add("src", "img/triste.jpeg");
                }

            }
        }

        protected void btnMenosImg_Click(object sender, EventArgs e)
        {

            if (numeroImagem2.Value != "0")
            {
                numeroImagem.Value = (int.Parse(numeroImagem.Value) - 1).ToString();
                var qualImagem = "img/" + numeroImagem.Value + ".jpeg";
                img.Attributes.Remove("src");
                img.Attributes.Add("src", qualImagem);
                numeroImagem2.Value = (int.Parse(numeroImagem2.Value) - 1).ToString();

                if (valorIni.Value == valorFim.Value && numeroImagem2.Value == "0")
                {
                    divimg.Visible = false;
                }
            }
                      
        }

        protected void btnverificar_Click(object sender, EventArgs e)
        {
            var numero = string.IsNullOrEmpty(txtnumero.Text) ? "0" : txtnumero.Text;
            var total = int.Parse(valorIni.Value) - int.Parse(valorFim.Value);
            if (total == int.Parse(numero))
            {
                
                acertos.Value += "1";
                subtracao();
            }
            else
            {
              
                erros.Value += "1";
                subtracao();
            }
        }
    }
}