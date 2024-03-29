﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();
        }//fim do construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "7. Exercício 07\n" +
                              "8. Exercício 08\n" +
                              "9. Exercício 09\n" +
                              "10. Exercício 10\n");
        }//fim do menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                Menu();//Mostrando as opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine(modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine(modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioSeis(num1));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioSete(num2));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioOito(num3));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        int num4 = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioNove(num4));
                        break;
                    case 10:
                        Console.WriteLine(modelo.ExercicioDez());
                        break;
                    default:
                        Console.WriteLine("Código digitado não é válido!");
                        break;
                }//fim do método
            } while (opcao != 0);
        }//fim do operacao

    }//fim da classe
}//fim do projeto
