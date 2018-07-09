using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void AddIntToArray()
        {
            
            //arrange
            int expected= 1;
            

            //act
            NateList<int> myList = new NateList<int>();
            int[] actual= myList.Add(1);

            //Assert
            Assert.AreEqual(expected, actual[0]);
        }

        [TestMethod]
        public void Hey_AddStringToArray_Spot1()
        {
            //arrange
            string expected = "hello";

            //act
            NateList<string> myList = new NateList<string>();
            string[] actual = myList.Add("hello");

            //Assert
            Assert.AreEqual(expected, actual[0]);
        }

        [TestMethod]
        public void addDoubleToArray()
        {
            //arrange
            double expected = 23.5;
            //act
            NateList<double> myList = new NateList<double>();
            double[] actual = myList.Add(23.5);

            //Assert
            Assert.AreEqual(expected, actual[0]);
        }
        [TestMethod]
        public void addSixNumbers()
        {
            //arrange
            int[] expected = { 1, 2, 3, 4, 5, 6, };

            //act
            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            //Assert
            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
            Assert.AreEqual(expected[4], myList[4]);
            Assert.AreEqual(expected[5], myList[5]);
        }

        [TestMethod]
        public void Add14Numbers()
        {
            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);
            myList.Add(14);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
            Assert.AreEqual(expected[4], myList[4]);
            Assert.AreEqual(expected[5], myList[5]);
            Assert.AreEqual(expected[6], myList[6]);
            Assert.AreEqual(expected[7], myList[7]);
            Assert.AreEqual(expected[8], myList[8]);
            Assert.AreEqual(expected[9], myList[9]);
            Assert.AreEqual(expected[10], myList[10]);
            Assert.AreEqual(expected[11], myList[11]);
            Assert.AreEqual(expected[12], myList[12]);
            Assert.AreEqual(expected[13], myList[13]);


        }

        [TestMethod]
        public void AddThirdItem()
        {
            //arrange
            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            int expected = 3;
            //act
           int[] actual= myList.Add(3);
            //Assert
            Assert.AreEqual(expected, actual[2]);
        }




    }
}
