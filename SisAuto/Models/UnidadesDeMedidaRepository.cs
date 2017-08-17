using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisAuto.Models
{
    public class UnidadesDeMedidaRepository
    {
        private readonly SisAutoDb context;
        public UnidadesDeMedidaRepository()
        {
            this.context = new SisAutoDb();
        }
        public void AddUnidMedida(UNIDMEDIDA unid)
        {
            unid.ATIVO = true;
            try
            {
                context.UNIDMEDIDA.Add(unid);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<UNIDMEDIDA> GetAllUnidMedidas()
        {
            return context.UNIDMEDIDA.AsEnumerable().ToList();
        }
    }
}