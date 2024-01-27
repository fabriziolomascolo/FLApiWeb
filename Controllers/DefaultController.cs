using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Http;
using FLApiWeb.Models;
using System.Data.Entity;
using FLApiWeb.Service;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace FLApiWeb.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly ITerapieRepository TerapieRepository;
        private readonly IPatologieRepository PatologieRepository;

        public DefaultController(ITerapieRepository TerapieRepository, IPatologieRepository PatologieRepository) //, IMapper mapper)
        {
            this.TerapieRepository = TerapieRepository;
            this.PatologieRepository = PatologieRepository;
        }


        // GET: api/Terapie
        //opzione b
        //estraggo tutte le terapie, le patologie e le associazioni tra terapia e patologie e quella tra patologia e terapie
        //restituisco al chiamante un oggetto contenente queste quattro liste
        [Route("Default/Get")]
        public async Task<TerapieEPatologie> Get()
        {
            TerapieEPatologie terepat = new TerapieEPatologie();
            terepat.ListaTerapie = await this.TerapieRepository.GetTerapie();
            terepat.ListaPatologie = await this.PatologieRepository.GetPatologie();
            terepat.ListaTerapiaPatologie = await this.TerapieRepository.GetTerapiaPatologie();
            terepat.ListaPatologiaTerapie = await this.PatologieRepository.GetPatologiaTerapie();
            return terepat;
        }

        // GET: api/Terapie
        //opzione b
        //estraggo tutte le terapie, le patologie e le associazioni tra terapia e patologie e quella tra patologia e terapie
        //restituisco al chiamante un oggetto contenente queste quattro liste
        [Route("Default/Get/{value}")]
        public async Task<TerapieEPatologie> Get(string value)
        {
            TerapieEPatologie terepat = new TerapieEPatologie();
            terepat.ListaTerapie = await this.TerapieRepository.SearchTerapieContainsValue(value);
            terepat.ListaPatologie = await this.PatologieRepository.GetPatologie();
            terepat.ListaTerapiaPatologie = await this.TerapieRepository.GetTerapiaPatologie();
            terepat.ListaPatologiaTerapie = await this.PatologieRepository.GetPatologiaTerapie();
            return terepat;
        }

        
    }
}

