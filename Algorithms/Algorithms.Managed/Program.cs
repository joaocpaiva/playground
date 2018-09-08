using Algorithms.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var openTheLock = new OpenTheLock();
            openTheLock.OpenLock(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202");
        }
    }
}
