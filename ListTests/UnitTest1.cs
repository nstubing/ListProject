using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myListProject;

namespace ListTests
{
    [TestClass]
    public class UnitTest1
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
        public void addTwoItemsToArray()
        {
            //arrange
            int[] expected = { 2, 4 };
            //act
            NateList<int[]> myList = new NateList<int[]>();
            int[] actual = myList.Add(expected);
            //Assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
        [TestMethod]
        public void TwoArrays_Add_OneArray()
        {
            //arrange
            string[] arrayOne = { "v", "x" };
            string[] arrayTwo = { "q", "y" };
            string[,] expected = { {"v", "x" }, { "q", "y" } };
            //act
            NateList<string[,]> myList = new NateList<string[,]>();
            string[,] actual = myList.Add(arrayOne);
            //Assert
            Assert.AreEqual(expected[0,0], actual[0,0]);
            Assert.AreEqual(expected[0,1], actual[0,1]);
            Assert.AreEqual(expected[1,0], actual[1,0]);
            Assert.AreEqual(expected[1,1], actual[1,1]);

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
