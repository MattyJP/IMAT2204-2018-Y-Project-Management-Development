using System;
namespace Class_Library
{
    public class clsTicket
    {
        //Private data member for the TicketID property
        private Int32 mTicketID;
        //Private data member for the CustomerID property
        private Int32 mCustomerID;
        //Private data member for the ScreeningID property
        private Int32 mScreeningID;
        //Private data member for the Validated property
        private bool mValidated;
        //Private data member for the StaffID Property
        private Int32 mStaffID;
        //Private data member for the ManagerID property
        private Int32 mManagerID;
        //Private data member for the Cancelled property
        private bool mCancelled;

        public int TicketID
        {
            get
            {
                //Return the private data
                return mTicketID;
            }
            set
            {
                //Set the value of the private data member
                mTicketID = value;
            }
        }


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


        public int ScreeningID
        {
            get
            {
                //Return the private data
                return mScreeningID;
            }
            set
            {
                //Set the value of the private data member
                mScreeningID = value;
            }
        }

        public Boolean Validated
        {
            get
            {
                //Return the private data
                return mValidated;
            }
            set
            {
                //Set the value of the private data member
                mValidated = value;
            }
        }

        public int StaffID
        {
            get
            {
                //Return the private data
                return mStaffID;
            }
            set
            {
                //Set the value of the private data member
                mStaffID = value;
            }
        }

        public int ManagerID
        {
            get
            {
                //Return the private data
                return mManagerID;
            }
            set
            {
                //Set the value of the private data member
                mManagerID = value;
            }
        }

        public Boolean Cancelled
        {
            get
            {
                //Return the private data
                return mCancelled;
            }
            set
            {
                //Set the value of the private data member
                mCancelled = value;
            }
        }

        public bool Find(Int32 TicketID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Screening title to search for
            DB.AddParameter("@ScreeningID", ScreeningID);
            //Execute the stored procedure
            DB.Execute("sproc_tblTicket_FilterByCancelled");
            //If one record is found (There should be either one or zero
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mTicketID = Convert.ToInt32(DB.DataTable.Rows[0]["TicketID"]);
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
    }
}