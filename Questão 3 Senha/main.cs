using System;

class Program {
    static void Main(string[] args) {
        int caso = 1;
        
        for(;;) // Laço infinito que será interrompido manualmente
        {
            // Leitura da quantidade de dígitos da senha
            int N = int.Parse(Console.ReadLine());

            // Condição de parada
            if (N == 0) break;

            // Leitura dos níveis de oleosidade
            double[] oleosidade = new double[10];
            string[] entrada = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < 10; i++) {
                oleosidade[i] = double.Parse(entrada[i]);
            }

            // Array para armazenar os dígitos 0-9 e seus níveis de oleosidade
            int[] digitos = new int[10];
            for (int i = 0; i < 10; i++) {
                digitos[i] = i;
            }

            // Ordenação manual dos dígitos de acordo com a oleosidade e valor dos dígitos
            for (int i = 0; i < 9; i++) {
                for (int j = i + 1; j < 10; j++) {
                    if (oleosidade[i] < oleosidade[j] || 
                        (oleosidade[i] == oleosidade[j] && digitos[i] > digitos[j])) {
                        
                        // Troca oleosidade
                        double tempOleosidade = oleosidade[i];
                        oleosidade[i] = oleosidade[j];
                        oleosidade[j] = tempOleosidade;

                        // Troca dígitos
                        int tempDigito = digitos[i];
                        digitos[i] = digitos[j];
                        digitos[j] = tempDigito;
                    }
                }
            }

            // Exibição do resultado
            Console.Write($"Caso {caso}: ");
            for (int i = 0; i < N; i++) {
                Console.Write(digitos[i]);
            }
            Console.WriteLine();

            caso++;
        }
    }
}
