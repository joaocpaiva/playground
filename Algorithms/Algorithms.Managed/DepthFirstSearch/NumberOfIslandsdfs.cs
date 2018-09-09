using System.Collections.Generic;

namespace Algorithms.DFS
{
    /// <summary>
    /// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
    /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
    /// You may assume all four edges of the grid are all surrounded by water.
    ///
    /// Example 1:
    ///     Input:
    ///         11110
    ///         11010
    ///         11000
    ///         00000
    ///     Output: 1
    ///
    /// Example 2:
    ///     Input:
    ///         11000
    ///         11000
    ///         00100
    ///         00011
    ///     Output: 3
    ///     
    /// </summary>
    public class NumberOfIslandsDFS
    {
        public int NumIslands(char[,] grid)
        {
            int count = 0;

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] != '1')
                    {
                        continue;
                    }

                    TraverseIsland(grid, row, col);

                    count++;
                }
            }

            return count;
        }

        private void TraverseIsland(char[,] grid, int row, int col)
        {
            // Check if right cell is 1
            if (row < grid.GetLength(0) - 1 && grid[row + 1, col] == '1')
            {
                grid[row + 1, col] = '2';
                TraverseIsland(grid, row + 1, col);
            }

            // Check if left cell is 1
            if (row > 0 && grid[row - 1, col] == '1')
            {
                grid[row - 1, col] = '2';
                TraverseIsland(grid, row - 1, col);
            }

            // Check if top cell is 1
            if (col < grid.GetLength(1) - 1 && grid[row, col + 1] == '1')
            {
                grid[row, col + 1] = '2';
                TraverseIsland(grid, row, col + 1);
            }

            // Check if bottom cell is 1
            if (col > 0 && grid[row, col - 1] == '1')
            {
                grid[row, col - 1] = '2';
                TraverseIsland(grid, row, col - 1);
            }
        }
    }
}
