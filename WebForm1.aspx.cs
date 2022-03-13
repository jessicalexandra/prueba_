using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace institucion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            double promedio, unidades, valorpagar, descuento, subtota, total;
            int area;

           

            promedio = Convert.ToDouble(txtnum1.Text);

            area = Convert.ToInt32(txtnum2.Text);

            

            if (area == 1)
            {
                if (promedio >= 9.5)
                {
                    unidades = 55;
                    subtota = unidades * 5;
                    total = subtota * 180;
                    descuento = total * 0.25;
                    valorpagar = total - descuento;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar;
                }
                else if (promedio >= 9)
                {
                    unidades = 50;
                    subtota = unidades * 5;
                    total = subtota * 180;
                    descuento = total * 0.10;
                    valorpagar = total - descuento;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar ;
                }
                else if (promedio > 7)
                {
                    unidades = 50;
                    subtota = unidades * 5;
                    total = subtota * 180;
                    valorpagar = total;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar;
                }
                else if (promedio == 7 | promedio < 7)
                {
                    unidades = 45;
                    subtota = unidades * 3;
                    total = subtota * 180;
                    valorpagar = total;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar ;
                }
                else if (promedio == 7 | promedio < 7)
                {
                    unidades = 40;
                    subtota = unidades * 4;
                    total = subtota * 180;
                    valorpagar = total;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar ;
                }
            }
            if (area == 2)
            {
                if (promedio >= 9.5)
                {
                    unidades = 55;
                    subtota = unidades * 5;
                    total = subtota * 300;
                    descuento = total * 0.20;
                    valorpagar = total - descuento;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar ;
                }
                else if (promedio < 9.5)
                {
                    unidades = 55;
                    subtota = unidades * 5;
                    total = subtota * 300;
                    valorpagar = total;
                    lblResul.Text = "El total a pagar en la colegiatura es de: " + valorpagar ;
                }
            }
        }
    }
}
    
