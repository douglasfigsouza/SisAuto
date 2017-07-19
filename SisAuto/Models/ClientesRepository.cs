using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisAuto.Models
{
    public class ClientesRepository
    {
        private SisAutoDb context;
        public ClientesRepository()
        {
            this.context = new SisAutoDb();
        }
        public bool addClient(CLIENTES cliente)
        {
            context.CLIENTES.Add(cliente);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}