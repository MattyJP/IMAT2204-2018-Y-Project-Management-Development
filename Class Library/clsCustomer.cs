using System;
namespace Class_Library
{
    public class clsCustomer
    {
        //Private data member for the CustomerrID property
        private Int32 mCustomerID;
        //Private data member for the FirstName property
        private string mFirstName;
        //Private data member for the LastName property
        private string mLastName;
        //Private data member for the DateOfBirth property
        private DateTime mDateOfBirth;
        //Private data member for the EmailAddress property
        private string mEmailAddress;
        //Private data member for the MobilePhoneNo property
        private long mMobilePhoneNo;
        //Private data member for the Password property
        private string mPassword;


        public int CustomerID
        {
            get
            {
                //Return the private data
                return mCustomerID;
            }
            set
            {
                //Set the value of the private data member
                mCustomerID = value;
            }
        }

        public string FirstName
        {
            get
            {
                //Return the private data
                return mFirstName;
            }
            set
            {
                //Set the value of the private data member
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                //Return the private data
                return mLastName;
            }
            set
            {
                //Set the value of the private data member
                mLastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //Return the private data
                return mDateOfBirth;
            }
            set
            {
                //Set the value of the private data member
                mDateOfBirth = value;
            }
        }


        public string EmailAddress
        {
            get
            {
                //Return the private data
                return mEmailAddress;
            }
            set
            {
                //Set the value of the private data member
                mEmailAddress = value;
            }
        }

        public long MobilePhoneNo
        {
            get
            {
                //Return the private data
                return mMobilePhoneNo;
            }
            set
            {
                //Set the value of the private data member
                mMobilePhoneNo = value;
            }
        }

        public string Password
        {
            get
            {
                //Return the private data
                return mPassword;
            }
            set
            {
                //Set the value of the private data member
                mPassword = value;
            }
        }

        public bool Find(Int32 CustomerID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Screening title to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            //If one record is found (There should be either one or zero
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mMobilePhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["MobilePhoneNo"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //Return that everything worked OK
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string dateOfBirth, string emailAddress, string mobilePhoneNo, string password)
        {
            //Create a string variable to store the error
            string Error = "";
            //Create a temporary variable to store date values
            DateTime DateTemp;
            //If the FirstName is blank
            if (firstName.Length == 0)
            {
                //Record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //If the FirstName is longer than 25 characters
            if (firstName.Length > 25)
            {
                //Record the error
                Error = Error + "The First Name may not be longer than 25 characters : ";
            }
            //If the LastName is blank
            if (lastName.Length == 0)
            {
                //Record the error
                Error = Error + "The Last Name may not be blank : ";
            }
            //If the LastName is longer than 25 characters
            if (lastName.Length > 25)
            {
                //Record the error
                Error = Error + "The Last Name may not be longer than 25 characters : ";
            }
            //Tries to check of the ScreeningDate data is valid
            try
            {
                //Copy the DateOfBirth variable to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the Future : ";
                }
            }
            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date : ";
            }
            //If the EmailAddress is blank
            if (emailAddress.Length == 0)
            {
                //Record the error
                Error = Error + "The Email Address may not be blank : ";
            }
            //If the EmailAddress is longer than 50 characters
            if (emailAddress.Length > 50)
            {
                //Record the error
                Error = Error + "The Email Address may not be longer than 50 characters : ";
            }
            //If the MobilePhoneNo is longer than 11 characters
            if (mobilePhoneNo.Length > 11)
            {
                //Record the error
                Error = Error + "The Mobile Phone Number must be 11 characters long : ";
            }
            //If the MobilePhoneNo is less than 11 characters
            if (mobilePhoneNo.Length > 0 && mobilePhoneNo.Length < 11)
            {
                //Record the error
                Error = Error + "The Mobile Phone Number must be 11 characters long : ";
            }
            //If the Password is blank
            if (password.Length == 0)
            {
                //Record the error
                Error = Error + "The Password may not be blank : ";
            }
            //If the Password is longer than 25 characters
            if (password.Length > 25)
            {
                //Record the error
                Error = Error + "The Password may not be longer than 25 characters : ";
            }
            //Return any error messages
            return Error;
        }
    }
}