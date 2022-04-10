using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
 class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string college { get; set; }    
        //default constructor 
        public student ()
        {
            college = "JPIET";
        }
        //parameterized constructor
        public student(int Id, string Nmae, string college)
        {
            this.Id= Id;    
            this.Name = Nmae;
            this.college = college;
        }
        public student(int Id, string Nmae )
        {
            this.Id = Id;
            this.Name = Nmae;
            
        }
    }
 
     class Program
    {
        static void Main(string[] args)
        {
            // student st=new student();
            // Console.WriteLine("Id : {0}, Name : {1}, college : {2} ", st.Id, st.Name, st.college);
            // student st = new student(25, "Manish Tomar","miet") ;
            //  Console.WriteLine("Id : {0}, Name : {1}, college : {2} ", st.Id, st.Name, st.college);
            student st = new student(25, "Manish Tomar");
            Console.WriteLine("Id : {0}, Name : {1}, college : {2} ", st.Id, st.Name);
            Console.ReadLine();
        }
    }
}
