internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];

        matriz = populaMatriz(matriz);

        imprimeMatriz(matriz);

        Console.WriteLine("--------------------------");

        imprimeVetor(percorreLinhas(matriz), "linha");

        Console.WriteLine("--------------------------");

        imprimeVetor(percorreColunas(matriz), "coluna");

        Console.WriteLine("--------------------------");

        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalSecundaria(matriz)}");

        //Funções
        void imprimeMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write($" | {matriz[linha, coluna]} | ");
                }
                Console.WriteLine();
            }
        }

        void imprimeVetor(int[] vetor, string texto)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Soma da {i+1}° {texto}: {vetor[i]}");
            }
        }

        int[,] populaMatriz(int[,] matriz)
        {
            Random numero = new();

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    matriz[linha, coluna] = numero.Next(100);
                }
            }

            return matriz;
        }

        int somaDiagonalPrincipal(int[,] matriz)
        {
            int somaDiagonalPrincipal = 0;
            for(int diagonal = 0; diagonal < 5; diagonal++)
            {
                somaDiagonalPrincipal += matriz[diagonal, diagonal];
            }

            return somaDiagonalPrincipal;
        }

        int somaDiagonalSecundaria(int[,] matriz)
        {
            int somaDiagonalSecundaria = 0;

            for (int diagonal = 0; diagonal < 5; diagonal++)
            {
                somaDiagonalSecundaria += matriz[4 - diagonal, diagonal];
            }

            return somaDiagonalSecundaria;
        }

        int somaLinhas(int[,] matriz, int linhaAtual)
        {
            int somaLinhas = 0;

            for(int linha = linhaAtual; linha == linhaAtual; linha++)
            {
                for(int coluna = 0; coluna < 5; coluna++)
                {
                    somaLinhas += matriz[linha, coluna];
                }
            }

            return somaLinhas;
        }

        int somaColunas(int[,] matriz, int colunaAtual)
        {
            int somaColunas = 0;

            for(int coluna = colunaAtual;  coluna == colunaAtual; coluna++)
            {
                for(int linha = 0; linha < 5; linha++)
                {
                    somaColunas += matriz[linha, coluna];
                }
            }

            return somaColunas;
        }

        int[] percorreLinhas(int[,] matriz)
        {
            int[] somas = new int[5];

            for(int i = 0; i < 5; i++)
            {
                somas[i] = somaLinhas(matriz, i);
            }

            return somas;
        }

        int[] percorreColunas(int[,] matriz)
        {
            int[] somas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                somas[i] = somaColunas(matriz, i);
            }

            return somas;
        }
    }
}