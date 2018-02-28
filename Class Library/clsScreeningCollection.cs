using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsScreeningCollection
    {
        //Private data member for the list
        List<clsScreening> mScreeningList = new List<clsScreening>();
        //Private data member thisScreening
        clsScreening mThisScreening = new clsScreening();

        //Constructor for the class
        public clsScreeningCollection()
        {
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblScreening_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsScreening> ScreeningList
        {
            get
            {
                //Return the private data
                return mScreeningList;
            }
            set
            {
                //Set the private data
                mScreeningList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return mScreeningList.Count;
            }
            set
            {
                //Ooga booga
            }
        }

        //Public property for ThisScreening
        public clsScreening ThisScreening
        {
            get
            {
                //Return the private data
                return mThisScreening;
            }
            set
            {
                //Set the private data
                mThisScreening = value;
            }
        }

        //Public property for Add
        public int Add()
        {
            //Adds a new record to the database based on the values of mThisScreening
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@FilmID", mThisScreening.FilmID);
            DB.AddParameter("@ScreenID", mThisScreening.ScreenID);
            DB.AddParameter("@ScreeningCost", mThisScreening.ScreeningCost);
            DB.AddParameter("@ScreeningDate", mThisScreening.ScreeningDate);
            DB.AddParameter("@Cancelled", mThisScreening.Cancelled);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblScreening_Insert");
        }

        //Public property for Cancel
        public void Cancel()
        {
            //Update the value of Cancelled from False to True
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameter for the stored procedure
            DB.AddParameter("@ScreeningID", mThisScreening.ScreeningID);
            //Execute the stored procedure
            DB.Execute("sproc_tblScreening_Cancel");
        }

        //Public property for FilterByCancelled
        //TODO REMIND MATT TO FINISH
        public void FilterByCancelled(Boolean Cancelled)
        {
            //Filters the records based on whether they are cancelled or not
            //Connect to the database
            clsDataConnection Db = new clsDataConnection();
            //Send the Cancelled parameter to the database
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
            mScreeningList = new List<clsScreening>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Film
                clsScreening AScreening = new clsScreening();
                //Read in the fields from a current record
                AScreening.ScreeningID = Convert.ToInt32(DB.DataTable.Rows[Index]["ScreeningID"]);
                AScreening.FilmID = Convert.ToInt32(DB.DataTable.Rows[Index]["FilmID"]);
                AScreening.ScreenID = Convert.ToInt32(DB.DataTable.Rows[Index]["ScreenID"]);
                AScreening.ScreeningCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["ScreeningCost"]);
                AScreening.ScreeningDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ScreeningDate"]);
                AScreening.Cancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["Cancelled"]);
                //Add the record to the private data member
                mScreeningList.Add(AScreening);
                //Point at the next record
                Index++;
            }
        }
    }
}