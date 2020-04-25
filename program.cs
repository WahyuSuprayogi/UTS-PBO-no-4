using pbo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbono4
{
    class program
    {
        static void Main(string[] args)
        {
            course perkuliahan = new course();
            Instructor dosen = new Instructor();
            TextBook book = new TextBook();

            dosen.setfirstName("Ponaryo");
            dosen.setlastName("Astaman");
            dosen.setofficeNumber(1);

            book.setAuthor("Pidi Baiq");
            book.setPublishser("Airlangga");
            book.setTitle("Akutansi Untuk Pemula");

            Console.ReadKey();
           }
    }
}
