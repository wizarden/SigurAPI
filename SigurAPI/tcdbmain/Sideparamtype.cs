using System;
using System.Collections.Generic;

namespace SigurAPI.tcdbmain
{
    public partial class Sideparamtype
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public int? ParamIdx { get; set; }
        public int? OrderIdx { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public bool? Readonly { get; set; }
        public string? Params { get; set; }
        public bool? PersonalEmpRelated { get; set; }
        public bool? PersonalCarRelated { get; set; }
        public bool? PersonalGuestRelated { get; set; }
    }
}
