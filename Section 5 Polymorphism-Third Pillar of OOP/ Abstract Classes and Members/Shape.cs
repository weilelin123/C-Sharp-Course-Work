namespace MyApp
{
    internal partial class Program
    {
        public abstract class Shape
        {
           public int Width { get; set; }
           public int Height { get; set; }

            public abstract void Draw();

            public void Copy()
            {
                Console.WriteLine("Copy shape into clipboard.");
            }

            public void Select()
            {
                Console.WriteLine("Select the shape.");
            }
        }
    }
}