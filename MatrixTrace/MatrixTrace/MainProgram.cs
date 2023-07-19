using MatrixTrace;

public class Program
{
    public static void Main(string[] args)
    {
        var mt = new UserOutput();
        Console.Write("Enter rows of your matrix: ");
        var row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter columns of your matrix: ");
        var col = Convert.ToInt32(Console.ReadLine());
        mt.MatrixTrace(row, col);
    }
}