using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisAuto.Models
{
    public class CidadeEstadoRepository
    {
        private SisAutoDb context;
        public CidadeEstadoRepository()
        {
            this.context = new SisAutoDb();
        }
        //lista todos os estados 
        public List<ESTADO> getAllStates()
        {
            var consulta = from e in context.ESTADO
                           select e;
            return consulta.ToList();
        }
        //lista todas as cidades mediante ao id do estado
        public List<CIDADE> getCitiesIdState(int Id)
        {
            var consulta = from c in context.CIDADE
                           where c.CIDADEID == Id
                           select c;

            return consulta.ToList();
        }
    }
}