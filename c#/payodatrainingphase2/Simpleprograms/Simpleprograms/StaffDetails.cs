using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class StaffDetails :College
    {
        int eno;
        private string? name,address;

        public StaffDetails(string? collegename, string? collegeaddress,int eno, string? name, string? address) :base(collegename, collegeaddress)
        {
            this.eno = eno;
            this.name = name;
            this.address = address;
        }

        public int Eno { get => eno; set => eno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }
}
