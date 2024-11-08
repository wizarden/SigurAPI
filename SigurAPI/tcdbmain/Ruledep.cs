using System;
using System.Collections.Generic;

namespace SigurAPI.tcdbmain
{
    public partial class Ruledep
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public int? Poweridx { get; set; }
    }
}
