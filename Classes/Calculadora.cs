using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculadora
    {
        public static int Soma(int num1 , int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public static int Subtracao(int num1,int num2)
        {
            int res = num1 - num2;
            return res;
        }
        public static int Divisao(int num1, int num2)
        {
            int res = num1 / num2;
            return res;
        }
        public static int Multiplicacao(int num1, int num2)
        {
            int res = num1 * num2;
            return res;
        }
    }
}