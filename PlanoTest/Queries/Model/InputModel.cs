using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoTestAPI.Queries.Model
{
    public class InputModel
    { 
        [Required] 
            public string CurrCode { get; set; }
        [Required]
        [Range(0, Int32.MaxValue)]
        public decimal Amount { get; set; }
        [Required] 
            public string TargetCode { get; set; }
 
    }
}
