//Author: Andrei Rico
//Purpose: Test Class
//Known bugs: N/A
//Date: 12/10/2017

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImperialVolumeToMetric1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialVolumeToMetric1.Tests
{
    [TestClass()]
    public class ImperialVolumeToMetricTests
    {
        [TestMethod()]
        public void flOzTest()
        {
            float fluid = 1F;
            float expected = 28.41307F;
            float actual = ImperialVolumeToMetric.flOz(fluid);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void gillTTest()
        {
            float gill = 1F;
            float expected = 142.07F;
            float actual = ImperialVolumeToMetric.gillToMl(gill);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void cupToMlTest()
        {
            float cup = 1F;
            float expected = 284.1307F;
            float actual = ImperialVolumeToMetric.cupToMl(cup);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pintToGillTest()
        {
            float pintG = 1F;
            float expected = 568.2615F;
            float actual = ImperialVolumeToMetric.pintToGill(pintG);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pintToFlOzTest()
        {
            float pintFl = 1F;
            float expected = 0.56826F;
            float actual = ImperialVolumeToMetric.pintToFlOz(pintFl);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void quartToMlTest()
        {
            float quart = 1F;
            float expected = 1136.523F;
            float actual = ImperialVolumeToMetric.quartToMl(quart);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void gallonToQuartTest()
        {
            float gallQ = 1F;
            float expected = 4546.09F;
            float actual = ImperialVolumeToMetric.gallonToQuart(gallQ);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void gallonToPintTest()
        {
            float gallP = 1F;
            float expected = 4.54609F;
            float actual = ImperialVolumeToMetric.gallonToPint(gallP);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void barrelToLitresTest()
        {
            float barrel = 1F;
            float expected = 136.2748F;
            float actual = ImperialVolumeToMetric.barrelToLitres(barrel);
            Assert.AreEqual(expected, actual);
        }
    }
}