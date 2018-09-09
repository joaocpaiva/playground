using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BFS
{
    /// <summary>
    /// You have a lock in front of you with 4 circular wheels. Each wheel has 10 slots: '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'. 
    /// The wheels can rotate freely and wrap around: for example we can turn '9' to be '0', or '0' to be '9'. 
    /// Each move consists of turning one wheel one slot. 
    /// 
    /// The lock initially starts at '0000', a string representing the state of the 4 wheels.
    /// 
    /// You are given a list of deadends dead ends, meaning if the lock displays any of these codes, 
    /// the wheels of the lock will stop turning and you will be unable to open it.
    /// 
    /// Given a target representing the value of the wheels that will unlock the lock,
    /// return the minimum total number of turns required to open the lock, or -1 if it is impossible.
    /// 
    /// Example 1:
    ///     Input: deadends = ["0201","0101","0102","1212","2002"], target = "0202"
    ///     Output: 6
    /// Explanation:
    ///     A sequence of valid moves would be "0000" -> "1000" -> "1100" -> "1200" -> "1201" -> "1202" -> "0202".
    ///     
    ///     Note that a sequence like "0000" -> "0001" -> "0002" -> "0102" -> "0202" would be invalid,
    ///     because the wheels of the lock become stuck after the display becomes the dead end "0102".
    /// </summary>
    public class OpenTheLock
    {
        public int OpenLock(string[] deadends, string target)
        {
            Dictionary<string, int> visited = new Dictionary<string, int>();
            foreach (var deadend in deadends)
            {
                if (!visited.ContainsKey(deadend))
                {
                    visited.Add(deadend, int.MaxValue);
                }
            }

            if (visited.ContainsKey("0000") || visited.ContainsKey(target))
            {
                return -1;
            }

            var queue = new Queue<string>();
            queue.Enqueue("0000");
            visited["0000"] = 0;

            while (queue.Any())
            {
                var current = queue.Dequeue();
                int countNodes = visited[current];
                if (current.Equals(target))
                {
                    return countNodes;
                }

                var combinations = GetNextCombinations(current);
                foreach (string combination in combinations)
                {
                    if (!visited.ContainsKey(combination))
                    {
                        queue.Enqueue(combination);
                        visited.Add(combination, countNodes + 1);
                    }
                }

            }

            return -1;
        }

        private List<string> GetNextCombinations(string current)
        {
            var result = new List<string>();
            var combination = new StringBuilder(current);
            for (int i = 0; i < current.Length; i++)
            {
                // Current slot
                char c = combination[i];

                // Increment slot
                char a = c == '9' ? '0' : (char)(c + 1);
                combination[i] = a;
                result.Add(combination.ToString());

                // Decrement slot
                char b = c == '0' ? '9' : (char)(c - 1);
                combination[i] = b;
                result.Add(combination.ToString());

                // Reset slot to inital value
                combination[i] = c;
            }

            return result;
        }

    }
}
