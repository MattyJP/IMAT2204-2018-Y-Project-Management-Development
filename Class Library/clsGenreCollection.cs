using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsGenreCollection
    {
        //Public constructor for the class
        public clsGenreCollection()
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure to get the list of data
            DB.Execute("sproc_tblGenre_SelectAll");
            //Get the count of records
            Int32 RecordCount = DB.Count;
            //Set up the index for the loop
            Int32 Index = 0;
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a new instance of the genre class
                clsGenre AGenre = new clsGenre();
                //Get the genre title
                AGenre.GenreTitle = DB.DataTable.Rows[Index]["GenreTitle"].ToString();
                //Get the primary key
                AGenre.GenreID = Convert.ToInt32(DB.DataTable.Rows[Index]["GenreID"]);
                //Add the genre to the private data member
                mGenreList.Add(AGenre);
                //Increment the index
                Index++;
            }
        }

        //Private data member for the GenreList list
        private List<clsGenre> mGenreList = new List<clsGenre>();

        //Public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mGenreList.Count;
            }
            set
            {
                //TODO
            }
        }

        //Public property for GenreList
        public List<clsGenre> GenreList
        {
            get
            {
                //Return the private data member
                return mGenreList;
            }
            set
            {
                //Assign the incoming value to the private data member
                mGenreList = value;
            }
        }

    }
}