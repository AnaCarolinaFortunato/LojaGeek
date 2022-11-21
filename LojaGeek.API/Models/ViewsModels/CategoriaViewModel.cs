using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGeek.API.Models.ViewsModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
