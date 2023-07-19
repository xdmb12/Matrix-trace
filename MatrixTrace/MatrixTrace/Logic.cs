namespace MatrixTrace;

public class Logic
{
    public int SumDiagonal(int[,] matrix)
    {
        if (matrix == null) return 0;
        var row = matrix.GetUpperBound(0) + 1;
        if (row == 0) return 0;
        var col = matrix.Length / row;
        var trace = 0;

        for (var i = 0; i < row; i++)
            if (i < col)
                trace += matrix[i, i];

        return trace;
    }

    public int[,] CreatMatrix(int row, int col)
    {
        var rd = new Random();
        var matrix1 = new int[row, col];

        for (var i = 0; i < row; i++)
        for (var j = 0; j < col; j++)
            matrix1[i, j] = rd.Next(0, 101);
        return matrix1;
    }

    public string SpiralPrint(int m, int n, int[,] a)
    {
        if ((n == 0 && m == 0) || a == null) return "0";
        int i, k = 0, l = 0;
        var resultSpiral = new List<int>();

        while (k < m && l < n)
        {
            for (i = l; i < n; ++i) resultSpiral.Add(a[k, i]);
            k++;


            for (i = k; i < m; ++i) resultSpiral.Add(a[i, n - 1]);
            n--;


            if (k < m)
            {
                for (i = n - 1; i >= l; --i) resultSpiral.Add(a[m - 1, i]);
                m--;
            }


            if (l < n)
            {
                for (i = m - 1; i >= k; --i) resultSpiral.Add(a[i, l]);
                l++;
            }
        }

        return string.Join(" ", resultSpiral);
    }
}