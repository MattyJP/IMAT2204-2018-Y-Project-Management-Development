using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstGenre
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsGenre AGenre = new clsGenre();
            //Test to see that it exisrs
            Assert.IsNotNull(AGenre);
        }

        [TestMethod]
        public void GenreIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsGenre AGenre = new clsGenre();
            //Create some test data to align to the property
            Int32 SomeGenreID = 1;
            //Assign the data to the property
            AGenre.GenreID = SomeGenreID;
            Assert.AreEqual(AGenre.GenreID, SomeGenreID);
        }

        [TestMethod]
        public void GenreTitlePropertyOK()
        {
            //Create an instance of the class we want to create
            clsGenre AGenre = new clsGenre();
            //Create some test data to align to the property
            string SomeGenreTitle = "Action";
            //Assign the data to the property
            AGenre.GenreTitle = SomeGenreTitle;
            Assert.AreEqual(AGenre.GenreTitle, SomeGenreTitle);
        }
    }
}
