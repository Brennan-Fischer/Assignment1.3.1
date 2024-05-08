namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int readResult;

            do
            {
                Console.WriteLine("Select one of the following menu options by inputing corresponding number 1-4");
                Console.WriteLine("1. Calculate area of a triangle");
                Console.WriteLine("2. Calculate area of a square");
                Console.WriteLine("3. Calculate area of a rectangle");
                Console.WriteLine("4. Exit");
                readResult = Convert.ToInt32(Console.ReadLine());
                switch (readResult)
                {
                    case 1:
                        CalculateAreaOfTriangle();
                        break;
                    case 2:
                        CalculateAreaOfSquare();
                        break;
                    case 3:
                        CalculateAreaOfRectangle();
                        break;
                    case 4:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;

                }
            }
            while (readResult != 4);
        }
        static void CalculateAreaOfTriangle()
        {
            Console.WriteLine("Input height of Triangle");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input base of Triangle");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            double triangleArea = triangleHeight * triangleBase / 2;
            Console.WriteLine("The area of the triangle is " + triangleArea);

        }
        static void CalculateAreaOfSquare()
        {
            Console.WriteLine("Input length of square");
            double squareLength = Convert.ToDouble(Console.ReadLine());
            double squareArea = squareLength * squareLength;
            Console.WriteLine("The area of the square is " + squareArea);
        }
        static void CalculateAreaOfRectangle()
        {
            Console.WriteLine("Input height of the rectangle");
            double rectangleHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input length of the rectangle");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = rectangleHeight * rectangleLength;
            Console.WriteLine("The area of the rectangle is " + rectangleArea);
        }
    }
}
