namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            static int Divide(int a, int b){
                return a / b;}
            
            static int Quotient(int a, int b)
            {
                return a % b;
            }
            
            static double AreaOfCircle(double radius)
            {
                var area = Math.PI * Math.Pow(radius, 2);

                return area;
            }
            Console.WriteLine("What is the radius of your circle");
            var userInput = Console.ReadLine();
            double radius = double.Parse(userInput);
            Console.WriteLine($"The area of circle is {AreaOfCircle(radius)}");
            
            
            Console.WriteLine("Enter a number to divide");
            int div1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number to divide");
            int div2 = int.Parse(Console.ReadLine());
            int divided = Divide(div1, div2);
            Console.WriteLine($"{div1} / {div2} = {divided} remainder {Quotient(div1, div2)}");
        }
    }
}
