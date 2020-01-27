using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_04_CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class TestList_Remove
    {
        [TestMethod]
        public void RemoveItemFromALIst()
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
        public void RemoveTwoOrMoreItemsFromALIst()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 4;
            int valueThree = 8;
            int expected = 8;
            int actual;

            // ACT
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            
            myList.Remove(valueOne);
            actual = myList[1];

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAnItemFromAParticualrIndexInList()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 6;
            int value2 = 7;

            int expected = 5;
            int actual;

            // ACT
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            actual = myList[1];

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromSpecificIndex_RemainingItemsShiftToTheLeft()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 7;
            int value2 = 9;
            int value3 = 11;

            int expected = 11; ;
            int actual;

            // ACT

            myList.Remove(value2);
            actual = myList[2];

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFiveItemsFromListWillCapacityOfListRemainTheSame()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int capacity = 8;
            int expected = 8;
            int actual = capacity;

            // ACT
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            myList.Remove(1);
            myList.Remove(2);
            myList.Remove(3);
            myList.Remove(4);
            myList.Remove(5);



            // ASSERT

            Assert.AreEqual(expected, actual);
        }
    }
}
