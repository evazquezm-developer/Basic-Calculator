public class Program
{
    // Definicion del delegate.
    public delegate int MathOperation (int a, int b);

    public static void Main()
    {
        Calculator calculator = new Calculator();

        // Crea una instancia por cada delegado.
        MathOperation add       = new MathOperation ( calculator.Add );
        MathOperation substract = new MathOperation ( calculator.Substract );
        MathOperation divide    = new MathOperation ( calculator.Divide );
        MathOperation multiply  = new MathOperation ( calculator.Multiply );

        // Invoca cada uno de los delegados.
        Console.WriteLine( "Addition  : " + add      ( 6, 2 ) );
        Console.WriteLine( "Substract : " + substract( 6, 2 ) );
        Console.WriteLine( "Divide    : " + divide   ( 6, 2 ) );
        Console.WriteLine( "Multiply  : " + multiply ( 6, 2 ) );
    }   
}