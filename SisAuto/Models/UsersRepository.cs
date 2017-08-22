using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using static System.Collections.Specialized.BitVector32;

namespace SisAuto.Models
{
    public class UsersRepository
    {
        private readonly SisAutoDb context;
        public UsersRepository()
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
        public static USUARIOS autenticaUser(USUARIOS user)
        {
            SisAutoDb context = new SisAutoDb();
            var consulta = (from u in context.USUARIOS
                            where u.LOGINUSU == user.LOGINUSU
                            && u.SENHAUSU == user.SENHAUSU
                            select u).SingleOrDefault();
            if (consulta == null) return null;

            FormsAuthentication.SetAuthCookie(consulta.LOGINUSU, false);
            return consulta;
        }
        public static USUARIOS GetUserLogado(USUARIOS usuario)
        {
            if (usuario == null) return null;

            else
            {
                SisAutoDb context = new SisAutoDb();
                USUARIOS user =(from u in context.USUARIOS
                               where u.LOGINUSU == usuario.LOGINUSU
                               select u).FirstOrDefault();
                return user;
            }
        }
        public static void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}