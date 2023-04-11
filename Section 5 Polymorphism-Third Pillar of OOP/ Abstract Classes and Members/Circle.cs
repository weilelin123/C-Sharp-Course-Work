namespace MyApp
{
    internal partial class Program
    {
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
            }
        }
    }
}