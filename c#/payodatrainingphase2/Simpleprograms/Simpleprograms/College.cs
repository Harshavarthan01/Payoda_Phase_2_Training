using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class College
    {
        private string? collegename, collegeaddress;

        public College(string? collegename, string? collegeaddress)
        {
            this.collegename = collegename;
            this.collegeaddress = collegeaddress;
        }

        public string? Collegename { get => collegename; set => collegename = value; }
        public string? Collegeaddress { get => collegeaddress; set => collegeaddress = value; }
    }
}
