public class Program
{
    public static void WriteUnits()
    {
        System.Console.WriteLine("1 - kilometre");
        System.Console.WriteLine("2 - hectometre");
        System.Console.WriteLine("3 - decametre");
        System.Console.WriteLine("4 - metre");
        System.Console.WriteLine("5 - decimetre");
        System.Console.WriteLine("6 - centimetre");
        System.Console.WriteLine("7 - milimetre");
        System.Console.WriteLine("8 - nautical mile");
        System.Console.WriteLine("9 - mile");
        System.Console.WriteLine("10 - furlong");
        System.Console.WriteLine("11 - rod");
        System.Console.WriteLine("12 - fathom");
        System.Console.WriteLine("13 - yard");
        System.Console.WriteLine("14 - foot");
        System.Console.WriteLine("15 - inch");
    }
    public static int convertToIntermediate(char from, int value)
    {
        switch(from)
        {
            case '1':
            return value * 1000;
            case '2':
            return value * 100;
            case '3':
            return value * 10;
            case '4':
            return value * 1;
            case '5':
            return value * 0.1;
            case '6':
            return value * 0.01;
            case '7':
            return value * 0.001
            case '8':
            return value * 1852;
            case '9':
            return value * 1609;
            case '10':
            return value * 201;
            case '11':
            return value * 5.829;
            case '12':
            return value * 1.829;
            case '13':
            return value * 0.9144;
            case '14':
            return value * 0.3048;
            case '15':
            return value * 0.0254;
            default:
            return value * 1;
        }
    }
    public static int convertToFinal(char to, int value)
    {
        switch(to)
        {
            case '1':
            return value * 1000;
            case '2':
            return value * 100;
            case '3':
            return value * 10;
            case '4':
            return value * 1;
            case '5':
            return value * 0.1;
            case '6':
            return value * 0.01;
            case '7':
            return value * 0.001
            case '8':
            return value * 1852;
            case '9':
            return value * 1609;
            case '10':
            return value * 201;
            case '11':
            return value * 5.829;
            case '12':
            return value * 1.829;
            case '13':
            return value * 0.9144;
            case '14':
            return value * 0.3048;
            case '15':
            return value * 0.0254;
            default:
            return value * 1;
        }
    }
    public static void Main(string[] args)
    {
        string from;
        int value;
        string to;
        System.Console.WriteLine("Select input unit");
        WriteUnits();
        inp1 = Console.ReadLine();
        System.Console.WriteLine("Enter value for comversion");
        value = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Select output unit");
        WriteUnits();
        to = Console.ReadLine();
        System.Console.Write("Output:");
        System.Console.WriteLine(convertToFinal(to[0], convertToIntermediate(from[0], value)););
    }
}