using System;
using System.Collections.Generic;
using System.Text;

namespace Movies
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        //Changes on constructor from rating to => Rating we are calling the Method
        public Movie(string aTitle, string aDircetor, string aRating) 
        {
            title = aTitle;
            director = aDircetor;
            Rating = aRating;
        }

        //Method
        public string Rating 
        {
            //geter and seter
            get { return rating; }
            set 
            {
                // To write || use alt and 124 on num pad
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else 
                {
                    rating = "NR";
                }
            }
        }
    }
}
