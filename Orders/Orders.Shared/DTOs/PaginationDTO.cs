using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.DTOs
{
    public class PaginationDTO
    {
        public int ID { get; set; }
        public int Page { get; set; } = 1;
        public int RecordsNumber { get; set; } = 10;
    }
}