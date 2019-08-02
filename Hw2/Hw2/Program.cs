using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw2
{
    class Program
    {
        [TestMethod]
        static public void TestPushToheadMethod()
        {
            List l = new List();
            l.PushTohead('i');
            Assert.AreEqual(l.getLenght(), 1, "PushTohead fail: size node must equal 1");
            l.PushTohead('j');
            Assert.AreEqual(l.getLenght(), 2, "PushTohead fail: size node must equal 2");
            Assert.AreEqual(l.head.data, 'j', "PushTohead fail: head node incorrect");
        }

        [TestMethod]
        static public void TestPushTotailMethod()
        {
            List l = new List();
            l.PushTotail('i');
            Assert.AreEqual(l.getLenght(), 1, "PushTotail fail: size node must equal 1");
            l.PushTotail('j');
            Assert.AreEqual(l.getLenght(), 2, "PushTotail fail: size node must equal 2");
            Assert.AreEqual(l.tail.data, 'j', "PushTotail fail: head node incorrect");
        }

        [TestMethod]
        static public void TestPopToheadMethod()
        {
            List l = new List();
            l.PushTohead('i');
            l.PushTohead('j');
            l.PushTohead('k');
            var chr = l.PopToHead();
            Assert.AreEqual(l.getLenght(), 2, "PopTohead fail: size node must equal 2");
            Assert.AreEqual(chr, 'k', "PopTohead fail: pop node incorrect");
            chr = l.PopToHead();
            Assert.AreEqual(l.getLenght(), 1, "PopTohead fail: size node must equal 1");
            Assert.AreEqual(chr, 'j', "PopTohead fail: pop node incorrect");
            l.PopToHead();
            Assert.AreEqual(l.getLenght(), 0, "PopTohead fail: size node must equal 0");
            Assert.AreEqual(l.tail, l.head, null, "PopTohead fail: list must emtry");
        }

        [TestMethod]
        static public void TestPopTotailMethod()
        {
            List l = new List();
            l.PushTohead('i');
            l.PushTohead('j');
            l.PushTohead('k');
            var chr = l.PopToTail();
            Assert.AreEqual(l.getLenght(), 2, "PopTotail fail: size node must equal 2");
            Assert.AreEqual(chr, 'i', "PopTotail fail: pop node incorrect");
            chr = l.PopToTail();
            Assert.AreEqual(l.getLenght(), 1, "PopTotail fail: size node must equal 1");
            Assert.AreEqual(chr, 'j', "PopTotail fail: pop node incorrect");
            l.PopToTail();
            Assert.AreEqual(l.getLenght(), 0, "PopTohead fail: size node must equal 0");
            Assert.AreEqual(l.tail, l.head, null, "PopTohead fail: list must emtry");
        }

        static public void TestSearchMethod()
        {
            List l = new List();
            l.PushTohead('i');
            l.PushTohead('j');
            l.PushTohead('k');
            l.PushTohead('l');
            var chr = l.Search('k');
            Assert.AreEqual(l.Search('k'), true, "Search fail: element for search must in list");
            Assert.AreEqual(l.Search('o'), false, "Search fail: element for search must not in list");
        }

        [TestMethod]
        static public void TestEmtryMethod()
        {
            List l = new List();
            Assert.AreEqual(l.emtry(), true, "Emtry fail: list must emtry");
            l.PushTohead('i');
            Assert.AreEqual(l.emtry(), false, "Emtry fail: list must not emtry");
            l.PopToHead();
            Assert.AreEqual(l.emtry(), true, "Emtry fail: list must not emtry");
        }

        [TestMethod]
        static public void TestPrintForwardMethod()
        {
            List l = new List();
            l.PushTohead('i');
            l.PushTohead('j');
            l.PushTohead('k');
            l.PushTohead('l');
            l.PushTohead('m');
            Assert.AreEqual(l.PrintForward(), "m l k j i ", "PrintForward fail: result not equal");
        }

        [TestMethod]
        static public void TestPrintBackwardMethod()
        {
            List l = new List();
            l.PushTohead('i');
            l.PushTohead('j');
            l.PushTohead('k');
            l.PushTohead('l');
            l.PushTohead('m');
            Assert.AreEqual(l.PrintBackward(), "i j k l m ", "PrintForward fail: result not equal");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=======Start Testing=======");
            TestPushToheadMethod();
            TestPushTotailMethod();
            TestPopToheadMethod();
            TestPopTotailMethod();
            TestSearchMethod();
            TestEmtryMethod();
            TestPrintForwardMethod();
            TestPrintBackwardMethod();
            Console.WriteLine("=======Test success=======");
        }
    }
}
