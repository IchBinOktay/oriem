using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Entities
{
    internal class Grade:BaseEntity
    {
        public decimal Point { get; set; }
        public int AsingmentId { get; set; }
    }
}
