using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //fields
    class student
    {
        public int id { get; set; } 
        public string name { get; set; }    
        public string adress { get; set; }

        public void showdetail()
        {
            Console.WriteLine("student information");
            Console.WriteLine("id : {0}, name : {1}, adress : {2} ", id, name, adress);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student st=new student();
            st.id = 1;
            st.name = "Manish Tomar";
            st.adress = "Meerut";

            st.showdetail();
            Console.ReadLine();
        }
    }
}
