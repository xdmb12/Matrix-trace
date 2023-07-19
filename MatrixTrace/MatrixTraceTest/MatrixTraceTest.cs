using MatrixTrace;

namespace MatrixTraceTest;

public class MatrixTest
{
    private readonly Logic _mt = new();

    [Fact]
    public void TraceTest1()
    {
        int[,] _mtx1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(15, result);
    }

    [Fact]
    public void TraceTest2()
    {
        int[,] _mtx1 = null;
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(0, result);
    }

    [Fact]
    public void TraceTest3()
    {
        int[,] _mtx1 = { { 0 } };
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(0, result);
    }

    [Fact]
    public void TraceTest4()
    {
        int[,] _mtx1 = { { 47, 38, 44 }, { 4, 2, 72 }, { 9, 20, 82 }, { 84, 9, 85 } };
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(131, result);
    }

    [Fact]
    public void TraceTest5()
    {
        int[,] _mtx1 = { { 55, 80, 85 }, { 87, 8, 20 } };
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(63, result);
    }

    [Fact]
    public void TraceTest6()
    {
        int[,] _mtx1 = { { } };
        var result = _mt.SumDiagonal(_mtx1);
        Assert.Equal(0, result);
    }


    [Fact]
    public void SpiralTest1()
    {
        int[,] _mtx1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var row = 3;
        var col = 3;
        Assert.Equal("1 2 3 6 9 8 7 4 5", _mt.SpiralPrint(row, col, _mtx1));
    }

    [Fact]
    public void SpiralTest2()
    {
        int[,] _mtx1 = { { 69, 17, 17, 50 }, { 22, 56, 7, 53 }, { 79, 73, 55, 99 } };
        var row = 3;
        var col = 4;
        Assert.Equal("69 17 17 50 53 99 55 73 79 22 56 7", _mt.SpiralPrint(row, col, _mtx1));
    }

    [Fact]
    public void SpiralTest3()
    {
        int[,] _mtx1 = { { 55, 80, 85 }, { 87, 8, 20 } };
        var row = 2;
        var col = 3;
        Assert.Equal("55 80 85 20 8 87", _mt.SpiralPrint(row, col, _mtx1));
    }

    [Fact]
    public void SpiralTest4()
    {
        int[,] _mtx1 = { { 0 } };
        var row = 0;
        var col = 0;
        Assert.Equal("0", _mt.SpiralPrint(row, col, _mtx1));
    }

    [Fact]
    public void SpiralTest5()
    {
        int[,] _mtx1 = { { } };
        var row = 0;
        var col = 0;
        Assert.Equal("0", _mt.SpiralPrint(row, col, _mtx1));
    }
}