using System;
using System.Collections.Generic;

namespace SigurAPI.tcdbmain
{
    public partial class PersonalKey
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public byte[]? Codekey { get; set; }
        public string? CodekeyDesc { get; set; }
        public DateTime? Codekeytime { get; set; }
        public string? CodekeyDispFormat { get; set; }
        public byte[]? MfUid { get; set; }
        public DateTime? Exptime { get; set; }
    }
}
