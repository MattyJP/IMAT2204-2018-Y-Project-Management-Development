using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstSCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //test to test
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Set its properties
            TestItem.FirstName = "David";
            TestItem.LastName = "Haddock";
            TestItem.DateOfBirth = new DateTime(1982, 7, 23);
            TestItem.EmailAddress = "EvenMoreHaddock@gmail.com";
            TestItem.MobilePhoneNo = 07775828423;
            TestItem.Password = "Anglerfish";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //Set the properties of the test object
            TestItem.FirstName = "David";
            TestItem.LastName = "Haddock";
            TestItem.DateOfBirth = new DateTime(1982, 7, 23);
            TestItem.EmailAddress = "EvenMoreHaddock@gmail.com";
            TestItem.MobilePhoneNo = 07775828423;
            TestItem.Password = "Anglerfish";
            //Assign the data to the property
            AllCustomers.ThisCustomer = TestItem;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Set its properties
            TestItem.FirstName = "David";
            TestItem.LastName = "Haddock";
            TestItem.DateOfBirth = new DateTime(1982, 7, 23);
            TestItem.EmailAddress = "EvenMoreHaddock@gmail.com";
            TestItem.MobilePhoneNo = 07775828423;
            TestItem.Password = "Anglerfish";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Variable to store the primary kjey
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.FirstName = "David";
            TestItem.LastName = "Haddock";
            TestItem.DateOfBirth = new DateTime(1982, 7, 23);
            TestItem.EmailAddress = "EvenMoreHaddock@gmail.com";
            TestItem.MobilePhoneNo = 07775828423;
            TestItem.Password = "Anglerfish";
            //Set ThisFilm to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.FirstName = "David";
            TestItem.LastName = "Haddock";
            TestItem.DateOfBirth = new DateTime(1982, 7, 23);
            TestItem.EmailAddress = "EvenMoreHaddock@gmail.com";
            TestItem.MobilePhoneNo = 07775828423;
            TestItem.Password = "Anglerfish";
            //Set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //Modify the test data
            TestItem.FirstName = "Julia";
            TestItem.LastName = "Summers";
            TestItem.MobilePhoneNo = 07776828332;
            //Set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record.
            AllCustomers.Update();
            //Fihnd the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void FilterByFirstNameMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a blank string (Should return all records)
            FilteredCustomers.FilterByFirstName("");
            //Test to see that the teo values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByFirstNameNoneFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByFirstName("Scrambert");
            //Check to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByFirstNameTestDataFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByFirstName("Scrambert");
            //Check that the correct number of records are found
            if(FilteredCustomers.Count == 1)
            {
                //Check that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
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

        [TestMethod]
        public void FilterByLastNameMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a blank string (Should return all records)
            FilteredCustomers.FilterByLastName("");
            //Test to see that the teo values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByLastNameNoneFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByLastName("Scrambertson");
            //Check to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByLastNameTestDataFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByLastName("Scrambertson");
            //Check that the correct number of records are found
            if (FilteredCustomers.Count == 1)
            {
                //Check that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
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

        [TestMethod]
        public void FilterByEmailAddressMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a blank string (Should return all records)
            FilteredCustomers.FilterByEmailAddress("");
            //Test to see that the teo values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByEmailAddressNoneFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByEmailAddress("Scrambert@Fakemail.com");
            //Check to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByEmailAddressTestDataFound()
        {
            //Create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a first name that doesn't exist
            FilteredCustomers.FilterByEmailAddress("Scrambert@Fakemail.com");
            //Check that the correct number of records are found
            if (FilteredCustomers.Count == 1)
            {
                //Check that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
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
