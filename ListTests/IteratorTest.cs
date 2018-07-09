using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void IteratorTestOne()
        {
            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            int[] expected = { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
            Assert.AreEqual(expected[4], myList[4]);
            Assert.AreEqual(expected[5], myList[5]);

        }

        [TestMethod]
        public void IteratorTestStrings()
        {
            NateList<string> myList = new NateList<string>();
            myList.Add("hey");
            myList.Add("hello");
            myList.Add("Helloo");
            myList.Remove("hello");
            myList.Add("hello");
            myList.Add("bye");

            string[] expected = {"hey","Helloo" , "hello", "bye" };

            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
        }
    }
}
