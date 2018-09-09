using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Stack
{
    /// <summary>
    /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// 
    /// An input string is valid if:
    ///    Open brackets must be closed by the same type of brackets.
    ///    Open brackets must be closed in the correct order.
    ///    Note that an empty string is also considered valid.
    ///
    /// Example 1:
    ///     Input: "()"
    ///     Output: true
    ///
    /// Example 2:
    ///     Input: "()[]{}"
    ///     Output: true
    ///
    /// Example 3:
    ///     Input: "(]"
    ///     Output: false
    ///
    /// Example 4:
    ///     Input: "([)]"
    ///     Output: false
    ///
    /// Example 5:
    ///     Input: "{[]}"
    ///     Output: true
    /// </summary>
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var parentheses = new Dictionary<char, char>()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' },
            };

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || stack.Pop() != parentheses[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
