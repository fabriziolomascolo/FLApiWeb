using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace FLApiWeb.Models
{
    [Table("PatologiaTerapie")]
    public class PatologiaTerapie
    {
        [Key, Column(Order = 0)]
        [StringLength(10)]
        [JsonProperty(PropertyName = "codPat")]
        public string CodPat { get; set; }
        [Key, Column(Order = 1)]
        [StringLength(10)]
        [JsonProperty(PropertyName = "codTer")]
        public string CodTer { get; set; }
   }
}