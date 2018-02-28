using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstTicket
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Test to see that it exists
            Assert.IsNotNull(ATicket);
        }

        [TestMethod]
        public void TicketIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ATicket.TicketID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.TicketID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ATicket.CustomerID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.CustomerID, TestData);
        }

        [TestMethod]
        public void ScreeningIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ATicket.ScreeningID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.ScreeningID, TestData);
        }

        [TestMethod]
        public void ValidatedPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Boolean TestData = false;
            //Assign the data to the property
            ATicket.Validated = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.Validated, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ATicket.StaffID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.StaffID, TestData);
        }

        [TestMethod]
        public void ManagerIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Int32 TestData = 2;
            //Assign the data to the property
            ATicket.ManagerID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.ManagerID, TestData);
        }

        [TestMethod]
        public void CancelledPropertyOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Create some test data to assign to the property
            Boolean TestData = false;
            //Assign the data to the property
            ATicket.Cancelled = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ATicket.Cancelled, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TicketIDFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.TicketID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.CustomerID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestScreeningIDFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.ScreeningID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidatedFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.Validated != false)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.StaffID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerIDFound()
        {
            //Create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the variable
            if (ATicket.ManagerID != 1)
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
            clsTicket ATicket = new clsTicket();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 TicketID = 1;
            //Invoke the method
            Found = ATicket.Find(TicketID);
            //Check the Screening cost
            if (ATicket.Cancelled != false)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
