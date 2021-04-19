using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        /// <summary>
        /// Valida si el string por parametro es numerico o no
        /// </summary>
        /// <param name="strNumero">string</param>
        /// <returns>Retorna el numero ingresado si es numerico o 0 si no lo es</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno=0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }
        
        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        
        /// <summary>
        /// Constructor que inicializa el campo numero en el double pasado por parametro
        /// </summary>
        /// <param name="numero">double</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor sin parametros que inicializa el campo numero en 0. 
        /// </summary>
        public Numero() : this(0)
        {
            
        }
        /// <summary>
        /// Constructor que inicializa el campo numero en el valor del string por parametro
        /// </summary>
        /// <param name="cadena">string</param>
        public Numero(string cadena)
        {
            SetNumero = cadena;
        }
        /// <summary>
        /// Valida si la cadena pasada por parametro es un numero binario o no
        /// </summary>
        /// <param name="cadena">string</param>
        /// <returns>Retorna true si lo es o false si no lo es</returns>
        private static bool EsBinario(string cadena)
        {
            bool retorno = true;
            int tam = cadena.Length;
            foreach (char c in cadena)
            {
                if (c != '0' && c != '1')
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }
        /// <summary>
        /// Convierte un numero binario ingresado por parametro a decimal
        /// </summary>
        /// <param name="binario">string</param>
        /// <returns>Retorna una cadena con el valor del numero convertido a decimal si el numero es binario, o el mensaje Valor invalido si no lo es.</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "";
            double acumulador = 0;
            double cantCifras;
            int i;
            

            if (EsBinario(binario))
            {
                cantCifras = binario.Length;
                for (i = 0; i < cantCifras; i++)
                {
                    
                    if (binario[i] == '1')
                    {
                        acumulador = acumulador + Math.Pow(2, cantCifras - i - 1);
                    }
                }
                retorno = Convert.ToString(acumulador);
            }
            else
            {
                retorno = "Valor invalido.";
            }
            return retorno;
        }
        /// <summary>
        /// Transforma un numero ingresado por parametro a binario 
        /// </summary>
        /// <param name="numero">double</param>
        /// <returns>Retorna una cadena con el numero binario.</returns>
        public static string DecimalBinario(double numero)
        {
            
            string retorno = "";
            string buffer = "";
            int aux = (int)numero;

            for (int i = 0; aux > 0; i++)
            {
                
                if (aux % 2 == 0)
                {
                    buffer += "0";

                }
                else
                {
                    buffer += "1";

                }
                aux = aux / 2;

            }
            
            foreach (char letra in buffer)
            {
                
                retorno = letra + retorno;
            }

            return retorno;
        }
        /// <summary>
        /// Transforma un numero ingresado por parametro a binario 
        /// </summary>
        /// <param name="numero">string</param>
        /// <returns>Retorna una cadena con el numero binario.</returns>
        public static string DecimalBinario(string numero)
        {
           
            double auxCalculo = 0;
            string retorno = "Valor invalido";

           
            if (double.TryParse(numero, out auxCalculo))
            {
                retorno = DecimalBinario(auxCalculo);
            }
            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (n2.numero == 0)
            {
                retorno = double.MinValue;

            }
            else
            {
                retorno= n1.numero / n2.numero;
            }

            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

    }
}
