using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class StudentGrade : StudentMarks
    {
        public StudentGrade(string? collegename, string? collegeaddress, int rno, string? name, string? address, int m1, int m2, int m3) : base(collegename,collegeaddress, rno, name, address, m1, m2, m3)
        {
        }
        public char CalculateGrade()
        {
            double average = Calculateaverage();
            if(average >= 90) 
            { 
                return'A';
            }
            else if(average >= 80 && average < 90)
            {
                return 'B';
            }
            else
            {
                return 'U';
            }
        }
    }
}
