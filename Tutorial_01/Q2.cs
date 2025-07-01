using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            String  name , dob , addr , city , state , country , mail;
            int pincode;

            Console.Write("Enter Name :- ");
            name = Console.ReadLine();
            Console.Write("Enter DOB :- ");
            dob = Console.ReadLine();
            Console.Write("Enter Address :- ");
            addr = Console.ReadLine();
            Console.Write("Enter City :- ");
            city = Console.ReadLine();
            Console.Write("Enter Pin Code :- ");
            pincode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter State :- ");
            state = Console.ReadLine();
            Console.Write("Enter Country :- ");
            country = Console.ReadLine();
            Console.Write("Enter Mail :- ");
            mail = Console.ReadLine();

            Console.WriteLine("------ Your Details ------\n" +
                "Name :- "+name+"\nDOB :- "+ dob+ "\nAddress :- "+addr+"\nCiry :- "+city+"\nPincode :- "+pincode+"\nState :- "+state+
                "\nCountry :- "+country+"\nMail :- "+mail);



        }
    }
}
