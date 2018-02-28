using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsFilmCollection
    {
        //Private data member for the list
        List<clsFilm> mFilmList = new List<clsFilm>();
        //Private data member thisFilm
        clsFilm mThisFilm = new clsFilm();

        //Constructor for the class
        public clsFilmCollection()
        {
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblFilm_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsFilm> FilmList
        {
            get
            {
                //Return the private data
                return mFilmList;
            }
            set
            {
                //Set the private data
                mFilmList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return mFilmList.Count;
            }
            set
            {
                //Ooga booga
            }
        }

        //Public property for ThisFilm
        public clsFilm ThisFilm
        {
            get
            {
                //Return the private data
                return mThisFilm;
            }
            set
            {
                //Set the private data
                mThisFilm = value;
            }
        }

        //Public property for Add
        public int Add()
        {
            //Adds a new record to the database based on the values of mThisFilm
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisFilm.Title);
            DB.AddParameter("@Duration", mThisFilm.Duration);
            DB.AddParameter("@AgeRatingID", mThisFilm.GenreID);
            DB.AddParameter("@Title", mThisFilm.Title);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblFilm.Insert");
        }

        public void FilterByTitle(string Title)
        {
            //Filters the records based on a full of partial title
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the Title parameter to the database
            DB.AddParameter("@Title", Title);
            //Execute the stored procedure
            DB.Execute("sproc_tblFilm_FilterByTitle");
            //Populate the array list with the data table
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
            mFilmList = new List<clsFilm>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank Film
                clsFilm AFilm = new clsFilm();
                //Read in the fields from a current record
                AFilm.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AFilm.Duration = Convert.ToInt32(DB.DataTable.Rows[Index]["Duration"]);
                AFilm.AgeRatingID = Convert.ToInt32(DB.DataTable.Rows[Index]["AgeRatingID"]);
                AFilm.GenreID = Convert.ToInt32(DB.DataTable.Rows[Index]["GenreID"]);
                //Add the record to the private data member
                mFilmList.Add(AFilm);
                //Point at the next record
                Index++;
            }
        }
    }
}