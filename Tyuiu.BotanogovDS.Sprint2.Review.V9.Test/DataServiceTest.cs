using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint2.Review.V9.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Review.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool ans = ds.CheckDotInShadedArea(0.6, 0.2);
            Assert.AreEqual(true, ans); 
        }
    }
}
