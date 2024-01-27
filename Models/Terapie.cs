using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace FLApiWeb.Models
{
    [Table("Terapie")]
    public class Terapie
    {
        [Key]
        [StringLength(10)]
        [JsonProperty(PropertyName = "codTer")]
        public string codTer { get; set; }
        [StringLength(50)]
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }
        [StringLength(3000)]
        [JsonProperty(PropertyName = "descrizione")]
        public string Descrizione { get; set; }
        [StringLength(250)]
        [JsonProperty(PropertyName = "costo")]
        public string Costo { get; set; }
        [StringLength(250)]
        [JsonProperty(PropertyName = "immagine")]
        public string Immagine { get; set; }
        [StringLength(250)]
        [JsonProperty(PropertyName = "video")]
        public string Video { get; set; }
        [StringLength(1)]
        [JsonProperty(PropertyName = "tipo")]
        public string Tipo { get; set; }
        [JsonProperty(PropertyName = "ishome")]
        public Boolean IsHome { get; set; }
        //[JsonProperty(PropertyName = "patologie")]
        //public List<Patologie> ListaPatologie { get; set; }

    }
}