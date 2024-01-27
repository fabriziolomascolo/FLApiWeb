using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace FLApiWeb.Models
{
    [Table("Patologie")]
    public class Patologie
    {
        [Key]
        [StringLength(10)]
        [JsonProperty(PropertyName = "codPat")]
        public string codPat { get; set; }
        [StringLength(50)]
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }
        [StringLength(3000)]
        [JsonProperty(PropertyName = "descrizione")]
        public string Descrizione { get; set; }
        [StringLength(250)]
        [JsonProperty(PropertyName = "immagine")]
        public string Immagine { get; set; }
        [StringLength(250)]
        [JsonProperty(PropertyName = "video")]
        public string Video { get; set; }
        [JsonProperty(PropertyName = "ishome")]
        public Boolean? IsHome { get; set; }

    }
}