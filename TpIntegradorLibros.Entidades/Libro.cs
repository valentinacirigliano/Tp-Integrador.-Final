using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIntegradorLibros.Entidades
{
    public class Libro:ICloneable 
    {
        public string NombreDelLibro { get; set; }
        public Editorial Editorial { get; set; }
        public Tema Tema { get; set; }
        public int Paginas { get; set; }
        public long ISBN { get; set; }
        public string Autor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Libro))
            {
                return false; 
            }

            return this.NombreDelLibro == ((Libro)obj).NombreDelLibro &&
                   this.Editorial == ((Libro)obj).Editorial &&
                   this.Tema == ((Libro)obj).Tema &&
                   this.Paginas == ((Libro)obj).Paginas &&
                   this.ISBN == ((Libro)obj).ISBN &&
                   this.Autor == ((Libro)obj).Autor;

        }

        public override int GetHashCode()
        {
            return NombreDelLibro.GetHashCode() + Editorial.GetHashCode() + Tema.GetHashCode() +
                   Paginas.GetHashCode() + ISBN.GetHashCode() + Autor.GetHashCode();
        }

    }
}
