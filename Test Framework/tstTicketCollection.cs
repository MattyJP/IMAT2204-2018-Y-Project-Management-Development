using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstTicketCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllTickets);
        }

        [TestMethod]
        public void TicketListOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsTicket> TestList = new List<clsTicket>();
            //Add an item to the list
            //Create the item of test data
            clsTicket TestItem = new clsTicket();
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllTickets.TicketList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTickets.TicketList, TestList);
        }

        [TestMethod]
        public void ThisTicketPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create some test data to assign to the property
            clsTicket TestItem = new clsTicket();
            //Set the properties of the test object
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Assign the data to the property
            AllTickets.ThisTicket = TestItem;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTickets.ThisTicket, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsTicket> TestList = new List<clsTicket>();
            //Add an item to the list
            //Create the item of test data
            clsTicket TestItem = new clsTicket();
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllTickets.TicketList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllTickets.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create the item of test data
            clsTicket TestItem = new clsTicket();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Set ThisFilm to the test data
            AllTickets.ThisTicket = TestItem;
            //Add the record
            PrimaryKey = AllTickets.Add();
            //Set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //Find the record
            AllTickets.ThisTicket.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllTickets.ThisTicket, TestItem);
        }

        [TestMethod]
        public void CancelMethodOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create the item of test data
            clsTicket TestItem = new clsTicket();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Set ThisFilm to the test data
            AllTickets.ThisTicket = TestItem;
            //Add the record
            PrimaryKey = AllTickets.Add();
            //Set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //Cancel the record
            AllTickets.Cancel();
            //Find the record
            AllTickets.ThisTicket.Find(PrimaryKey);
            //Test to see that the Ticket has been cancelled
            Assert.IsTrue(TestItem.Cancelled);
        }

        [TestMethod]
        public void ValidateMethodOK()
        {
            //Create an instance of the class we want to create
            clsTicketCollection AllTickets = new clsTicketCollection();
            //Create the item of test data
            clsTicket TestItem = new clsTicket();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.ScreeningID = 1;
            TestItem.Validated = false;
            TestItem.Cancelled = false;
            //Set ThisFilm to the test data
            AllTickets.ThisTicket = TestItem;
            //Add the record
            PrimaryKey = AllTickets.Add();
            //Set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //Cancel the record
            AllTickets.Validate();
            //Find the record
            AllTickets.ThisTicket.Find(PrimaryKey);
            //Test to see that the Ticket has been validated
            Assert.IsTrue(TestItem.Validated);
        }


    }
}
