using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Models
{
    internal class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empno { get; set; }

        [Required]
        public string? Empname { get; set; }

        public string? Address { get; set; }
        [Required,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Deptno { get; set; }

        public Dept? DeptNav { get; set; }
    }
}
