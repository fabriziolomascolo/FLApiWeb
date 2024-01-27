using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FLApiWeb.Models;
using System.Data.Entity;
using FLApiWeb.Service;

namespace FLApiWeb.Controllers
{
    [RoutePrefix("terapie")]
    public class TerapieController : ApiController
    {
        private readonly ITerapieRepository TerapieRepository;
        private readonly IPatologieRepository PatologieRepository;
        //private readonly IMapper mapper;

        public TerapieController(ITerapieRepository TerapieRepository, IPatologieRepository PatologieRepository) //, IMapper mapper)
        {
            this.TerapieRepository = TerapieRepository;
            this.PatologieRepository = PatologieRepository;
            //this.mapper = mapper;
        }


        // GET: api/Terapie
        [HttpGet]
        [Route("")]
        //opzione b
        //estraggo tutte le terapie, le patologie e le associazioni tra terapia e patologie e quella tra patologia e terapie
        //restituisco al chiamante un oggetto contenente queste quattro liste
        public async Task<TerapieEPatologie> GetTerapie()
        {
            TerapieEPatologie terepat = new TerapieEPatologie();
            terepat.ListaTerapie = await this.TerapieRepository.GetTerapie();
            terepat.ListaPatologie = await this.PatologieRepository.GetPatologie();
            terepat.ListaTerapiaPatologie = await this.TerapieRepository.GetTerapiaPatologie();
            terepat.ListaPatologiaTerapie = await this.PatologieRepository.GetPatologiaTerapie();
            return terepat;
        }


        // GET: api/Terapie/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Terapie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Terapie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Terapie/5
        public void Delete(int id)
        {
        }
    }
}
