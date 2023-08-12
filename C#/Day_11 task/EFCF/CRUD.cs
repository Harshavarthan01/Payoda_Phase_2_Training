using EFCF.Models;
using EFCF.Models.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {
        public void InsertNewRecords()
        {
            using (var context = new EmployeeManagement())
            {
               

                var emp = new Emp()
                {
                    Empno = 12345,
                    Empname = "Harsha",
                    Deptno = 18
                };
                context.Emps.Add(emp);
                context.SaveChanges();


            }
        }
        public void UpdateRecords()
        {
            var context = new EmployeeManagement();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 18);
            selectedEmp.Empname = "Harsha";
            context.SaveChanges();
        }
        public void DeleteRecord()
        {
            var context = new EmployeeManagement();

            var selectedEmp = context.Depts.FirstOrDefault(d => d.Deptno == 18);
            context.Depts.Remove(selectedEmp);
            context.SaveChanges();
        }
        
    }
}
