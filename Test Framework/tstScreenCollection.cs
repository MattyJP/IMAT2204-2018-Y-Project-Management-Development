using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstScreenCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllScreens);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreenCollection AllScreens = new clsScreenCollection();
            //Create some test data to align to the property
            Int32 SomeCount = 6;
            //Assign the data to the property
            AllScreens.Count = SomeCount;
            Assert.AreEqual(AllScreens.Count, SomeCount);
        }

        [TestMethod]
        public void ScreenListOK()
        {
            //Create an instance of the class we want to create
            clsScreenCollection Screens = new clsScreenCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsScreen> TestList = new List<clsScreen>();
            //Add an item to the list
            //Create an item of test data
            clsScreen TestItem = new clsScreen();
            //Set its properties
            TestItem.ScreenID = 1;
            TestItem.Capacity = 60;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            Screens.ScreenList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Screens.ScreenList, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //Create an instance of the class we want to create
            clsScreenCollection Screens = new clsScreenCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsScreen> TestList = new List<clsScreen>();
            //Add an item to the list
            //Create an item of test data
            clsScreen TestItem = new clsScreen();
            //Set its properties
            TestItem.ScreenID = 1;
            TestItem.Capacity = 60;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            Screens.ScreenList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Screens.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoScreensPresent()
        //{
        //    //Create an instance of the class we want to create
        //    clsScreenCollection Screens = new clsScreenCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Screens.Count, 2);
        //}

    }
}
