using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador ingresado para que represente alguna de las operaciones 
        /// </summary>
        /// <param name="operador">char</param>
        /// <returns>Cadena con el operador a utilizar</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            if (operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador.ToString();
            }
            return retorno;
        }
        /// <summary>
        /// Realiza una operacion matematica entre 2 numeros.
        /// </summary>
        /// <param name="num1">Numero</param>
        /// <param name="num2">Numero</param>
        /// <param name="operador">string</param>
        /// <returns>Retorna un double con el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            char c=char.Parse(operador);
            operador = ValidarOperador(c);

            switch (operador)
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
            }
            return retorno;
        }
    }

}
