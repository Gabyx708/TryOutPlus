using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Machine
    {
        public required string MachineNumber { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
