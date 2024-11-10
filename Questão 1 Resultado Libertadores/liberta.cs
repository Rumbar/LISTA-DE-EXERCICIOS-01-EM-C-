using System;

class Program {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine()); // Número de casos de teste

        for (int i = 0; i < N; i++) {
            // Leitura dos resultados
            string[] partida1 = Console.ReadLine().Split('x');
            string[] partida2 = Console.ReadLine().Split('x');

            int time1_partida1 = int.Parse(partida1[0]); // Time 1 (mandante) na partida 1
            int time2_partida1 = int.Parse(partida1[1]); // Time 2 (visitante) na partida 1
            int time2_partida2 = int.Parse(partida2[0]); // Time 2 (mandante) na partida 2
            int time1_partida2 = int.Parse(partida2[1]); // Time 1 (visitante) na partida 2

            // Critério 1: Pontuação total
            int pontosTime1 = 0, pontosTime2 = 0;

            if (time1_partida1 > time2_partida1) {
                pontosTime1 += 3; // Time 1 vence a primeira partida
            } else if (time1_partida1 < time2_partida1) {
                pontosTime2 += 3; // Time 2 vence a primeira partida
            } else {
                pontosTime1 += 1; // Empate na primeira partida
                pontosTime2 += 1;
            }

            if (time2_partida2 > time1_partida2) {
                pontosTime2 += 3; // Time 2 vence a segunda partida
            } else if (time2_partida2 < time1_partida2) {
                pontosTime1 += 3; // Time 1 vence a segunda partida
            } else {
                pontosTime1 += 1; // Empate na segunda partida
                pontosTime2 += 1;
            }

            // Se a pontuação é diferente, já temos um vencedor
            if (pontosTime1 > pontosTime2) {
                Console.WriteLine("Time 1");
            } else if (pontosTime2 > pontosTime1) {
                Console.WriteLine("Time 2");
            } else {
                // Critério 2: Saldo de gols
                int saldoGolsTime1 = (time1_partida1 + time1_partida2) - (time2_partida1 + time2_partida2);
                int saldoGolsTime2 = (time2_partida1 + time2_partida2) - (time1_partida1 + time1_partida2);

                if (saldoGolsTime1 > saldoGolsTime2) {
                    Console.WriteLine("Time 1");
                } else if (saldoGolsTime2 > saldoGolsTime1) {
                    Console.WriteLine("Time 2");
                } else {
                    // Critério 3: Gols marcados fora de casa
                    int golsForaTime1 = time1_partida2;
                    int golsForaTime2 = time2_partida1;

                    if (golsForaTime1 > golsForaTime2) {
                        Console.WriteLine("Time 1");
                    } else if (golsForaTime2 > golsForaTime1) {
                        Console.WriteLine("Time 2");
                    } else {
                        // Critério 4: Penaltis
                        Console.WriteLine("Penaltis");
                    }
                }
            }
        }
    }
}
