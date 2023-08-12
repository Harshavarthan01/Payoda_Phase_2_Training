using EFDBF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBF
{
    internal class CRUD
    {
        public void InsertNewRecords()
        {
            using (var context = new EmployeeMgmtContext())
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
            var context = new EmployeeMgmtContext();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 18);
            selectedEmp.Empname = "Potter";
            context.SaveChanges();
        }
        public void DeleteRecord()
        {
            var context = new EmployeeMgmtContext();

            var selectedEmp = context.Depts.FirstOrDefault(d => d.Deptno == 18);
            context.Depts.Remove(selectedEmp);
            context.SaveChanges();
        }
        
    }
}
