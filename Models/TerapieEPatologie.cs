using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace FLApiWeb.Models
{
    [Table("TerapieEPatologie")]
    public class TerapieEPatologie
    {
        public List<Terapie> ListaTerapie { get; set; }
        public List<Patologie> ListaPatologie { get; set; }
        public List<TerapiaPatologie> ListaTerapiaPatologie { get; set; }
        public List<PatologiaTerapie> ListaPatologiaTerapie { get; set; }
    }
}