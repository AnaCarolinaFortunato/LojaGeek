using LojaGeek.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGeek.API.Models.InputModels
{
    public class CreateProdutoInputModel
    {
        
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Img { get; set; }
        public string ImgLarge { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }

    }
}
