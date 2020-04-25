using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbono4;

namespace pbo2
{
    public class course
    {
        public string courseName;
        public Instructor instructor;
        public TextBook textbook;

        public void setCourse(string name)
        {
            this.courseName = name;
        }
        public string getCourse()
        {
            return courseName;
        }
        public void perkuliahan(Instructor dosen, TextBook book)
        {
            instructor = dosen;
            textbook = book;
        }
        public void lihatdataperkuliahan()
        {
            Console.WriteLine("Data Mata Kuliah");
            Console.WriteLine("Nomor Induk : " + instructor.getnip());
            Console.ReadKey();
        }
    }
}