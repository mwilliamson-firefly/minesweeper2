using System;

namespace Minesweeper2
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(9, 9);

            Console.Write(GridRenderer.RenderGrid(grid));

            var coordinatesToSweep = CoordinateReader.Read(Console.ReadLine());
            var sweepedGrid = grid.Sweep(coordinatesToSweep);

            Console.Write(GridRenderer.RenderGrid(sweepedGrid));

            Console.ReadLine();
        }
    }
}
