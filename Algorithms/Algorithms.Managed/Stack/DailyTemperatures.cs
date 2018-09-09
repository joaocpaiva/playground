using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Stack
{
    /// <summary>
    /// Given a list of daily temperatures, produce a list that, for each day in the input, 
    /// tells you how many days you would have to wait until a warmer temperature. 
    /// If there is no future day for which this is possible, put 0 instead. 
    /// 
    /// For example, given the list temperatures = [73, 74, 75, 71, 69, 72, 76, 73], your output should be[1, 1, 4, 2, 1, 1, 0, 0]. 
    /// 
    /// Note: The length of temperatures will be in the range[1, 30000]. Each temperature will be an integer in the range[30, 100].
    /// </summary>
    public class DailyTemperatures
    {
        public int[] CountDaysForWarmWeather(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<int>();

            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
                {
                    stack.Pop();
                }

                result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;

                stack.Push(i);
            }

            return result;
        }
    }
}
