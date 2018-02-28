using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstAgeRatingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsAgeRatingCollection AllAgeRatings = new clsAgeRatingCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllAgeRatings);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsAgeRatingCollection AllAgeRatings = new clsAgeRatingCollection();
            //Create some test data to align to the property
            Int32 SomeCount = 5;
            //Assign the data to the property
            AllAgeRatings.Count = SomeCount;
            Assert.AreEqual(AllAgeRatings.Count, SomeCount);
        }

        [TestMethod]
        public void AgeRatingListOK()
        {
            //Create an instance of the class we want to create
            clsAgeRatingCollection AgeRatings = new clsAgeRatingCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsAgeRating> TestList = new List<clsAgeRating>();
            //Add an item to the list
            //Create an item of test data
            clsAgeRating TestItem = new clsAgeRating();
            //Set its properties
            TestItem.AgeRatingID = 1;
            TestItem.AgeRatingTitle = "U";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AgeRatings.AgeRatingList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AgeRatings.AgeRatingList, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //Create an instance of the class we want to create
            clsAgeRatingCollection AgeRatings = new clsAgeRatingCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsAgeRating> TestList = new List<clsAgeRating>();
            //Add an item to the list
            //Create an item of test data
            clsAgeRating TestItem = new clsAgeRating();
            //Set its properties
            TestItem.AgeRatingID = 1;
            TestItem.AgeRatingTitle = "U";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AgeRatings.AgeRatingList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AgeRatings.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoAgeRatingsPresent()
        //{
        //    //Create an instance of the class we want to create
        //    clsAgeRatingCollection AgeRatings = new clsAgeRatingCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AgeRatings.Count, 2);
        //}

    }
}
