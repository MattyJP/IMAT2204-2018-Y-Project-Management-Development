using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstFilm
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Test to see that it exists
            Assert.IsNotNull(AFilm);
        }

        [TestMethod]
        public void FilmIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AFilm.FilmID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AFilm.FilmID, TestData);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Create some test data to assign to the property
            string TestData = "Punch Hard 2: Punch Harder";
            //Assign the data to the property
            AFilm.Title = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AFilm.Title, TestData);
        }

        [TestMethod]
        public void DurationPropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Create some test data to assign to the property
            Int32 TestData = 125;
            //Assign the data to the property
            AFilm.Duration = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AFilm.Duration, TestData);
        }

        [TestMethod]
        public void AgeRatingIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Create some test data to assign to the property
            Int32 TestData = 4;
            //Assign the data to the property
            AFilm.AgeRatingID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AFilm.AgeRatingID, TestData);
        }

        [TestMethod]
        public void GenreIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AFilm.GenreID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AFilm.GenreID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFilmIDFound()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Check the Film ID
            if (AFilm.FilmID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Check the Title
            if (AFilm.Title != "Punch 2: Punch Harder")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDurationFound()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Check the duration
            if (AFilm.Duration != 125)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAgeRatingIDFound()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Check the Age Rating ID
            if (AFilm.AgeRatingID != 4)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenreIDFound()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 FilmID = 1;
            //Invoke the method
            Found = AFilm.Find(FilmID);
            //Check the Genre ID
            if (AFilm.GenreID != 1)
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
            clsFilm AFilm = new clsFilm();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            Error = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = ""; //This should trigger an error
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TitleMin()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "X"; //This should pass
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "ZY"; //This should pass
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "1. Letters, numbers and punctuation are accepted!"; //This should pass
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMax()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "1. Letters, numbers and punctuation are accepted!!"; //This should pass
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMid()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "ABCDEFGHIJKLMNOPQRSTUVWXY"; //This should pass
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String variable to store any error message
            string Error = "";
            //Create some test data to pass to the method
            string Title = "1. Letters, numbers and punctuation are accepted!!!"; //This should fail
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            Error = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //Create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String variable to store any error message
            string Error = "";
            //Create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(500, 'X'); //This should fail
            string Duration = "85";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            Error = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DurationMinLessOne()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DurationMin()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "1";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DurationMinPlusOne()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "12";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DurationMaxLessOne()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "123";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DurationMax()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "1234";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DurationMaxPlusOne()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "12345";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DurationMid()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "12";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            OK = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DurationInvalidData()
        {
            //Create an instance of the class we want toc reate
            clsFilm AFilm = new clsFilm();
            //String variable to store any error message
            string Error = "";
            //Create some test data to pass to the method
            string Title = "Lawrence of Molvania";
            string Duration = "XYZ!";
            string AgeRatingID = "3";
            string GenreID = "2";
            //Invoke the method
            Error = AFilm.Valid(Title, Duration, AgeRatingID, GenreID);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
