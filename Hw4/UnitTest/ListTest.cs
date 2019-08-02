using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void testPopHead()
        {
            Hw4.List names = new Hw4.List();
            Hw4.List gpas = new Hw4.List();

            names.PushTotail("bravo");
            names.PushTotail("charlie");
            names.PushTotail("delta");
            names.PushTotail("echo");
            names.PushTohead("alpha");

            gpas.PushTotail(2.00);
            gpas.PushTotail(3.00);
            gpas.PushTotail(2.75);
            gpas.PushTotail(2.50);
            gpas.PushTohead(3.25);

            Assert.AreEqual("alpha", (string)names.PopToHead());
            Assert.AreEqual(3.25, (Double)gpas.PopToHead(), 0);
        }

        [TestMethod]
        public void testPopTail()
        {
            Hw4.List names = new Hw4.List();
            Hw4.List gpas = new Hw4.List();

            names.PushTotail("bravo");
            names.PushTotail("charlie");
            names.PushTotail("delta");
            names.PushTotail("echo");
            names.PushTohead("alpha");

            gpas.PushTotail(2.00);
            gpas.PushTotail(3.00);
            gpas.PushTotail(2.75);
            gpas.PushTotail(2.50);
            gpas.PushTohead(3.25);

            Assert.AreEqual("echo", (String)names.PopToTail());
            Assert.AreEqual(2.50, (Double)gpas.PopToTail(), 0);
        }

        [TestMethod]
        public void testElementAt()
        {
            Hw4.List names = new Hw4.List();
            Hw4.List gpas = new Hw4.List();

            names.PushTotail("bravo");
            names.PushTotail("charlie");
            names.PushTotail("delta");
            names.PushTotail("echo");
            names.PushTohead("alpha");

            gpas.PushTotail(2.00);
            gpas.PushTotail(3.00);
            gpas.PushTotail(2.75);
            gpas.PushTotail(2.50);
            gpas.PushTohead(3.25);

            Assert.AreEqual("delta", (string)names.ElementAt(3));
            Assert.AreEqual(2.75, (double)gpas.ElementAt(3));
            Assert.IsNull(names.ElementAt(10));
            Assert.IsNull(gpas.ElementAt(-2));
        }

        [TestMethod]
        public void testRemove()
        {
            Hw4.List names = new Hw4.List();
            Hw4.List gpas = new Hw4.List();

            names.PushTotail("bravo");
            names.PushTotail("charlie");
            names.PushTotail("delta");
            names.PushTotail("echo");
            names.PushTohead("alpha");

            gpas.PushTotail(2.00);
            gpas.PushTotail(3.00);
            gpas.PushTotail(2.75);
            gpas.PushTotail(2.50);
            gpas.PushTohead(3.25);

            Assert.IsTrue(names.Remove("charlie"));
            Assert.IsFalse(names.Remove("tango"));
            Assert.IsTrue(gpas.Remove(3.0));
            Assert.IsFalse(gpas.Remove(3.99));

            Assert.AreEqual("echo", (string)names.ElementAt(3));
            Assert.AreEqual(2.5, (double)gpas.ElementAt(3));
        }

        [TestMethod]
        public void testFound()
        {
            Hw4.List names = new Hw4.List();
            Hw4.List gpas = new Hw4.List();

            names.PushTotail("bravo");
            names.PushTotail("charlie");
            names.PushTotail("delta");
            names.PushTotail("echo");
            names.PushTohead("alpha");

            gpas.PushTotail(2.00);
            gpas.PushTotail(3.00);
            gpas.PushTotail(2.75);
            gpas.PushTotail(2.50);
            gpas.PushTohead(3.25);

            Assert.IsTrue(names.Found("bravo"));
            Assert.IsTrue(gpas.Found(2.00));

            Assert.IsFalse(names.Found("romeo"));
            Assert.IsFalse(gpas.Found(4.00));
        }
    }
}
