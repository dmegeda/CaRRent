using CaRRent.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaRRent.DAL.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
    }
}
