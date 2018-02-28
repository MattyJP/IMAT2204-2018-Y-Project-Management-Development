using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsCustomerCollection
    {
        //Private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //Private data member ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //Constructor for the class
        public clsCustomerCollection()
        {
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //Return the private data
                return mCustomerList;
            }
            set
            {
                //Set the private data
                mCustomerList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //Ooga booga
            }
        }

        //Public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //Return the private data
                return mThisCustomer;
            }
            set
            {
                //Set the private data
                mThisCustomer = value;
            }
        }

        //Public property for Add
        public int Add()
        {
            //Adds a new record to the database based on the values of mThisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@MobilePhoneNo", mThisCustomer.MobilePhoneNo);
            DB.AddParameter("@Password", mThisCustomer.Password);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        //Public property for Update
        public void Update()
        {
            //Update the value of Cancelled from False to True
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@MobilePhoneNo", mThisCustomer.MobilePhoneNo);
            DB.AddParameter("@Password", mThisCustomer.Password);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void FilterByFirstName(string FirstName)
        {
            //filters the records based on a full or partial First Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByLastName(string LastName)
        {
            //filters the records based on a full or partial Last Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@LastName", LastName);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByLastName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByEmailAddress(string EmailAddress)
        {
            //filters the records based on a full or partial Email Address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@EmailAddress", EmailAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByEmailAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data table in the parameter DB
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count
            Int32 RecordCount;
            //Get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mCustomerList = new List<clsCustomer>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Film
                clsCustomer ACustomer = new clsCustomer();
                //Read in the fields from a current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.MobilePhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["MobilePhoneNo"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //Add the record to the private data member
                mCustomerList.Add(ACustomer);
                //Point at the next record
                Index++;
            }
        }
    }
}