using System;
using System.Collections.Generic;

namespace SigurAPI.tcdbmain
{
    public partial class Sideparamvalue
    {
        public int TableId { get; set; }
        public int ObjId { get; set; }
        public int ParamIdx { get; set; }
        public string? Value { get; set; }
    }
}
