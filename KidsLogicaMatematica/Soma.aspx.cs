using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KidsLogicaMatematica
{
    public partial class Soma : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                quantidadeCalculos.Value = "10";
                soma();
            }           
        }

        public void soma()
        {

            Random numeroAliaturio = new Random();
            if (quantidadeCalculos.Value != "0")
            {
                int valorInicial1 = numeroAliaturio.Next(0, 11);
                int valorFinal1 = numeroAliaturio.Next(0, 11);
                valorIni.Value = valorInicial1.ToString();
                valorFim.Value = valorFinal1.ToString();

                calculaSoma.InnerText = valorInicial1.ToString() + " + " + valorFinal1.ToString() + " = ?";
                numeroImagem.Value = "0";
                numeroImagem2.Value = "0";
                img.Visible = false;
                img2.Visible = false;
                divimg.Visible = false;
                txtnumero.Text = string.Empty;
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

        protected void btnMaisImg_Click(object sender, EventArgs e)
        {
            divimg.Visible = true;
            if (int.Parse(numeroImagem.Value) < int.Parse(valorIni.Value))
            {
                img.Visible = true;
                numeroImagem.Value = (int.Parse(numeroImagem.Value) + 1).ToString();
                var qualImagem = "img/" + numeroImagem.Value + ".jpeg";
                img.Attributes.Remove("src");
                img.Attributes.Add("src", qualImagem);
            }
            else
            {
                if (int.Parse(numeroImagem2.Value) < int.Parse(valorFim.Value))
                {
                    img2.Visible = true;
                    numeroImagem2.Value = (int.Parse(numeroImagem2.Value) + 1).ToString();
                    var qualImagem = "img/" + numeroImagem2.Value + ".jpeg";
                    img2.Attributes.Remove("src");
                    img2.Attributes.Add("src", qualImagem);
                }
            }
        }

        protected void btnverificar_Click(object sender, EventArgs e)
        {
            var numero = string.IsNullOrEmpty(txtnumero.Text) ? "0" : txtnumero.Text;
            var total = int.Parse(valorIni.Value) + int.Parse(valorFim.Value);
            if (total == int.Parse(numero))
            {
                
                acertos.Value += "1";
                soma();
            }
            else
            {
                
                erros.Value += "1";
                soma();
            }
        }
    }
}