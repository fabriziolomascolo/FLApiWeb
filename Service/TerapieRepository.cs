using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FLApiWeb.Models;
using System.Data.Entity;

namespace FLApiWeb.Service
{
    public class TerapieRepository : ITerapieRepository
    {
        FLDbContext flDbContext;

        public TerapieRepository(FLDbContext flDbContext)
        {
            this.flDbContext =  flDbContext;
        }

        public  async Task<List<Terapie>> GetTerapie()
        {
            return await this.flDbContext.Terapie
                .OrderBy(a => a.codTer)
                .ToListAsync();

            //string query = "Select * from dbo.EstraiTerapie(null)";
            //return await this.flDbContext.Database.SqlQuery<TerapiaPatologie>(query).ToListAsync();
            
        }


        public async Task<List<Terapie>> SearchTerapieContainsValue(string value)
        {
            string query = "SELECT * FROM dbo.Terapie " +                           
                           " LEFT OUTER JOIN dbo.TerapiaPatologie ON Terapie.CodTer = TerapiaPatologie.CodTer " +
                           " LEFT OUTER JOIN dbo.Patologie ON Patologie.CodPat = TerapiaPatologie.CodPat " +
                           " WHERE PatologiE.NOME LIKE '%" + value + "%'";

            return await this.flDbContext.Database.SqlQuery<Terapie>(query).ToListAsync();

        }
        //public async Task<List<TerapiaPatologie>> GetTerapiaPatologie()
        //{
        //    return await this.flDbContext.TerapiaPatologie
        //        .OrderBy(a => a.NomeTer)
        //        .ToListAsync();
        //}

        public async Task<List<TerapiaPatologie>> GetTerapiaPatologie()
        {
            return await this.flDbContext.TerapiaPatologie
                .OrderBy(a => a.CodTer)
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