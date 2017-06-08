using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppComCodeFirst.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }

        public String Categoria { get; set; }

        public String Descricao { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }

    }

    public class Posts
    {
        [Key]
        public long PostID { get; set; }

        public String TituloPost { get; set; }

        public String ResumoPost { get; set; }

        public String ConteudoPost { get; set; }

        public DateTime DataPostagem { get; set; }

        public int CategoriaID { get; set; }

        [ForeignKey("CategoriaID")]
        public virtual Categorias Categorias { get; set; }

    }

   
}
        