using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace Lf_progra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<char> _numeros = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        List<char> _variables = new List<char>(new char[] { 'A', 'B', 'C','D','E','F','G','H','I','J',
                                'K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'});
        List<char> _operadores = new List<char>(new char[] { '+', '-', '*', '/' });
        List<char> _delimitadores = new List<char>(new char[] { '(', ')' });
        DataTable _tblResultados = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        // private void frmPrincipal_Load(object sender, EventArgs e)
        // {
        //_tblResultados.Columns.Add("Token", typeof(char));
        //  _tblResultados.Columns.Add("Tipo", typeof(string));
        //}



        private void Boton_Limpiar(object sender, RoutedEventArgs e)
        {
            /*Codigo del boton */
            txtExpresion.Clear();
            txtResultados.Clear();
        }

        private void Boton_Analizar(object sender, RoutedEventArgs e)
        {
            /*Codigo del boton */
            // Console.WriteLine("Le has dado al boton 2");



            List<char> _elementos = txtExpresion.Text.Replace(" ", "").ToCharArray().ToList();

            if (_elementos.Count > 0)
            {
              //  DataRow _fila;

                foreach (char elemento in _elementos)
                {
                   /// _fila = _tblResultados.NewRow();

                    if (_numeros.Contains(elemento))
                    {
                        //String nuevo = elemento.ToString();
                        // _fila["Token"] = elemento;
                        //  _fila["Tipo"] = "Número";
                        txtResultados.AppendText("token= " + elemento.ToString() + " de tipo numero\n"); // = elemento;
                        //_fila["Tipo"] = "Número";
                    }
                    else if (_variables.Contains(elemento.ToString().ToUpper()[0]))
                    {
                        txtResultados.AppendText("token= " + elemento.ToString() + " de tipo variable\n");
                    }
                    else if (_operadores.Contains(elemento))
                    {
                        txtResultados.AppendText("token= " + elemento.ToString() + " de tipo operador\n"); // = elemento;

                    }
                    else if (_delimitadores.Contains(elemento))
                    {
                        txtResultados.AppendText("token= " + elemento.ToString() + " de tipo delimitador\n"); // = elemento;


                    }
                    else
                    {
                        txtResultados.AppendText("token= " + elemento.ToString() + " de tipo signo\n"); // = elemento;


                    }
                    // _tblResultados.Rows.Add(_fila);
                    //txtResultados.AppendText("");

                }


                //dgvResultados.DataSource = _tblResultados;
                // dgvResultados.Refresh();
            }
            else
            {
                // dgvResultados.DataSource = null;
                //dgvResultados.Refresh();
            }


        }


    }
}
