using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstScreening
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Test to see that it exists
            Assert.IsNotNull(AScreening);
        }

        [TestMethod]
        public void ScreeningIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AScreening.ScreeningID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.ScreeningID, TestData);
        }

        [TestMethod]
        public void FilmIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AScreening.FilmID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.FilmID, TestData);
        }

        [TestMethod]
        public void ScreenIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            Int32 TestData = 2;
            //Assign the data to the property
            AScreening.ScreenID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.ScreenID, TestData);
        }

        [TestMethod]
        public void ScreeningCostPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            Decimal TestData = 12.50m;
            //Assign the data to the property
            AScreening.ScreeningCost = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.ScreeningCost, TestData);
        }

        [TestMethod]
        public void ScreeningDatePropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            DateTime TestData = new DateTime(2018, 7, 23, 12, 15, 0);
            //Assign the data to the property
            AScreening.ScreeningDate = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.ScreeningDate, TestData);
        }

        [TestMethod]
        public void CancelledPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Create some test data to assign to the property
            Boolean TestData = false;
            //Assign the data to the property
            AScreening.Cancelled = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AScreening.Cancelled, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ScreeningIDFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Screening ID
            if (AScreening.ScreeningID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmIDFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Film ID
            if (AScreening.FilmID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestScreenIDFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Screen ID
            if (AScreening.ScreenID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestScreeningCostFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Screening cost
            if (AScreening.ScreeningCost != 12.50m)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestScreeningDateFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Screening cost
            if (AScreening.ScreeningDate != new DateTime(2018, 7, 23, 12, 15, 0))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCancelledFound()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ScreeningID = 1;
            //Invoke the method
            Found = AScreening.Find(ScreeningID);
            //Check the Screening cost
            if (AScreening.Cancelled != false)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want toc reate
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMinLessOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMin()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "1m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.5m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMax()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMid()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "120m";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.505";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostExtremeMax()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "1200.50555579";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningCostInvalidData()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "ABCD.EFGm";
            string ScreeningDate = new DateTime(2018, 7, 23, 12, 15, 0).ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningDateExtremeMin()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            //Change to date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string ScreeningDate = TestDate.ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningDateMinLessOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            //Change to date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string ScreeningDate = TestDate.ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningDateMin()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            //Convert the date variable to a string variable
            string ScreeningDate = TestDate.ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningDateMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            //Change to date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string ScreeningDate = TestDate.ToString();
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScreeningDateInvalidData()
        {
            //Create an instance of the class we want to create
            clsScreening AScreening = new clsScreening();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FilmID = "1";
            string ScreenID = "2";
            string ScreeningCost = "12.50";
            //Set ScreeningDate to a non-date value
            string ScreeningDate = "Definitely not a date!";
            //Invoke the method
            Error = AScreening.Valid(FilmID, ScreenID, ScreeningCost, ScreeningDate);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
