using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePosto.Metodo
{
    class PostoMetodo
    {
        
        public static void PostoDeGasolina(string[] arrayCarros, int bombasGasolina)
        {

            int fila = 0;
            int bomba = 0;

            Console.WriteLine("Informe a quantidade de carros na fila");
            int.TryParse(Console.ReadLine(), out fila);


            string[] carro = new string[fila];
            int[] tempo = new int[fila];

            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine("Informe o nome do carro: ");
                carro[i] = Console.ReadLine();

                Console.WriteLine("Tempo de abastecimento: ");
                tempo[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe a quantidade de bombas");
            int.TryParse(Console.ReadLine(), out bomba);

            for (int i = fila-1; i >= 1; i--)
            {
                for (int n = 0; n < i; n++) {
                    for (int j = bomba - 1; j >= 1; j--)
                    {
                        while (tempo[j] != 0)
                        {
                            tempo[j] = tempo[j] - 1;
                        }
                    }
                }
            }

            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine("{0}, Tempo abastecimento: {1}", carro[i], tempo[i]);
            }

        }

    }

   
}
