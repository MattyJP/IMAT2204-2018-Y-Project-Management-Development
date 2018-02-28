using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstGenreCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsGenreCollection AllGenres = new clsGenreCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllGenres);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsGenreCollection AllGenres = new clsGenreCollection();
            //Create some test data to align to the property
            Int32 SomeCount = 8;
            //Assign the data to the property
            AllGenres.Count = SomeCount;
            Assert.AreEqual(AllGenres.Count, SomeCount);
        }

        [TestMethod]
        public void GenreListOK()
        {
            //Create an instance of the class we want to create
            clsGenreCollection Genres = new clsGenreCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsGenre> TestList = new List<clsGenre>();
            //Add an item to the list
            //Create an item of test data
            clsGenre TestItem = new clsGenre();
            //Set its properties
            TestItem.GenreID = 1;
            TestItem.GenreTitle = "Action";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            Genres.GenreList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Genres.GenreList, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //Create an instance of the class we want to create
            clsGenreCollection Genres = new clsGenreCollection();
            //Create some test data to align to the property
            //In this case, the data needs to be a list of objects
            List<clsGenre> TestList = new List<clsGenre>();
            //Add an item to the list
            //Create an item of test data
            clsGenre TestItem = new clsGenre();
            //Set its properties
            TestItem.GenreID = 1;
            TestItem.GenreTitle = "Action";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            Genres.GenreList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Genres.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoGenresPresent()
        //{
        //    //Create an instance of the class we want to create
        //    clsGenreCollection Genres = new clsGenreCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Genres.Count, 2);
        //}

    }
}
