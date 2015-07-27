using System.Collections.Generic;
using NUnit.Framework;

namespace Minesweeper2.Tests
{
    public class GridRendererTests
    {
        [Test]
        public void UnexploredCellIsRepresentedByAHash()
        {
            var grid = new Grid(1, 1);
            Assert.AreEqual("#\n", GridRenderer.RenderGrid(grid));
        }

        [Test]
        public void RenderedGridIsSameSizeAsPassedGrid()
        {
            var grid = new Grid(2, 3);
            Assert.AreEqual("##\n##\n##\n", GridRenderer.RenderGrid(grid));
        }
    }
}
