using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcial1.BLL;
using ProyectoParcial1.DAL;
using ProyectoParcial1.Entidades;

namespace ProyectoParcial1.BLL
{
  public class ProductosBLL
    {
        public static bool Guardar(Productos productos)
        {
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                context.Productos.Add(productos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = contexto.Productos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return productos;
        }

       
    }
    }
