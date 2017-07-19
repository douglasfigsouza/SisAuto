using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisAuto.Models
{
    public class CidadeEstadoRepository
    {
        private SisAutoDb context;
        List<CIDADE> lstCities;
        public CidadeEstadoRepository()
        {
            this.context = new SisAutoDb();
            this.lstCities = new List<CIDADE>();
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
                           where c.ESTADOID == Id
                           select new {
                              CIDADEID=c.CIDADEID,
                              ESTADOID=c.ESTADOID,
                              NOME= c.NOME
                           };

            foreach (var city in consulta)
            {
                lstCities.Add(new CIDADE {
                    ESTADOID=city.ESTADOID,
                    CIDADEID=city.CIDADEID,
                    NOME=city.NOME
                });
            }
            return lstCities.ToList();
        }
    }
}