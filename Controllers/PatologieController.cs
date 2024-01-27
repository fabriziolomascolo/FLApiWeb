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
    public class PatologieController : ApiController
    {
        private readonly IPatologieRepository PatologieRepository;
        //private readonly IMapper mapper;

        public PatologieController(IPatologieRepository PatologieRepository) //, IMapper mapper)
        {
            this.PatologieRepository = PatologieRepository;
            //this.mapper = mapper;
        }
        // GET: api/Patologie
        public async Task<List<Patologie>> GetPatologie()
        {
            List<Patologie> Patologie = await this.PatologieRepository.GetPatologie();
            return Patologie;
        }

        // GET: api/Patologie/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Patologie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Patologie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Patologie/5
        public void Delete(int id)
        {
        }
    }
}
