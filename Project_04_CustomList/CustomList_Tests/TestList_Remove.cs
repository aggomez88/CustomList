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
            int expected = 4;
            int actual;


            // ACT

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
            int expected = 0;
            int actual;

            // ACT
            myList.Remove(valueOne, valueTwo);
            actual = myList[0];

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAnItemFromAParticualrIndexInList()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 5;
            int actual;

            // ACT

            myList.Remove(value);
            actual = myList[0];

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromSpecificIndex_RemainingItemsShiftToTheLeft()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 5;
            int actual;

            // ACT

            myList.Remove(value);
            actual = myList[0]

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveFiveItemsFromListWillCapacityOfListRemainTheSame()
        {
            // ARRANGE

            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int actual;

            // ACT
            myList.Remove(1);
            myList.Remove(2);
            myList.Remove(3);
            myList.Remove(4);
            myList.Remove(5);

            // ASSERT

            Assert.AreEqual(expected, myList[8]);
        }
    }
}
