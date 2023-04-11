namespace MyApp
{
    internal partial class Program
    {
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle.");
            }
        }
    }
}