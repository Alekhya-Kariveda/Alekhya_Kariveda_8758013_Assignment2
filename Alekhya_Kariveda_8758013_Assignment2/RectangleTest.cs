using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Alekhya_Kariveda_8758013_Assignment2
{
    [TestClass]
    public class RectangleTest
    {
        Rectangle r;
        [TestMethod]
        public void TestGetLength()
        {
            r = new Rectangle(20, 30);
            Assert.AreEqual(20, r.GetLength());
        }
        [TestMethod]
        public void TestGetWidth()
        {
            r = new Rectangle(20, 30);
            Assert.AreEqual(30, r.GetWidth());
        }
        [TestMethod]
        public void TestGetPerimeter()
        {
            r = new Rectangle(20, 30);
            Assert.AreEqual(100, r.GetPerimeter());
        }
        [TestMethod]
        public void TestGetArea()
        {
            r = new Rectangle(20, 30);
            Assert.AreEqual(600, r.GetArea());
        }

    }
}
