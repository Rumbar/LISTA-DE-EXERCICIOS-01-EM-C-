using System;

class Programa
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Informe a quantidade inicial de postes:");
        int quantidadePostes = int.Parse(Console.ReadLine());

        while (quantidadePostes != 0)
        {
            int[] estadosPostes = new int[quantidadePostes];
            //Console.WriteLine("Informe o estado de cada poste (0 ou 1):");
            string[] entradaEstados = Console.ReadLine().Split(' ');

            for (int indice = 0; indice < quantidadePostes; indice++)
            {
                estadosPostes[indice] = int.Parse(entradaEstados[indice]);
            }

            int postesConstruidos = 0;
            if (estadosPostes[quantidadePostes - 1] == 0 && estadosPostes[0] == 0)
            {
                postesConstruidos++;
                estadosPostes[0] = 1;
            }

            for (int indice = 0; indice < quantidadePostes - 1; indice++)
            {
                if (estadosPostes[indice] == 0 && estadosPostes[indice + 1] == 0)
                {
                    postesConstruidos++;
                    estadosPostes[indice + 1] = 1;
                }
            }

            Console.WriteLine(postesConstruidos);
            //Console.WriteLine("Informe a quantidade inicial de postes:");
            quantidadePostes = int.Parse(Console.ReadLine());
        }
    }
}
