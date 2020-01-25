using System;
using System.Collections.Generic;

namespace ExercicioMatrizes2 {
    class Program {
        static void Main(string[] args) {
            string[] tamanhos = Console.ReadLine().Split(" ");
            int[,] mat = new int[int.Parse(tamanhos[0]), int.Parse(tamanhos[1])];
            LoopFill(ref mat);
            Around(FindIndex(mat), mat);


        }

        static void LoopFill(ref int[,] mat) {
            for (int i = 0; i < mat.GetLength(0); i++) {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
        }


        static List<int[]> FindIndex(int[,] mat) {
            List<int[]> indexes = new List<int[]>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    if(mat[i,j] == number) {
                        int[] index = new int[2];
                        index[0] = i;
                        index[1] = j;
                        indexes.Add(index);     
                    }

                }
            }
            return indexes;
        }

        static void Around(List<int[]> indexes, int[,] mat) {
            foreach (int[] index in indexes ) {
                Console.WriteLine($"Position {index[0]},{index[1]}: ");
                if(index[1] - 1 >= 0) {
                    Console.WriteLine($"Left: {mat[index[0], index[1]-1]}");
                }
                if(index[1] + 1 < mat.GetLength(1)) {
                    Console.WriteLine($"Right: {mat[index[0], index[1] + 1]}");
                }
                if(index[0] - 1 >= 0) {
                    Console.WriteLine($"Up: {mat[index[0] - 1, index[1]]}");
                }
                if(index[0] + 1 < mat.GetLength(0)) {
                    Console.WriteLine($"Down: {mat[index[0] + 1, index[1]]}");
                }
            }

        }
    }
}
