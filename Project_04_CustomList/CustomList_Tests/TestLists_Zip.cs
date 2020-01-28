using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_04_CustomList;


namespace CustomList_Tests
{
    [TestClass]
    public class TestLists_Zip
    {
        [TestMethod]
        public void CanIZipTwoListsTogether()
        {
            // ARRANGE
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> finalList;

            int expectedResult = 5;
            // 1, 2, 3, 4, 5, 6
            int actual;

            // ACT 
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            even.Add(2);
            even.Add(4);
            even.Add(6);

            //actual = finalList.Zip[4];

            // ASSERT
            //Assert.AreEqual(expectedResult, actual);
        }
        //[TestMethod]
        //public void CanIUnZipTwoLists()
        //{
        //    // ARRANGE
        //    CustomList<int> finalList = new CustomList<int>();
        //    CustomList<int> odd = new CustomList<int>();
        //    CustomList<int> even = new CustomList<int>();

        //    int expectedResult = 5;
        //    // 1, 2, 3, 4, 5, 6 ==> {1, 3, 5}, {2, 4, 6};
        //    // expected result 5 will be at index [2] of odd list
        //    int actual; 

        //    // ACT
        //    // int % 0 ==> even, int not % 0 ==> odd

        //    // ASSERT
        //    Assert.AreEqual(expectedResult, actual);
        //}
        [TestMethod]
        public void CanICheckTheIndexOfMyNewZipList()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 4;
            int expected = 4;
            int actual;


            // ACT
            myList.Add(value);
            myList.Add(value2);

            myList.Remove(value);
            actual = myList[0];


            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanICheckTheCapacityOfMyNewList()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int actual;

            // ACT
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            actual = myList.Capacity;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void WhatIfMyListsAreOfDifferentCapacities()
        //{
        //    // ARRANGE
        //    CustomList<int> odd = new CustomList<int>();
        //    CustomList<int> even = new CustomList<int>();
        //    CustomList<int> result;
        //    string expectedResult = "12345679";


        //    // ACT
        //    odd.Add(1);
        //    odd.Add(3);
        //    odd.Add(5);

        //    even.Add(2);
        //    even.Add(4);
        //    even.Add(6);

        //    //result = odd + even;

        //    // ASSERT
        //    Assert.AreEqual(expectedResult, result.ToString());
        //}
        
    }
}
