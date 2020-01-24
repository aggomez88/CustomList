using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_04_CustomList;


namespace CustomList_Tests
{
    [TestClass]
    public class MyCustomList
    {
        [TestMethod]
        public void Check_ZeroIndex_Add()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 5;
            int actual;


            // ACT
            myList.Add(value);
            actual = myList[0];

            // ASSERT
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Check_CountAfter_Add()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 1;
            int actual;

            // ACT
            myList.Add(value);

            // ASSERT
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Check_IncreaseCapacity_AfterAdd()
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
        [TestMethod]
        public void Check_AddToEndOfList()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected = 3;
            int firstValue = 2;
            int secondValue = 3;
            int actual;

            // ACT
            actual = myList.Add[1];

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Indexer()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected = [indexer];

            // ACT
            myList[expected];

            // ASSERT
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Check_IfListWillReturn_Null()
        {
            // ARRANGE
            CustomList<int> myList;
            int expected = 1;
            actual;
            // ACT
            myList.Add(1);
            // ASSERT
        }
    }
}
