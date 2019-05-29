using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string Existencia { get; set; }
        public string Costo { get; set; }
        public string ValorInventario { get; set; }

        public Productos()
        {
            this.ProductoId = 0;
            this.Descripcion = string.Empty;
            this.Existencia = string.Empty;
            this.Costo = string.Empty;
            this.ValorInventario = string.Empty;
        }
    }

}
