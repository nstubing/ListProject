using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ThreeIntsToString()
        {
            string expected = "123";

            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            string actual=myList.ToString(myList);

            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void StringStringToLargeString()
        {
            string expected = "thisthat";

            NateList<string> myList = new NateList<string>();
            myList.Add("this");
            myList.Add("that");
            string actual = myList.ToString(myList);


        }
    }
}
