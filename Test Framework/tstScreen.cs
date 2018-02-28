using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstScreen
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsScreen AScreen = new clsScreen();
            //Test to see that it exisrs
            Assert.IsNotNull(AScreen);
        }

        [TestMethod]
        public void ScreenIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreen AScreen = new clsScreen();
            //Create some test data to align to the property
            Int32 SomeScreenID = 1;
            //Assign the data to the property
            AScreen.ScreenID = SomeScreenID;
            Assert.AreEqual(AScreen.ScreenID, SomeScreenID);
        }

        [TestMethod]
        public void CapacityPropertyOK()
        {
            //Create an instance of the class we want to create
            clsScreen AScreen = new clsScreen();
            //Create some test data to align to the property
            Int32 SomeCapacity = 60;
            //Assign the data to the property
            AScreen.Capacity = SomeCapacity;
            Assert.AreEqual(AScreen.Capacity, SomeCapacity);
        }
    }
}
