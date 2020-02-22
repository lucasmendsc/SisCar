using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class PerfilBLL
    {
        public void SalvarCor(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildall = new PerfilDAL();

            perfildall.SalvarCor(perfil);

        }

        public void SalvarImagem(Perfil perfil)
        {

            perfil.Login = Login.User;
            PerfilDAL perfildall = new PerfilDAL();

            perfildall.SalvarImagem(perfil); 

        }

        public String VerificarCoreFundo(Perfil perfil)
        {
            PerfilDAL perfilDal = new PerfilDAL();
            perfil.Login = Login.User;
            return perfilDal.VerificarCoreFundo(perfil);
        }

        public String RetornarCoreFundo(Perfil perfil)
        {
            PerfilDAL perfilDal = new PerfilDAL();
            perfil.Login = Login.User;
            return perfilDal.RetornarCoreFundo(perfil);
        }
    }
}
