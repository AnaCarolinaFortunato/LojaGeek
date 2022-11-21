using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGeek.API.Core.Entities
{
    public class Produto
    {
        public Produto(Guid id, string nome, double valor, string img, string imgLarge, Categoria categoria, string descricao)
        {
            this.id = id;
            Nome = nome;
            Valor = valor;
            Img = img;
            ImgLarge = imgLarge;
            Categoria = categoria;
            Descricao = descricao;
        }

        public Guid id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Img { get; set; }
        public string ImgLarge { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
    }
}
