using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Queue
{
    /*
        Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
        An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
        You may assume all four edges of the grid are all surrounded by water.
       
        Example 1:
            
            Input:
                11110
                11010
                11000
                00000
            
            Output: 1
        
        Example 2:
     
            Input:
                11000
                11000
                00100
                00011
            
            Output: 3
    */

    /// <summary>
    /// Standard Breadth-first serach solution
    /// </summary>
    public class NumberOfIslands
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

                    Queue<int[]> queue = new Queue<int[]>();
                    queue.Enqueue(new int[2] { row, col });

                    while (queue.Count != 0)
                    {
                        int[] cell = queue.Dequeue();

                        // Check if right cell is 1
                        if (cell[0] < grid.GetLength(0) - 1 && grid[cell[0] + 1, cell[1]] == '1')
                        {
                            grid[cell[0] + 1, cell[1]] = '2';
                            queue.Enqueue(new int[2] { cell[0] + 1, cell[1] });
                        }

                        // Check if left cell is 1
                        if (cell[0] > 0 && grid[cell[0] - 1, cell[1]] == '1')
                        {
                            grid[cell[0] - 1, cell[1]] = '2';
                            queue.Enqueue(new int[2] { cell[0] - 1, cell[1] });
                        }

                        // Check if top cell is 1
                        if (cell[1] < grid.GetLength(1) - 1 && grid[cell[0], cell[1] + 1] == '1')
                        {
                            grid[cell[0], cell[1] + 1] = '2';
                            queue.Enqueue(new int[2] { cell[0], cell[1] + 1 });
                        }

                        // Check if bottom cell is 1
                        if (cell[1] > 0 && grid[cell[0], cell[1] - 1] == '1')
                        {
                            grid[cell[0], cell[1] - 1] = '2';
                            queue.Enqueue(new int[2] { cell[0], cell[1] - 1 });
                        }
                    }

                    count++;
                }
            }

            return count;
        }
    }
}
