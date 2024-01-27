using System.Collections.Generic;
using System.Threading.Tasks;
using FLApiWeb.Models;

namespace FLApiWeb.Service
{
    public interface IPatologieRepository
    {
        Task<List<Patologie>> GetPatologie();
        Task<List<Patologie>> SearchTerapieContainsValue(string value);
        Task<List<PatologiaTerapie>> GetPatologiaTerapie();
        
        //Task<ICollection<Terapie>> SelCliByName(string Nome);
        //Task<Terapie> SelCliByCode(string Code);
        //Terapie SelCliByCode2(string Code);
        //bool InsTerapia(Terapie terapia);
        //bool UpdTerapia(Terapie terapia);
        //bool DelTerapia(Terapie terapia);
        //bool TerapiaExists(string Code);        
    }
}