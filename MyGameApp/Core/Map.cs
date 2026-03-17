namespace MyGameApp.Core
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public char[,] Tiles { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new char[width, height];
        }
    }
}