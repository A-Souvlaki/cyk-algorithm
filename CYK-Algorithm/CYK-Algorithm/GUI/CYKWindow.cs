using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CYK_Algorithm.model;


namespace CYK_Algorithm.GUI
{
    public partial class CYKWindow : MetroFramework.Forms.MetroForm
    {
        CYK cyk;

        public CYKWindow()
        {
            InitializeComponent();
           

        }


        private void butAplicar_Click_1(object sender, EventArgs e)
        {
            if (txtGramatica.Text.Trim().Count() > 0)
            {
                try
                {
                    cyk = new CYK(txtGramatica.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe insertar una gramatica");
           
            }

            string cadena = txtCadena.Text.Trim();

            dGVMatriz.Columns.Clear();

            try
            {

                bool respuesta = cyk.algoritmoCYK(cadena);

                List<string>[,] matriz = cyk.matriz;

                //HACER VISIBLE LA MATRIZ
                dGVMatriz.ColumnCount = cadena.Count();
                dGVMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                for (int i = 0; i < cadena.Count(); i++)
                {
                    dGVMatriz.Columns[i].Name = "j = " + i;
                }

                for (int fila = 0; fila < cadena.Count(); fila++)
                {
                    dGVMatriz.Rows.Add();
                    for (int columna = 0; columna < cadena.Count(); columna++)
                    {
                        List<string> valor = matriz[fila, columna];
                        if (valor != null)
                        {
                            string s = "";
                            if (valor.Count() == 0)
                            {
                                s = "{ }";
                            }
                            else
                            {
                                foreach (var elemento in valor)
                                {
                                    s = s + elemento + " ";
                                }
                            }
                            dGVMatriz.Rows[fila].Cells[columna].Value = s;
                            
                        }
                    }
                }

                dGVMatriz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



                //RESPUESTA
                string resultado = respuesta ? "SÍ" : "NO";
                string mensaje = "La gramatica " + resultado + " genera la cadena: " + cadena;
                MetroFramework.MetroMessageBox.Show(this, mensaje,"Notificacion",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }

      
    }
}