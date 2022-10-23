using System;
using System.Collections.Generic;

namespace ConsoleApp_EF_Entity_Framework_Core_
{
    public partial class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long? Age { get; set; }
    }
}
