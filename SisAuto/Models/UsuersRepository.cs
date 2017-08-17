using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SisAuto.Models
{
    public class UsuersRepository
    {
        private readonly SisAutoDb context;
        public UsuersRepository()
        {
            this.context = new SisAutoDb();
        }
        public void AddUsers(USUARIOS user)
        {
            user.ATIVO = true;
            try
            {
                context.USUARIOS.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool autenticaUser(USUARIOS user)
        {
            SisAutoDb context = new SisAutoDb();
            var consulta = (from u in context.USUARIOS
                            where u.LOGINUSU == user.LOGINUSU
                            && u.SENHAUSU == user.SENHAUSU
                            select u).SingleOrDefault();
            if (consulta == null) return false;

            FormsAuthentication.SetAuthCookie(consulta.LOGINUSU, false);
            return true;
        }
        public static USUARIOS GetUserLogado()
        {
            string Login = HttpContext.Current.User.Identity.Name;

            if (Login == null) return null;

            else
            {
                SisAutoDb context = new SisAutoDb();
                USUARIOS user = (from u in context.USUARIOS
                               where u.LOGINUSU == Login
                               select u).SingleOrDefault();
                return user;
            }
        }
        public static void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}