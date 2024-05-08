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
        System.Console.WriteLine("a - furlong");
        System.Console.WriteLine("b - rod");
        System.Console.WriteLine("c - fathom");
        System.Console.WriteLine("d - yard");
        System.Console.WriteLine("e - foot");
        System.Console.WriteLine("f - inch");
    }
    public static double convertToIntermediate(char from, double value)
    {
        switch (from)
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
                return value * 0.001;
            case '8':
                return value * 1852;
            case '9':
                return value * 1609;
            case 'a':
                return value * 201;
            case 'b':
                return value * 5.829;
            case 'c':
                return value * 1.829;
            case 'd':
                return value * 0.9144;
            case 'e':
                return value * 0.3048;
            case 'f':
                return value * 0.0254;
            default:
                return value * 1;
        }
    }
    public static double convertToFinal(char to, double value)
    {
        switch (to)
        {
            case '1':
                return value / 1000;
            case '2':
                return value / 100;
            case '3':
                return value / 10;
            case '4':
                return value / 1;
            case '5':
                return value / 0.1;
            case '6':
                return value / 0.01;
            case '7':
                return value / 0.001;
            case '8':
                return value / 1852;
            case '9':
                return value / 1609;
            case 'a':
                return value / 201;
            case 'b':
                return value / 5.829;
            case 'c':
                return value / 1.829;
            case 'd':
                return value / 0.9144;
            case 'e':
                return value / 0.3048;
            case 'f':
                return value / 0.0254;
            default:
                return value / 1;
        }
    }
    public static void Main(string[] args)
    {
        string from;
        double value;
        string to;
        System.Console.WriteLine("Select input unit");
        WriteUnits();
        from = Console.ReadLine();
        System.Console.WriteLine("Enter value for comversion");
        value = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Select output unit");
        WriteUnits();
        to = Console.ReadLine();
        System.Console.Write("Output:");
        System.Console.WriteLine(convertToFinal(to[0], convertToIntermediate(from[0], value)));
    }
}