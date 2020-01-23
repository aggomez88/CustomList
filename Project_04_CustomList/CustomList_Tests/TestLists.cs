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

            // ACT
            myList.Add(value);

            // ASSERT
            Assert.AreEqual(value, myList[0]);
        }
        [TestMethod]
        public void Check_CountAfter_Add()
        {
            // ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedResult = 1;

            // ACT
            myList.Add(value);

            // ASSERT
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void Check_IncreaseCapacity_AfterAdd()
        {
            // ARRANGE

            // ACT

            // ASSERT
        }
        [TestMethod]
        public void Check_AddToEndOfList()
        {
            // ARRANGE

            // ACT

            // ASSERT
        }
        [TestMethod]
        public void Check_Indexer()
        {
            // ARRANGE

            // ACT

            // ASSERT

        }
        [TestMethod]
        public void Check_IfListWillReturn_Null()
        {
            // ARRANGE

            // ACT

            // ASSERT
        }
    }
}
