using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Construct
    {
        
        // chain constructor

        public Construct(string movie) : this(10, movie)
        {

        }

        // constructor
        public Construct(int ID, string movie)
        {
            movieName = movie;
            movieID = ID;

        }
        //properties
        public string movieName { get; set; }
        public int movieID { get; set; }




    }
}
