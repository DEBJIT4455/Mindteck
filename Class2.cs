using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myconsoleapplication
{
    using System;
    namespace myconsoleapplication
    {
        class debjit
        {
            static void Main(string[] args)
            {
                var customer = new List<showroom>()
            {
                new showroom(){ cust_id=1,cust_Fname="Debjit",cust_lname="Purkaite",Bike_no=1265},
                new showroom(){ cust_id=2,cust_Fname="sham",cust_lname="De",Bike_no=158},
                new showroom(){ cust_id=3,cust_Fname="suvo",cust_lname="dey",Bike_no=1894},
                new showroom(){ cust_id=4,cust_Fname="nishan",cust_lname="Mal",Bike_no=1368},
                new showroom(){ cust_id=5,cust_Fname="souvik",cust_lname="ghosh",Bike_no=1458},
                new showroom(){ cust_id=6,cust_Fname="tania",cust_lname="ghosh",Bike_no=1589},

            };
                var Bikeno = from bno in customer
                             where bno.cust_Fname == "Debjit"
                             select bno;
                foreach (var item in Bikeno)
                    Console.WriteLine(item.cust_Fname + " " + item.Bike_no);


            }
        }
        public class showroom
        {
            public int cust_id { get; set; }
            public string cust_Fname { get; set; }
            public string cust_lname { get; set; }
            public int Bike_no { get; set; }
        }

    }
}
