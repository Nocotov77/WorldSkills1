using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_EntityFrameworkCore_
{
    public partial class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long? Age { get; set; }
    }
}
