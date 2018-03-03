using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ACustomer.CustomerID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "David";
            //Assign the data to the property
            ACustomer.FirstName = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "Pike";
            //Assign the data to the property
            ACustomer.LastName = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            DateTime TestData = new DateTime(1982, 7, 23);
            //Assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "Daveydave@Gmail.com";
            //Assign the data to the property
            ACustomer.EmailAddress = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void MobilePhoneNoPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            long TestData = 07775828423;
            //Assign the data to the property
            ACustomer.MobilePhoneNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.MobilePhoneNo, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "Swordfish";
            //Assign the data to the property
            ACustomer.Password = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }
        
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the First Name
            if (ACustomer.FirstName != "David")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Last Name
            if (ACustomer.LastName != "Pike")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Date of Birth
            if (ACustomer.DateOfBirth != new DateTime(1982, 7, 23))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the E-mail
            if (ACustomer.EmailAddress != "DaveyDave@Gmail.com")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void MobilePhoneNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Screening ID
            if (ACustomer.MobilePhoneNo != 07775828423)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Password
            if (ACustomer.Password != "Swordfish")
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
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "D";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "Da";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "Davesonnyboy";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "DaveDaveDaveDaveDaveDave";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "DaveDaveDaveDaveDaveDavid";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'A');
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "H";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Ha";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddockinggy";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "HaddockHaddockHaddockHad";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "HaddockHaddockHaddockHadd";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            string FirstName = "David";
            //Create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'A');
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            string DateOfBirth = TestDate.ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            //Create a variable to store test data
            DateTime TestDate;
            //Set the date
            TestDate = DateTime.Now;
            //Change to date to be 100 years in the future
            TestDate = TestDate.AddYears(100);
            string DateOfBirth = TestDate.ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = "Bing bong diddly bingus";
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "D@G.c";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "D@G.Co";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "D@G.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "DavidFisshyboii@gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "DavesNotHereMannyStopRingingTheDoorbell@gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressNameMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "DavesNotHereMannyStopRingingTheDoorbells@gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store and error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'A');
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobilePhoneNoMinLessOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "0777582842";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobilePhoneNoMaxPlusOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "077758284233";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobilePhoneNoMid()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobilePhoneNoInvalidData()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "Not a phone number!";
            string Password = "Anglerfish";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "A";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PassWordMinPlusOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "An";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "Anglerfisshy";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "AnglerfishAreNotEntirely";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "AnglerfishAreNotEntirelyy";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "AnglerfishAreNotEntirelyyy";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //Create an instance of the class we want toc reate
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store an error message
            String Error = "";
            //Create some test data to pass to the method
            string FirstName = "David";
            string LastName = "Haddock";
            string DateOfBirth = new DateTime(1982, 7, 23).ToString();
            string EmailAddress = "OtherDave@Gmail.com";
            string MobilePhoneNo = "07775828423";
            string Password = "";
            Password = Password.PadRight(500, 'A');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, MobilePhoneNo, Password);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
