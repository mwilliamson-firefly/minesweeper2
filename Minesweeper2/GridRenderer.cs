using System;
using System.Text;

namespace Minesweeper2
{
    public static class GridRenderer
    {
        public static string RenderGrid(Grid grid)
        {
            StringBuilder finalString = new StringBuilder();

            for (int y = 0; y < grid.Height; y++)
            {
                string rowofhash = new string('#', grid.Width);
                finalString.Append(rowofhash + "\n");
            }
        
            return finalString.ToString();
        }
    }
}