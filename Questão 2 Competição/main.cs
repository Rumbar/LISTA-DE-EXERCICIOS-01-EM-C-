using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            // Ler o número de participantes (N) e problemas (M)
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            // Se N e M forem zero, parar o processamento
            if (N == 0 && M == 0) {
                break;
            }

            // Ler a matriz de resoluções
            int[,] competicao = new int[N, M];
            for (int i = 0; i < N; i++) {
                string[] resolucoes = Console.ReadLine().Split();
                for (int j = 0; j < M; j++) {
                    competicao[i, j] = int.Parse(resolucoes[j]);
                }
            }

            // Variáveis para controle das características
            int caracteristicas = 0;
            int nenhumResolveuTodos = 1;
            int todoProblemaResolvido = 1;
            int nenhumProblemaResolvidoPorTodos = 1;
            int todosResolveramUm = 1;

            // 1. Ninguém resolveu todos os problemas
            for (int i = 0; i < N; i++) {
                int resolveuTodos = 1;
                for (int j = 0; j < M; j++) {
                    if (competicao[i, j] == 0) {
                        resolveuTodos = 0;
                        break;
                    }
                }
                if (resolveuTodos == 1) {
                    nenhumResolveuTodos = 0;
                    break;
                }
            }

            // 2. Todo problema foi resolvido por pelo menos uma pessoa
            for (int j = 0; j < M; j++) {
                int algumResolveu = 0;
                for (int i = 0; i < N; i++) {
                    if (competicao[i, j] == 1) {
                        algumResolveu = 1;
                        break;
                    }
                }
                if (algumResolveu == 0) {
                    todoProblemaResolvido = 0;
                    break;
                }
            }

            // 3. Não há nenhum problema resolvido por todos
            for (int j = 0; j < M; j++) {
                int todosResolveram = 1;
                for (int i = 0; i < N; i++) {
                    if (competicao[i, j] == 0) {
                        todosResolveram = 0;
                        break;
                    }
                }
                if (todosResolveram == 1) {
                    nenhumProblemaResolvidoPorTodos = 0;
                    break;
                }
            }

            // 4. Todos resolveram ao menos um problema
            for (int i = 0; i < N; i++) {
                int resolveuAoMenosUm = 0;
                for (int j = 0; j < M; j++) {
                    if (competicao[i, j] == 1) {
                        resolveuAoMenosUm = 1;
                        break;
                    }
                }
                if (resolveuAoMenosUm == 0) {
                    todosResolveramUm = 0;
                    break;
                }
            }

            // Contar quantas características foram atingidas
            caracteristicas = nenhumResolveuTodos + todoProblemaResolvido + nenhumProblemaResolvidoPorTodos + todosResolveramUm;

            // Imprimir o número de características alcançadas
            Console.WriteLine(caracteristicas);
        }
    }
}
