namespace FindRBeta.Models
{
    enum Zone
    {
        Central,
        Periferial
    }
    public class Location
    {
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }



    }
}