using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.BFS
{
    /// <summary>
    /// Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.
    /// 
    /// Example 1:
    ///     Input: n = 12
    ///     Output: 3 
    ///     Explanation: 12 = 4 + 4 + 4.
    /// 
    /// Example 2:
    ///     Input: n = 13
    ///     Output: 2
    ///     Explanation: 13 = 4 + 9
    /// </summary>
    public class PerfectSquares
    {
        public int NumSquares(int n)
        {
            var queue = new Queue<int>();
            queue.Enqueue(0);

            int count = 0;
            var visited = new HashSet<int>();
            visited.Add(0);

            while (queue.Any())
            {
                int size = queue.Count();

                for (int i = 0; i < size; i++)
                {
                    int cur = queue.Dequeue();
                    if (cur > n)
                    {
                        continue;
                    }

                    if (cur == n)
                    {
                        return count;
                    }

                    int num = 0;
                    for (int j = 1; (num = cur + j * j) <= n; j++)
                    {
                        if (visited.Contains(num))
                        {
                            continue;
                        }

                        queue.Enqueue(num);
                        visited.Add(num);
                    }
                }

                count++;
            }

            return -1;
        }

        private bool IsPerferctSquare(int number)
        {
            return (Math.Sqrt((double)number) % 1 == 0);
        }
    }
}
