namespace RogueLike
{
    internal class Renderer
    {
        public int _fps;
        public Renderer() => _fps = 60;
        public Renderer(int fps) => _fps = fps;
        public void RenderFrame(Room room) {
            for (int X = 0; X < room._SizeX; X++) {
                for (int Y = 0; Y < room._SizeY; Y++)
                    Console.Write("{0,2}", room._objs[X, Y]._img._symbol);
                Console.WriteLine();
            }
                
        }
        public void ClearFrame() => Console.Clear();
    }
}
