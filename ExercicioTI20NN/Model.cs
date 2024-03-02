using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Model
    {

        //Construtor
        public Model()
        {

        }//fim do método construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i = 0; i < 10; i++)
            {
                resultado += "\n" + (i + 1);
            }

            return resultado;
        }//fim do método

        //Exercício 02: Faça um programa que imprima ps números pares de 1 a 20
        public string ExercicioDois()
        {
            string resultado = "";

            for(int i=0; i < 20; i++)
            {
                if((i+1) % 2 == 0)
                {
                    resultado = "\n" + (i + 1);
                }//Fim do if
            }//Fim do for

            return resultado;
        }//Fim do Exercício Dois

        public int ExercicioTres()
        {
            int resultado = 0;

            for (int i = 1; i <= 100; i++)
            {
                resultado += i;
            }// Fim do for

            return resultado;
        }//  Fim do Exercício Três

        //Exercício 04: Faça um programa que imprima os múltiplos de 5 de 1 50.
        public string ExercicioQuatro()
        {
            string resultado = "";

            for (int i = 1; i <=50; i++)
            {
                if(( i+1 ) % 5 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim if 
            }//Fim for

           return resultado;

        }//Fim Exercício Quatro 

        //Exercício 05: Faça um programa que peça ao usuário um número e imprima se é par ou impar
        public string ExercicioCinco(int num)
        {

            if( num % 2 == 0)
            {
                return "Par";

            }//Fim do If
            else
            {
               return "Impar";
            }//Fim do Else
        }//Fim do Exercício Cinco

        //Exercício 06: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.
    public string ExercicioSeis(int num1)
        {
            if( num1 > 0)
            {
                return "Positivo!";
            }// Fim do If
            else if ( num1 == 0)
            {
                return "Zero!";
            }// Fim do else if
            else
            {
                return "Negativo!";
            }// Fim do else
            
        }// Fim do Exercício Seis

        //Exercício 07: Faça um programa que peça para o usuário digitar um número e imprima a tabuada desse número.
        public string ExercicioSete(int num2)
        {
            string resultado = "";

            for(int i=0; i <= 10; i++)
            {
                resultado += num2 + " * " + i + " = " + (num2 * i) + "\n";
            }//Fim do for

            return resultado;
        }//Fim do Exercício Sete

        //Exercício 08: Faça um programa que peça ao usuário um número e imprima os números de 1 até esse número.
        public string ExercicioOito(int num3)
        {
            string resultado = "";

            for (int i = 1; i <= num3; i++)
            {
                resultado += i + "\n"; 
            }//Fim do for

            return resultado;
        }//Fim do Exercício Oito

        //Exercício 09: Faça um programa que peça ao usuário um número e imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num4)
        {
            int resultado = 0;

            for(int i = 0; i <= num4; i++)
            {
                resultado += i;
            }// Fim do for

            return resultado;

        }//Fim do Exercício Nove

        //Exercício 10: Faça um programa que impríma os números primos de 1 a 20.
        public string ExercicioDez()
        {
            string resultado = "2\n3\n5\n";

            for(int i = 2; i <= 20; i++)
            {
                if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    resultado += i + "\n";
                }//Fim do if
                
            }//Fim do for

            return resultado;

        }//Fim do Exercício Dez
           
    }//fim da classe
}//fim do projeto
