class student
{
    public string name;
    public string major;
    public double gpa;
    /*
    public Book(){

    }   */

    public student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool hasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

}