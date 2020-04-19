using System;
using DateTimeCheckerApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class TestDaysInMonthFunction {
        [TestMethod]
        public void UTCID01() => Assert.AreEqual(29, Utilities.DaysInMonth(2016, 2));

        [TestMethod]
        public void UTCID02() => Assert.AreEqual(30, Utilities.DaysInMonth(2016, 11));

        [TestMethod]
        public void UTCID03() => Assert.AreEqual(31, Utilities.DaysInMonth(2016, 12));

        [TestMethod]
        public void UTCID04() => Assert.AreEqual(28, Utilities.DaysInMonth(2017, 02));

        [TestMethod]
        public void UTCID05() => Assert.AreEqual(30, Utilities.DaysInMonth(2017, 11));

        [TestMethod]
        public void UTCID06() => Assert.AreEqual(31, Utilities.DaysInMonth(2017, 12));

        [TestMethod]
        public void UTCID07() => Assert.AreEqual(28, Utilities.DaysInMonth(2100, 02));

        [TestMethod]
        public void UTCID08() => Assert.AreEqual(0, Utilities.DaysInMonth(2016, 13));

    }
}
