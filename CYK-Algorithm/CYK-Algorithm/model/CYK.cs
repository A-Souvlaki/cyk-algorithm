using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.model
{
    public class CYK
    {
        //terminales en la gramatica
        public List<char> terminales;

        //matriz para la gramatica
        public List<string>[,] matriz;

        //Reglas de la gramatica
        public List<Regla> reglas;

        //Representa todas las variables utilizadas.
        public List<char> variables;

        //variables posibles
        public List<char> variablesPosibles = new List<char>(){ 'A','B','C', 'D', 'E','F','G','H','I','J','K','L','M',
             'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};


    
        /// Genera un objeto Gramatica a partir de una cadena de texto que contiene la gramatica expresada en 
        /// un formato como el siguiente:
        /// S : aX |bX
        /// X : aY |bY
        /// Y : X  |c
        /// Lanza excepciones en los casos siguientes:
        /// CASO 1: Regla no respeta el formato de separacion por ":"
        /// CASO 2: La parte izquierda de una regla es mas de un caracter (tamaño mayor a 1)
        /// CASO 3: La parte izquierda de una regla no es una letra mayuscula
        /// CASO 4: Una produccion contiene un caracter que no es un terminal, variable o labmda
        /// CASO 5: Una produccion contiene labmda y mas caracteres.
        public CYK(string texto)
        {
            reglas = new List<Regla>();
            variables = new List<char>();
            terminales = new List<char>();

            string[] lineas = texto.Split('\n');
            for (int i = 0; i < lineas.Count(); i++)
            {
                string linea = lineas.ElementAt(i);

                if (linea != null && linea.Trim().Count() != 0)
                {
                    linea = linea.Replace(" ", "");

                    //VERIFICACION 1
                    String[] partes = linea.Split(':');
                    if (partes.Length != 2)
                    {
                        throw new Exception("Regla sin el formato : " + linea);
                    }

                    if (partes[0].Length != 1)
                    {
                        throw new Exception("La parte izquierda de una regla debe ser un caracter");
                    }

                    //VERIFICACION 2
                    char generador = partes[0].ElementAt(0);
                    if (generador < 'A' || generador > 'Z' || generador.Equals(Regla.LAMBDA))
                    {
                        throw new Exception("El generador debe ser una letra mayuscula");
                    }

                    //VERIFICACION 3
                    string[] producciones = partes[1].Split('|');
                    for (int j = 0; j < producciones.Count(); j++)
                    {
                        string prod = producciones.ElementAt(j).Trim(); //quito espacios en blanco que pueden quedar

                        //examino cada caracter de la produccion 
                        for (int z = 0; z < prod.Count(); z++)
                        {
                            char c = prod.ElementAt(z);
                            if (c.Equals(Regla.LAMBDA) == false)
                            {
                                if (Char.IsLetter(c) == false)
                                {
                                    throw new Exception("el caracter " + c + " no es un terminal o variable");
                                }
                                //---------------------------
                                else if (Char.IsLower(c))
                                {
                                    if (terminales.Contains(c) == false)
                                    {
                                        terminales.Add(c);
                                    }
                                }
                                else if (Char.IsUpper(c))
                                {
                                    if (variables.Contains(c) == false)
                                    {
                                        variables.Add(c);
                                        variablesPosibles.Remove(c);
                                    }
                                }
                                //-----------------------------
                            }
                            else
                            {
                                if (prod.Count() > 1)
                                {
                                    throw new Exception("Lambda no es un caracter valido de la FNC");
                                }
                            }
                        }

                        producciones[j] = prod;
                    }

                    //si llego hasta aqui es que no hubo ningun problema con el formato
                    Regla nueva = new Regla(generador, producciones.ToList<string>());
                    reglas.Add(nueva);

                    //-----------------------
                    if (variables.Contains(generador) == false)
                    {
                        variables.Add(generador);
                    }
                    //-------------------------

                }
            }
        }


        /// Metodo que implementa el algoritmo CYK para determinar si la gramatica genera una determinada cadena 
        /// pasada como parametro. Se asume que la gramatica ya ha sido convertida a su FNC.
        /// Se tiene el atributo "matriz" para comprobar como el algoritmo se desarrollo.
        /// Retorna true si la gramatica genera la cadena pasada como parametro. En caso contrario, retorna false
        public bool algoritmoCYK(string cadena)
        {
            cadena = cadena.Trim();
            //comprobacion del formato de la cadena -----------------
            if (cadena.Count() == 0)
            {
                throw new Exception("Debe especificar una cadena no vacia");
            }
            foreach (var c in cadena)
            {
                if (terminales.Contains(c) == false)
                {
                    throw new Exception("La cadena contiene caracteres que no existen en el alfabeto de la gramatica");
                }
            }
            //-------------------------------------------------------

            bool respuesta = false;

            int n = cadena.Count();
            matriz = new List<string>[n, n];


            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                {
                    //Recorrido por la cadena
                    for (int x = 0; x < cadena.Count(); x++)
                    {
                        char caracter = cadena.ElementAt(x);

                        List<string> list = darGeneradoresDeAlMenosUnaDeLasProducciones
                            (new List<string>() { caracter.ToString() });


                        matriz[x, j - 1] = list;

                    }

                }
                else
                {
                    for (int i = 1; i <= n - j + 1; i++)
                    {
                        List<string> generadores = new List<string>();

                        for (int k = 1; k <= j - 1; k++)
                        {
                            List<string> lista1 = matriz[i - 1, k - 1];
                            List<string> lista2 = matriz[i + k - 1, j - k - 1];

                            List<string> posibles = generarPosiblesProducciones(lista1, lista2);
                            List<string> gen = darGeneradoresDeAlMenosUnaDeLasProducciones(posibles);

                            generadores = generadores.Union(gen).ToList<string>();
                        }
                        matriz[i - 1, j - 1] = generadores;
                    }
                }
            }

            List<string> lista = matriz[0, n - 1];
            if (lista.Contains("S"))
            {
                respuesta = true;
            }

            return respuesta;
        }

        /// Obtiene las variables que en su regla asociada producen alguna de las producciones pasadas como parametro
        /// Lista de string que representa las producciones
        /// Una lista de string con las variables

        public List<string> darGeneradoresDeAlMenosUnaDeLasProducciones(List<string> producciones)
        {
            List<string> respuesta = new List<string>();

            foreach (string prod in producciones)
            {
                foreach (Regla reg in reglas)
                {
                    if (reg.contieneProduccion(prod))
                    {
                        string generador = reg.generador.ToString();
                        if (respuesta.Contains(generador) == false)
                        {
                            respuesta.Add(generador);
                        }
                    }
                }
            }

            return respuesta;
        }

        /// Genera producciones a partir de dos listas cuyo contenido son variables. Metodo utilizado en el metodo
        /// que implementa el algorito CYK.
        /// Retorna una lista de string con las nuevas producciones
 
        public List<string> generarPosiblesProducciones(List<string> lista1, List<string> lista2)
        {
            List<string> respuesta = new List<string>();

            if (lista1.Count() == 0 && lista2.Count() > 0)
            {
                respuesta = lista2;
            }
            else if (lista1.Count() > 0 && lista2.Count() == 0)
            {
                respuesta = lista1;
            }
            else if (lista1.Count() > 0 && lista2.Count() > 0)
            {
                for (int i = 0; i < lista1.Count(); i++)
                {
                    string cad1 = lista1.ElementAt(i);

                    for (int j = 0; j < lista2.Count(); j++)
                    {
                        string cad2 = lista2.ElementAt(j);
                        string nuevo = cad1 + cad2;
                        respuesta.Add(nuevo);
                    }
                }
            }

            return respuesta;
        }

    }
}
