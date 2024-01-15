public class SquareTest

{

    public static void Main(String[] args)

    {

        Square square = new Square();

        Console.WriteLine(square);

        square = new Square(2.3);

        Console.WriteLine(square);

        square = new Square(5.8, "yellow", true);

        Console.WriteLine(square);

    }

}