using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KidsLogicaMatematica
{
    public partial class Divisao : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                quantidadeCalculos.Value = "10";
                divisao();
            }
        }

        public void divisao()       {
            

            Random numeroAliaturio = new Random();           

            if (quantidadeCalculos.Value != "0")
            {
                //int valorFinal1 = numeroAliaturio.Next(1, 11);
                //int valorInicial1 = numeroAliaturio.Next(0, 10);

                //valorInicial1 = numero(valorFinal1, valorInicial1);

                int valorFinal1 = 0;
                int valorInicial1 = 0;
                int resto = 0;
                bool inteiro = false;
                bool maiorq = false;
                do
                {
                    valorFinal1 = numeroAliaturio.Next(1, 11);
                    valorInicial1 = numeroAliaturio.Next(1, 101);
                    inteiro = (valorInicial1 / valorFinal1) == (int)(valorInicial1 / valorFinal1);

                        resto = valorInicial1 % valorFinal1;
                    maiorq = valorInicial1 >= valorFinal1;
                } while (resto != 0 && inteiro && maiorq);

                valorIni.Value = valorInicial1.ToString();
                valorFim.Value = valorFinal1.ToString();

                calcula.InnerText = valorInicial1.ToString() + " ÷ " + valorFinal1.ToString() + " = ?";
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
            var valor = int.Parse(valorIni.Value) / int.Parse(valorFim.Value);
            StringBuilder sb = new StringBuilder();
            if (valorFim.Value != numeroImagem2.Value)
            {
                ltImg.Text += sb.Append("<img src='img/pirulito.jpeg' height='50' />").ToString();
                numeroImagem.Value = (int.Parse(numeroImagem.Value) + 1).ToString();
                if (numeroImagem.Value == valor.ToString())
                {
                    StringBuilder sbp = new StringBuilder();
                    ltImg.Text += sbp.Append("← <img src='img/kids (" + numeroImagem2.Value + ").jpeg' height='50' /><br>").ToString();
                    numeroImagem.Value = "0";
                    numeroImagem2.Value = (int.Parse(numeroImagem2.Value) + 1).ToString();
                }
            }
        }

        protected void btnverificar_Click(object sender, EventArgs e)
        {
            var numero = string.IsNullOrEmpty(txtnumero.Text) ? "0" : txtnumero.Text;
            var total = int.Parse(valorIni.Value) / int.Parse(valorFim.Value);
            if (total == int.Parse(numero))
            {

                acertos.Value += "1";
                divisao();
            }
            else
            {

                erros.Value += "1";
                divisao();
            }
        }


        public int numero(int valorFim, int valorinicial)
        {           

            int[] numeros1 = new int[10];
            numeros1[0] = 1;
            numeros1[1] = 2;
            numeros1[2] = 3;
            numeros1[3] = 4;
            numeros1[4] = 5;
            numeros1[5] = 6;
            numeros1[6] = 7;
            numeros1[7] = 8;
            numeros1[8] = 9;
            numeros1[9] = 10;
            int[] numeros2 = new int[10];
            numeros2[0] = 2;
            numeros2[1] = 4;
            numeros2[2] = 6;
            numeros2[3] = 8;
            numeros2[4] = 10;
            numeros2[5] = 12;
            numeros2[6] = 14;
            numeros2[7] = 16;
            numeros2[8] = 18;
            numeros2[9] = 20;
            int[] numeros3 = new int[10];
            numeros3[0] = 3;
            numeros3[1] = 6;
            numeros3[2] = 9;
            numeros3[3] = 12;
            numeros3[4] = 15;
            numeros3[5] = 18;
            numeros3[6] = 21;
            numeros3[7] = 24;
            numeros3[8] = 27;
            numeros3[9] = 30;
            int[] numeros4 = new int[10];
            numeros4[0] = 4;
            numeros4[1] = 8;
            numeros4[2] = 12;
            numeros4[3] = 16;
            numeros4[4] = 20;
            numeros4[5] = 24;
            numeros4[6] = 28;
            numeros4[7] = 32;
            numeros4[8] = 36;
            numeros4[9] = 40;
            int[] numeros5 = new int[10];
            numeros5[0] = 5;
            numeros5[1] = 10;
            numeros5[2] = 15;
            numeros5[3] = 20;
            numeros5[4] = 25;
            numeros5[5] = 30;
            numeros5[6] = 35;
            numeros5[7] = 40;
            numeros5[8] = 45;
            numeros5[9] = 50;


            int[] numeros6 = new int[10];
            numeros6[0] = 6;
            numeros6[1] = 12;
            numeros6[2] = 18;
            numeros6[3] = 24;
            numeros6[4] = 30;
            numeros6[5] = 36;
            numeros6[6] = 42;
            numeros6[7] = 48;
            numeros6[8] = 54;
            numeros6[9] = 60;
            int[] numeros7 = new int[10];
            numeros7[0] = 7;
            numeros7[1] = 14;
            numeros7[2] = 21;
            numeros7[3] = 28;
            numeros7[4] = 35;
            numeros7[5] = 42;
            numeros7[6] = 49;
            numeros7[7] = 56;
            numeros7[8] = 63;
            numeros7[9] = 70;
            int[] numeros8 = new int[10];
            numeros8[0] = 8;
            numeros8[1] = 16;
            numeros8[2] = 24;
            numeros8[3] = 32;
            numeros8[4] = 40;
            numeros8[5] = 48;
            numeros8[6] = 56;
            numeros8[7] = 64;
            numeros8[8] = 72;
            numeros8[9] = 80;
            int[] numeros9 = new int[10];
            numeros9[0] = 9;
            numeros9[1] = 18;
            numeros9[2] = 27;
            numeros9[3] = 36;
            numeros9[4] = 45;
            numeros9[5] = 54;
            numeros9[6] = 63;
            numeros9[7] = 72;
            numeros9[8] = 81;
            numeros9[9] = 90;
            int[] numeros10 = new int[10];
            numeros10[0] = 10;
            numeros10[1] = 20;
            numeros10[2] = 30;
            numeros10[3] = 40;
            numeros10[4] = 50;
            numeros10[5] = 60;
            numeros10[6] = 70;
            numeros10[7] = 80;
            numeros10[8] = 90;
            numeros10[9] = 100;


            var numeroRetorno = 0;
            switch (valorFim)
            {
                case 1:
                    numeroRetorno = numeros1[valorinicial];
                    break;
                case 2:
                    numeroRetorno = numeros2[valorinicial];
                    break;
                case 3:
                    numeroRetorno = numeros3[valorinicial];
                    break;
                case 4:
                    numeroRetorno = numeros4[valorinicial];
                    break;
                case 5:
                    numeroRetorno = numeros5[valorinicial];
                    break;

                case 6:
                    numeroRetorno = numeros6[valorinicial];
                    break;
                case 7:
                    numeroRetorno = numeros7[valorinicial];
                    break;
                case 8:
                    numeroRetorno = numeros8[valorinicial];
                    break;
                case 9:
                    numeroRetorno = numeros9[valorinicial];
                    break;
                case 10:
                    numeroRetorno = numeros10[valorinicial];
                    break;
            }

            return numeroRetorno;
        }
    }
}