using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_04_CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class TestLists_OverLoad_Plus
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "123456";
            string actual;

            //ACT
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            even.Add(2);
            even.Add(4);
            even.Add(6);

            result = odd + even;

            //ASSERT
            Assert.AreEqual(expectedResult, result.ToString());
        }
    }
}
