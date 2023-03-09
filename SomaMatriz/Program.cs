internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];

        matriz = populaMatriz(matriz);

        separaConsole();

        imprimeMatriz(matriz);

        separaConsole();

        somaLinhas(matriz);

        separaConsole();

        somaColunas(matriz);

        separaConsole();

        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal(matriz)}");

        separaConsole();

        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalSecundaria(matriz)}");

        separaConsole();

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

        void somaLinhas(int[,] matriz)
        {
            for(int linha = 0; linha < matriz.GetLength(0) ; linha++)
            {
                int somaLinhas = 0;
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    somaLinhas += matriz[linha, coluna];
                }
                Console.WriteLine($"Soma da {linha + 1}° linha: {somaLinhas}");
            }
        }

        void somaColunas(int[,] matriz)
        {
            for(int coluna = 0;  coluna < matriz.GetLength(1); coluna++)
            {
                int somaColunas = 0;
                for (int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    somaColunas += matriz[linha, coluna];
                }
                Console.WriteLine($"Soma da {coluna + 1}° coluna: {somaColunas}");
            }
        }

        void separaConsole()
        {
            Console.WriteLine("-------------------------------------");
        }
    }
}