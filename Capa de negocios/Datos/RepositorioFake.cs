﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_negocios.Entidades;

namespace Capa_de_negocios.Datos
{
    class RepositorioFake
    {
        static private List<Usuario> usuarios;
        static private List<Tarea> tareas;

        //public RepositorioFake()
        //{
        //  usuarios=new List<Usuario>();
        //}

        public static void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static Usuario BuscarUsuario(String codigo)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.getCodigo().Equals(codigo))
                {
                    return usuario;
                }
            }
            return null;
        }

        public static Boolean consultarUsuario(String correo, String contraseña)
        {
            foreach (Usuario usuario in usuarios)
            {
                if ((usuario.getContraseña().Equals(contraseña)) && (usuario.getCorreoElectronico().Equals(correo)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}