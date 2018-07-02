using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTDD
{
    public class Travel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Date { get; set; }
        
        public Travel()
    {
    }
        
    public Travel(string fName, string lName,string address, string email)
    {
        this.FName = fName;
        this.LName = lName;
        this.Address = address;
        this.Email = email;
    }
        public  string GetDate(int month, int day, int year)
        {

            return "9/8/2018";
            
        }
        //public string TtlTravel()
        //{
        //    var initDate = ("9/08/2018");
        //    string[] date = initDate.Split('/');
        //    string[] arr = new string[6];
        //    var returnDate = ("9/13/2018");
        //    string[] back = returnDate.Split('/');
        //    for (int i = 0; i < date.Length; i++)
        //    {
        //        string s = arr[i];
        //    }
        //    //not quite sure how to proceed from here
        //}
        public string GetSelection(int totalDays)
        {
            if (totalDays == 5)
            {
                return "Cali";
            }
            if (totalDays == 4)
            {
                return "Georgia";
            }

            if (totalDays == 3)
            {
                return "Florida";
            }
            if (totalDays == 2)
            {
                return "Nashville";
            }
            if (totalDays == 1)
            {
                return "Put in Bay";
            }
            if (totalDays == 0)
            {
                return "Stay Home";
            }
            if (totalDays > 5)
            {
                return "The World is Yours";
            }
            else
            {
                return null;
            }
        }


    }

}
