using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class NonTeachingStaff : StaffDetails
    {
        private double basic_salary;
        private readonly int _da, _hra, _cca, _pf;

        public NonTeachingStaff(string? collegename, string? collegeaddress, int eno, string? name, string? address, double basic_salary, int da, int hra, int cca, int pf) : base(collegename,collegeaddress, eno, name, address)
        {
            this.basic_salary = basic_salary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public double Basic_salary { get => basic_salary; set => basic_salary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float netsal = (float)(Basic_salary + (Basic_salary * ((float)Da / 100) + Basic_salary * ((float)Hra / 100) + Basic_salary * ((float)Cca / 100) - Basic_salary * ((float)Pf / 100)));
            return netsal;
        }
    }
}
