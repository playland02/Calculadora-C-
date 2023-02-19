using System;
using Classes;

namespace A04
{
    class Program
    {

        public const int SAIR_DA_CALCU = 1;
        public const int SOMAR = 2;
        public const int SUBTRACAO = 3;
        public const int DIVISAO = 4;
        public const int MULTIPLICACAO = 5;
        static void Main()
        {
            while (true)
            {
                int opcao = 0;
                Console.WriteLine("Digite: {0} para sair da calculadora!", SAIR_DA_CALCU);
                Console.WriteLine("Digite: {0} para somar ",SOMAR);
                Console.WriteLine("Digite: {0} para subtrair", SUBTRACAO);
                Console.WriteLine("Digite: {0} para dividir",DIVISAO);
                Console.WriteLine("Digite {0} para multiplicar",MULTIPLICACAO);
                
                opcao = Convert.ToInt32(Console.ReadLine());

               
                if(opcao == SAIR_DA_CALCU)
                {
                    Console.WriteLine("Você digitou 1 e saiu do programa");
                    break;
                }
                else if(opcao == SOMAR)
                {
                    int val1,val2,res;
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    res = Calculadora.Soma(val1,val2);

                    Console.WriteLine("A soma de {0} + {1} é igual a: {2}",val1,val2,res);
                }    
                else if(opcao == SUBTRACAO)
                {
                    int val1,val2,res;
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    res = Calculadora.Subtracao(val1,val2);

                    Console.WriteLine("A subtração de {0} - {1} é igual a: {2}",val1,val2,res);
                }
                else if(opcao == DIVISAO)
                {
                    int val1,val2,res;
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    res = Calculadora.Divisao(val1,val2);
                    
                    Console.WriteLine("A divisão de {0} / {1} é igual a:{2}",val1,val2,res);
                }
                else if(opcao == MULTIPLICACAO)
                {
                    int val1,val2,res;
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    res = Calculadora.Multiplicacao(val1,val2);
                    
                    Console.WriteLine("A multiplicação de {0} x {1} é igual a:{2}",val1,val2,res);

                }
                
                else{
                    Console.WriteLine("Opcão invalida digite um numero entre 1 a 2");
                }        

            }
        }

    }
}
