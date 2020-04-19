using System;
using DateTimeCheckerApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class TestIsValidDateFunction {
        [TestMethod]
        public void UTCID01() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 02, 29));

        [TestMethod]
        public void UTCID02() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 11, 30));

        [TestMethod]
        public void UTCID03() => Assert.AreEqual(false, Utilities.IsValidDate(2000, 02, 31));

        [TestMethod]
        public void UTCID04() => Assert.AreEqual(false, Utilities.IsValidDate(2001, 02, 29));

        [TestMethod]
        public void UTCID05() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 11, 29));

        [TestMethod]
        public void UTCID06() => Assert.AreEqual(true, Utilities.IsValidDate(2001, 12, 31));

        [TestMethod]
        public void UTCID07() => Assert.AreEqual(false, Utilities.IsValidDate(2000, 11, 39));

        [TestMethod]
        public void UTCID08() => Assert.AreEqual(false, Utilities.IsValidDate(-2006, 11, 30));

        [TestMethod]
        public void UTCID09() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 05, 29));

        [TestMethod]
        public void UTCID010() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 05, 30));

        [TestMethod]
        public void UTCID011() => Assert.AreEqual(true, Utilities.IsValidDate(2000, 05, 31));

        [TestMethod]
        public void UTCID012() => Assert.AreEqual(false, Utilities.IsValidDate(2001, 13, 29));

        [TestMethod]
        public void UTCID013() => Assert.AreEqual(true, Utilities.IsValidDate(2004, 2, 29));

    }
}
