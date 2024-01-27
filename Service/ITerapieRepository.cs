using System.Collections.Generic;
using System.Threading.Tasks;
using FLApiWeb.Models;

namespace FLApiWeb.Service
{
    public interface ITerapieRepository
    {
        Task<List<Terapie>> GetTerapie();
        Task<List<Terapie>> SearchTerapieContainsValue(string value);
        Task<List<TerapiaPatologie>> GetTerapiaPatologie();
        //Task<ICollection<Terapie>> SelCliByName(string Nome);
        //Task<Terapie> SelCliByCode(string Code);
        //Terapie SelCliByCode2(string Code);
        //bool InsTerapia(Terapie terapia);
        //bool UpdTerapia(Terapie terapia);
        //bool DelTerapia(Terapie terapia);
        //bool TerapiaExists(string Code);        
    }
}