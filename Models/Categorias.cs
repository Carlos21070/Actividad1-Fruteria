using System;
using System.Collections.Generic;

namespace Actividad1_FruitStore.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public ulong Eliminado { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
