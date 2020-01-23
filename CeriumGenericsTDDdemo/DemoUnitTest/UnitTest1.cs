using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeriumGenericsTDDdemo;
namespace DemoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckZeroIndexAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedResult = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int secondValue = 10;
            
            //Act
            myList.Add(value);
            myList.Add(secondValue);

            //Assert
            Assert.AreEqual(secondValue, myList[1]);
        }
    }
}
