using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbono4
{
    public class Instructor
    {
        private string lastName;
        private string firstName;
        private int  officeNumber;

        public void setlastName(string Lnama)
        {
            this.lastName = Lnama;
        }
        public string getLnama()
        {
            return lastName;
        }
        public void setfirstName(string Fnama)
        {
            this.firstName = Fnama;
        }
        public string getFnama()
        {
            return firstName;
        }
        public void setofficeNumber(int nip)
        {
            this.officeNumber = nip;
        }
        public int getnip()
        {
            return officeNumber;
        }
    }
}
