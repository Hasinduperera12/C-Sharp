class Movie
{
    public string title;
    public string director;
    private string rating;
    /*
    public Book(){

    }   */

    public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                {
                    rating = value;
                }else
                {
                    rating = "NR";
                }
            }
        }

}