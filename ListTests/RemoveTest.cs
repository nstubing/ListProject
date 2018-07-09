using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void One_Remove_One()
        {

            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            int expected = 3;

            myList.Remove(2);

            Assert.AreEqual(expected, myList[1]);

            
        }


        [TestMethod]
        public void RemoveTwoItems()
        {
            string expected = "things";

            NateList<string> myList = new NateList<string>();
            myList.Add("this");
            myList.Add("that");
            myList.Add("those");
            myList.Add("things");
            myList.Remove("that");
            myList.Remove("those");

            Assert.AreEqual(expected, myList[1]);
        }

        [TestMethod]
        public void RemoveFirstItem()
        {
            string expected = "second";

            NateList<string> myList = new NateList<string>();
            myList.Add("first");
            myList.Add("second");
            myList.Remove("first");

            Assert.AreEqual(expected, myList[0]);
        }
    }
}
    

