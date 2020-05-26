using System;
using System.ComponentModel.DataAnnotations;

namespace sample_efcore
{
    public class tempView
    {
        [Key]
        public string Id{set;get;}
        public string Name {set;get;}
    }
}