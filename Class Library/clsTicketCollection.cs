using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsTicketCollection
    {
        //Private data member for the list
        List<clsTicket> mTicketList = new List<clsTicket>();
        //Private data member thisScreening
        clsTicket mThisTicket = new clsTicket();

        //Constructor for the class
        public clsTicketCollection()
        {
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblTicket_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsTicket> TicketList
        {
            get
            {
                //Return the private data
                return mTicketList;
            }
            set
            {
                //Set the private data
                mTicketList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return mTicketList.Count;
            }
            set
            {
                //Ooga booga
            }
        }

        //Public property for ThisTicket
        public clsTicket ThisTicket
        {
            get
            {
                //Return the private data
                return mThisTicket;
            }
            set
            {
                //Set the private data
                mThisTicket = value;
            }
        }

        //Public property for Add
        public int Add()
        {
            //Adds a new record to the database based on the values of mThisTicket
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisTicket.CustomerID);
            DB.AddParameter("@ScreeningID", mThisTicket.ScreeningID);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblTicket_Insert");
        }

        //Public property for Cancel
        public void Cancel()
        {
            //Update the value of Cancelled from False to True
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameter for the stored procedure
            DB.AddParameter("@ScreeningID", mThisTicket.ScreeningID);
            //Execute the stored procedure
            DB.Execute("sproc_tblTicket_Cancel");
        }

        //Public property for Validate
        public void Validate()
        {
            //Update the value of Validated from False to True
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameter for the stored procedure
            DB.AddParameter("@ScreeningID", mThisTicket.ScreeningID);
            //Execute the stored procedure
            DB.Execute("sproc_tblTicket_Validate");
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
            mTicketList = new List<clsTicket>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Film
                clsTicket ATicket = new clsTicket();
                //Read in the fields from a current record
                ATicket.TicketID = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketID"]);
                ATicket.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ATicket.ScreeningID = Convert.ToInt32(DB.DataTable.Rows[Index]["ScreeningID"]);
                ATicket.Validated = Convert.ToBoolean(DB.DataTable.Rows[Index]["Validated"]);
                ATicket.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                ATicket.ManagerID = Convert.ToInt32(DB.DataTable.Rows[Index]["ManagerID"]);
                ATicket.Cancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["Cancelled"]);
                //Add the record to the private data member
                mTicketList.Add(ATicket);
                //Point at the next record
                Index++;
            }
        }
    }
}