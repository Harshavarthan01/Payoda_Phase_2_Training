using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class StudentDetails : College
    {
        private int rno;
        private string? name,address;

        public StudentDetails(string? collegename, string? collegeaddress, int rno, string? name, string? address) : base(collegename, collegeaddress)
        {
            Rno = rno;
            Name = name;
            Address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }
}
