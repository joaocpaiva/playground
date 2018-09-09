using Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests.Stack
{
    [TestClass]
    public class DailyTemperatureTests
    {
        [TestMethod]
        public void TestDailyTemperature()
        {
            var dailyTemperatures = new DailyTemperatures();

            var expected = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };
            var result = dailyTemperatures.CountDaysForWarmWeather(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
