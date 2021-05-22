using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.model
{
    public class Regla
    {

        //Representa el caracter nulo de una gramatica.
        public const char LAMBDA = '&';

        public char generador;

        public List<string> producciones;


        //CONSTRUCTOR -----------------------------------------------------------------
        public Regla(char pgenerador, List<string> pproducciones)
        {
            generador = pgenerador;
            producciones = pproducciones;
        }

        /// Determina si la regla contiene una produccion pasada como parametro
        /// Retorna true si la regla contiene la produccion. En caso contrario, retorna false.

        public bool contieneProduccion(string prod)
        {
            return producciones.Contains(prod);
        }
    }
}
