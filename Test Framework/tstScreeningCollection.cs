using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstScreeningCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllScreenings);
        }

        [TestMethod]
        public void ScreeningListOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsScreening> TestList = new List<clsScreening>();
            //Add an item to the list
            //Create the item of test data
            clsScreening TestItem = new clsScreening();
            //Set its properties
            TestItem.FilmID = 1;
            TestItem.ScreenID = 2;
            TestItem.ScreeningCost = 12.50m;
            TestItem.ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0);
            TestItem.Cancelled = false;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllScreenings.ScreeningList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllScreenings.ScreeningList, TestList);
        }

        [TestMethod]
        public void ThisScreeningPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create some test data to assign to the property
            clsScreening TestItem = new clsScreening();
            //Set the properties of the test object
            TestItem.FilmID = 1;
            TestItem.ScreenID = 2;
            TestItem.ScreeningCost = 12.50m;
            TestItem.ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0);
            TestItem.Cancelled = false;
            //Assign the data to the property
            AllScreenings.ThisScreening = TestItem;
            //Test to see that the two values are the same
            Assert.AreEqual(AllScreenings.ThisScreening, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsScreening> TestList = new List<clsScreening>();
            //Add an item to the list
            //Create the item of test data
            clsScreening TestItem = new clsScreening();
            //Set its properties
            TestItem.FilmID = 1;
            TestItem.ScreenID = 2;
            TestItem.ScreeningCost = 12.50m;
            TestItem.ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0);
            TestItem.Cancelled = false;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllScreenings.ScreeningList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllScreenings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create the item of test data
            clsScreening TestItem = new clsScreening();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.FilmID = 1;
            TestItem.ScreenID = 2;
            TestItem.ScreeningCost = 12.50m;
            TestItem.ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0);
            TestItem.Cancelled = false;
            //Set ThisFilm to the test data
            AllScreenings.ThisScreening = TestItem;
            //Add the record
            PrimaryKey = AllScreenings.Add();
            //Set the primary key of the test data
            TestItem.ScreeningID = PrimaryKey;
            //Find the record
            AllScreenings.ThisScreening.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllScreenings.ThisScreening, TestItem);
        }

        [TestMethod]
        public void CancelMethodOK()
        {
            //Create an instance of the class we want to create
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create the item of test data
            clsScreening TestItem = new clsScreening();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.FilmID = 1;
            TestItem.ScreenID = 2;
            TestItem.ScreeningCost = 12.50m;
            TestItem.ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0);
            TestItem.Cancelled = false;
            //Set ThisFilm to the test data
            AllScreenings.ThisScreening = TestItem;
            //Add the record
            PrimaryKey = AllScreenings.Add();
            //Set the primary key of the test data
            TestItem.ScreeningID = PrimaryKey;
            //Cancel the record
            AllScreenings.Cancel();
            //Find the record
            AllScreenings.ThisScreening.Find(PrimaryKey);
            //Test to see that the screening has been cancelled
            Assert.IsTrue(TestItem.Cancelled);
        }


        [TestMethod]
        public void FilterByCancelledMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsScreeningCollection AllScreenings = new clsScreeningCollection();
            //Create an instance of the filtered data
            clsScreeningCollection FilteredScreenings = new clsScreeningCollection();
            //Apply a blank string (should return all records)
            FilteredScreenings.FilterByCancelled(false);
            //Test to see that the two values are the same
            Assert.AreEqual(AllScreenings.Count, FilteredScreenings.Count);
        }

    }
}
