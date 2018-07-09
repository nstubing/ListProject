using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class ZipperTest
    {
        [TestMethod]
        public void oneStringListPlusAnother()
        {
            NateList<string> myList1 = new NateList<string>();
            myList1.Add("hello");
            myList1.Add("hey");
            NateList<string> myList2 = new NateList<string>();
            myList2.Add("hello there");
            myList2.Add("hey there");

            string[] expected = { "hello",  "hello there", "hey", "hey there" };
            NateList<string> actual = myList1.Zipper(myList2);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);

        }

        [TestMethod]
        public void AddIntStrings()
        {
            NateList<int> myList1 = new NateList<int>();
            myList1.Add(1);
            myList1.Add(2);
            NateList<int> myList2 = new NateList<int>();
            myList2.Add(3);
            myList2.Add(4);

            int[] expected = { 1, 3, 2, 4 };
            NateList<int> actual = myList1.Zipper(myList2);
        }
        [TestMethod]
        public void AddUnevenStrings()
        {
            NateList<int> myList1 = new NateList<int>();
            myList1.Add(1);
            myList1.Add(2);
            NateList<int> myList2 = new NateList<int>();
            myList2.Add(3);
            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(6);

            int[] expected = { 1, 3, 2, 4, 5, 6, };
            NateList<int> actual = myList1.Zipper(myList2);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);

        }

        public void AddUnevenStringsReverse()
        {
            NateList<int> myList2 = new NateList<int>();
            myList2.Add(1);
            myList2.Add(2);
            NateList<int> myList1 = new NateList<int>();
            myList1.Add(3);
            myList1.Add(4);
            myList1.Add(5);
            myList1.Add(6);

            int[] expected = { 1, 3, 2, 4, 5, 6, };
            NateList<int> actual = myList2.Zipper(myList1);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);

        }
    }
}
