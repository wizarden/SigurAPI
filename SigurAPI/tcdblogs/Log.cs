using System;
using System.Collections.Generic;

namespace SigurAPI.tcdblogs
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateTime? Logtime { get; set; }
        public long Framets { get; set; }
        public int? Area { get; set; }
        public byte[]? Logdata { get; set; }
        public int? Emphint { get; set; }
        public int? Devhint { get; set; }
    }
}
