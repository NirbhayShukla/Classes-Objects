using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Students
    {
        int rollno, marksinEng, marksInMaths, marksInScience;
        string name;

        public Students(string name, int rollno, int marksinEng,int marksInMaths,int marksInScience)
        {
            this.name = name;
            this.rollno = rollno;
            this.marksinEng = marksinEng;
            this.marksInScience = marksInScience;
            this.marksInMaths = marksInMaths;
        }

        public int total()
        {
            return marksInMaths + marksinEng + marksInScience;
        }

        public double percentage()
        {
            int totalM = total();
            return totalM / 3;
        }

        public void display()
        {
            Console.WriteLine($"Name : {name} RollNo : {rollno}");
            Console.WriteLine("Total = "+total());
            Console.WriteLine("Percentage = "+percentage());
        }


        public static void Main(string[] args)
        {
            Students s = new Students("Nirbhay", 2, 89, 98, 97);
            s.display();
        }
    }
}
