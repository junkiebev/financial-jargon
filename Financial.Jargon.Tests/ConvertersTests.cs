using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Financial.Jargon.Tests
{
    [TestClass]
    public class ConvertersTests
    {
        private readonly Converters _c = new Converters();
        [TestMethod]
        public void ExchangeNameFromCodeTest()
        {
            Assert.AreEqual(_c.ExchangeNameFromCode("CBOT"), "CME");
        }

        [TestMethod]
        public void ShortMonthFromMonthcharTest()
        {
            Assert.AreEqual(_c.ShortMonthFromMonthchar('z'),"Dec");
        }

        [TestMethod]
        public void MonthFromMonthcharTest()
        {
            Assert.AreEqual(_c.MonthFromMonthchar('z'), "December");
        }

        [TestMethod]
        public void MonthNumberFromMonthcharTest()
        {
            Assert.AreEqual(_c.MonthNumberFromMonthchar('z'), "12");
        }

        [TestMethod]
        public void MonthNumberFromShortMonthTest()
        {
            Assert.AreEqual(_c.MonthNumberFromShortMonth("Dec"), "12");
        }

        [TestMethod]
        public void MonthFromShortMonthTest()
        {
            Assert.AreEqual(_c.MonthFromShortMonth("Dec"), "December");
        }

        [TestMethod]
        public void MonthCharFromShortMonthTest()
        {
            Assert.AreEqual(_c.MonthCharFromShortMonth("Dec"), 'Z');
        }

        [TestMethod]
        public void MonthCharFromMonthTest()
        {
            Assert.AreEqual(_c.MonthCharFromMonth("December"),'Z');
        }

        [TestMethod]
        public void ShortMonthFromMonthTest()
        {
            Assert.AreEqual(_c.ShortMonthFromMonth("December"), "Dec");
        }

        [TestMethod]
        public void MonthNumberFromMonthTest()
        {
            Assert.AreEqual(_c.MonthNumberFromMonth("December"), "12");
        }

        [TestMethod]
        public void MonthFromMonthNumberTest()
        {
            Assert.AreEqual(_c.MonthFromMonthNumber("03"), "March");
        }

        [TestMethod]
        public void MonthCharFromMonthNumberTest()
        {
            Assert.AreEqual(_c.MonthCharFromMonthNumber("04"), 'J');
        }

        [TestMethod]
        public void ShortMonthFromMonthNumberTest()
        {
            Assert.AreEqual(_c.ShortMonthFromMonthNumber("3"), "Mar");
        }

        [TestMethod]
        public void MonthCharFromDateTest()
        {
            Assert.AreEqual(_c.MonthCharFromDate(new DateTime(2014,12,5)),'Z');
        }

        [TestMethod]
        public void MonthNumberFromDateTest()
        {
            Assert.AreEqual(_c.MonthNumberFromDate(new DateTime(2014, 12, 5)), "12");
        }

        [TestMethod]
        public void ShortMonthFromDateTest()
        {
            Assert.AreEqual(_c.ShortMonthFromDate(new DateTime(2014, 12, 5)), "Dec");
        }

        [TestMethod]
        public void MonthFromDateTest()
        {
            Assert.AreEqual(_c.MonthFromDate(new DateTime(2014, 12, 5)), "December");
        }
    }
}