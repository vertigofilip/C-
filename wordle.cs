public class Program
{
    public static void Main(string[] args)
    {
        char[,] table = new char[5,10];
        for( ; ; )
        {
            System.Console.WriteLine("WORDLE");
            for (int j = 0; j < 5; j++) System.Console.Write("|---|");
            for ( int i = 0 ; i < 10 ; i++ ) 
            {
                for (int j = 0; j < 5; j++) System.Console.Write("| " + table[i, j] + " |");
                for (int j = 0; j < 5; j++) System.Console.Write("|---|");
            }
        }
        System.Console.WriteLine("select ");
    }
}