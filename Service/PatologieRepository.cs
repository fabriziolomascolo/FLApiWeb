using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FLApiWeb.Models;
using System.Data.Entity;

namespace FLApiWeb.Service
{
    public class PatologieRepository : IPatologieRepository
    {
        FLDbContext flDbContext;

        public PatologieRepository(FLDbContext flDbContext)
        {
            this.flDbContext =  flDbContext;
        }

        public async Task<List<Patologie>> GetPatologie()
        {
            return await this.flDbContext.Patologie                
                .OrderBy(a => a.Nome)
                .ToListAsync();
        }
        public async Task<List<PatologiaTerapie>> GetPatologiaTerapie()
        {
            return await this.flDbContext.PatologiaTerapie
                .OrderBy(a => a.CodPat)
                .ToListAsync();
        }

        public async Task<List<Patologie>> SearchTerapieContainsValue(string value)
        {
            return await this.flDbContext.Patologie
                .Where(a => a.Descrizione.Contains(value))
                .OrderBy(a => a.Nome)
                .ToListAsync();

        }

        //public async Task<Terapie> SelCliByCode(string Code)
        //{
        //    return await this.gestFidDbContext.Terapie                
        //        .Where(a => a.CodPre.Equals(Code))
        //        .FirstOrDefaultAsync();
        //}

        //public Terapie SelCliByCode2(string Code)
        //{
        //    return this.gestFidDbContext.Terapie
        //        .AsNoTracking()
        //        .Where(a => a.CodPre.Equals(Code))
        //        .FirstOrDefault();
        //}

        //public async Task<ICollection<Terapie>> SelCliByName(string Nome)
        //{
        //    return await this.gestFidDbContext.Terapie                
        //        .Where(a => a.Nome.Contains(Nome))
        //        .OrderBy(a => a.Nome)
        //        .ToListAsync();
        //}

        //public bool InsTerapia(Terapie terapia)
        //{
        //    this.gestFidDbContext.Add(terapia);
        //    return Salva();
        //}

        //public bool UpdTerapia(Terapie terapia)
        //{
        //    this.gestFidDbContext.Update(terapia);
        //    return Salva();
        //}

        //public bool TerapiaExists(string Code)
        //{
        //    return this.gestFidDbContext.Terapie
        //        .Any(c => c.CodPre == Code);
        //}

        //public bool DelTerapia(Terapie terapia)
        //{
        //    this.gestFidDbContext.Remove(terapia);
        //    return Salva();
        //}

        //private bool Salva()
        //{
        //    try
        //    {
        //        var saved = this.gestFidDbContext.SaveChanges();
        //        return saved >= 0 ? true : false; 
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Errore: {ex.Message}");
        //        return false;
        //    }
        //}
    }
}