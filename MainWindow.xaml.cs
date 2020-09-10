using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Lf_progra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string palabra;
        private string[] conjuntoCadena;

        public MainWindow()
        {
            InitializeComponent();
            txtResultados.IsEnabled = false;
        }

        //funcionalidad del boton limpiar que limpia los cuadros de texto
        private void Boton_Limpiar(object sender, RoutedEventArgs e)
        {
            /*Codigo del boton */
            txtExpresion.Clear();
            txtResultados.Clear();
        }

        //funcionalidad del boton analizar 
        private void Boton_Analizar(object sender, RoutedEventArgs e)
        {
            /*Codigo del boton */
            palabra = txtExpresion.Text;
            conjuntoCadena = palabra.Split(' ');

            for (int i = 0; i < conjuntoCadena.Length; i++)
            {
                string local = conjuntoCadena[i].ToString();
                int esnumero = 0;
                decimal esdecimal = 0;

                //determina si es numero entero
                if ((int.TryParse(local, out esnumero)) == true)
                {

                    txtResultados.AppendText("token =  " + esnumero + " >> es de tipo numero entero \n");
                }
                //determina si es un numero  decimal
                else if ((decimal.TryParse(local, out esdecimal)) == true)
                {

                    txtResultados.AppendText("token =  " + esdecimal + " >> es de tipo numero decimal \n");
                }
                //determina si el conjunto de caracteres es una palabra o es una moneda
                else if (char.IsNumber(local, 0) == false)
                {
                    char[] chars = local.ToCharArray();
                    if (chars[0].Equals('Q'))
                    {
                        string valor = "";
                        for (int ctr = 1; ctr < chars.Length; ctr++)
                        {
                            valor += chars[ctr].ToString();
                        }
                        if ((decimal.TryParse(valor, out esdecimal)) == true)
                        {
                            txtResultados.AppendText("token =  " + local + " >> es de tipo moneda \n");

                        } else
                        {
                            txtResultados.AppendText("token =  " + local + " >> es de tipo palabra \n");

                        }

                    } else
                    {
                        txtResultados.AppendText("token =  " + local + " >> es de tipo palabra \n");
                    }

                    MessageBox.Show("Archivo creado.");

                }

            }

        }

    }
}
