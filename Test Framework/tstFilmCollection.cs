using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstFilmCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllFilms);
        }

        [TestMethod]
        public void FilmListOK()
        {
            //Create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsFilm> TestList = new List<clsFilm>();
            //Add an item to the list
            //Create the item of test data
            clsFilm TestItem = new clsFilm();
            //Set its properties
            TestItem.Title = "Punch 3: Punch Harderer";
            TestItem.Duration = 75;
            TestItem.AgeRatingID = 4;
            TestItem.GenreID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllFilms.FilmList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllFilms.FilmList, TestList);
        }

        [TestMethod]
        public void ThisFilmPropertyOK()
        {
            //Create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Create some test data to assign to the property
            clsFilm TestFilm = new clsFilm();
            //Set the properties of the test object
            TestFilm.Title = "Punch 3: Punch Harderer";
            TestFilm.Duration = 75;
            TestFilm.AgeRatingID = 4;
            TestFilm.GenreID = 1;
            //Assign the data to the property
            AllFilms.ThisFilm = TestFilm;
            //Test to see that the two values are the same
            Assert.AreEqual(AllFilms.ThisFilm, TestFilm);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsFilm> TestList = new List<clsFilm>();
            //Add an item to the list
            //Create the item of test data
            clsFilm TestItem = new clsFilm();
            //Set its properties
            TestItem.Title = "Punch 3: Punch Harderer";
            TestItem.Duration = 75;
            TestItem.AgeRatingID = 4;
            TestItem.GenreID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllFilms.FilmList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllFilms.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Create the item of test data
            clsFilm TestItem = new clsFilm();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Title = "Punch 5: Punch Yet Again Even More Hardererer";
            TestItem.Duration = 80;
            TestItem.AgeRatingID = 5;
            TestItem.GenreID = 5;
            //Set ThisFilm to the test data
            AllFilms.ThisFilm = TestItem;
            //Add the record
            PrimaryKey = AllFilms.Add();
            //Set the primary key of the test data
            TestItem.FilmID = PrimaryKey;
            //Find the record
            AllFilms.ThisFilm.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllFilms.ThisFilm, TestItem);
        }


        [TestMethod]
        public void FilterByTitleMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsFilmCollection AllFilms = new clsFilmCollection();
            //Create an instance of the filtered data
            clsFilmCollection FilteredFilms = new clsFilmCollection();
            //Apply a blank string (should return all records)
            FilteredFilms.FilterByTitle("");
            //Test to see that the two values are the same
            Assert.AreEqual(AllFilms.Count, FilteredFilms.Count);
        }

        [TestMethod]
        public void FIlterByTitleNoneFound()
        {
            //Create an instance of the filtered data
            clsFilmCollection FilteredFilms = new clsFilmCollection();
            //Apply a title that doesn't exist
            FilteredFilms.FilterByTitle("Zzzzzzzz!");
            //Test to see that there are no records
            Assert.AreEqual(0, FilteredFilms.Count);
        }

        [TestMethod]
        public void FilterByTitleTestDataFound()
        {
            //Create an instance of the filtered data
            clsFilmCollection FilteredFilms = new clsFilmCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a Title that doesn exist
            FilteredFilms.FilterByTitle("Zzzzzzzz");
            //Check that the correct number of records are found
            if (FilteredFilms.Count == 2)
            {
                //Check that the first record is ID 36
                if (FilteredFilms.FilmList[0].FilmID != 36)
                {
                    OK = false;
                }
                //Check that the first record is ID 37
                if (FilteredFilms.FilmList[0].FilmID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //Test to see that there are no records
            Assert.IsTrue(OK);
            }
        }
    }
