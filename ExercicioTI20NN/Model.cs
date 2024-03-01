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

    }//fim da classe
}//fim do projeto
