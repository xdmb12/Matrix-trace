namespace MatrixTrace;

public class UserOutput
{
    public void MatrixTrace(int row, int col)
    {
        var mtLogic = new Logic();
        var matrix1 = mtLogic.CreatMatrix(row, col);
        PrintMatrix(matrix1);
        Console.WriteLine($"Matrix trace: {mtLogic.SumDiagonal(matrix1)}");
    }

    public void MatrixSpiral(int row, int col)
    {
        var mtLogic = new Logic();
        var matrix1 = mtLogic.CreatMatrix(row, col);
        PrintMatrix(matrix1);
        Console.WriteLine(mtLogic.SpiralPrint(row, col, matrix1));
    }


    public void PrintMatrix(int[,]? matrixArray)
    {
        if (matrixArray == null) return;
        var row = matrixArray.GetUpperBound(0) + 1;
        if (row == 0) return;
        var col = matrixArray.Length / row;

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < col; j++)
                if (i < col && matrixArray[i, j] == matrixArray[i, i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{matrixArray[i, j]} \t");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write($"{matrixArray[i, j]} \t");
                }

            Console.WriteLine();
        }
    }
}