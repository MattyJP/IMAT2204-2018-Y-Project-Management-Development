using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAgeRating
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsAgeRating AnAgeRating = new clsAgeRating();
            //Test to see that it exisrs
            Assert.IsNotNull(AnAgeRating);
        }

        [TestMethod]
        public void AgeRatingIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsAgeRating AnAgeRating = new clsAgeRating();
            //Create some test data to align to the property
            Int32 SomeAgeRatingID = 1;
            //Assign the data to the property
            AnAgeRating.AgeRatingID = SomeAgeRatingID;
            Assert.AreEqual(AnAgeRating.AgeRatingID, SomeAgeRatingID);
        }

        [TestMethod]
        public void AgeRatingTitlePropertyOK()
        {
            //Create an instance of the class we want to create
            clsAgeRating AnAgeRating = new clsAgeRating();
            //Create some test data to align to the property
            string SomeAgeRatingTitle = "U";
            //Assign the data to the property
            AnAgeRating.AgeRatingTitle = SomeAgeRatingTitle;
            Assert.AreEqual(AnAgeRating.AgeRatingTitle, SomeAgeRatingTitle);
        }
    }
}
