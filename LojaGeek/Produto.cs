using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGeek
{
    public class Produto
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Img { get;set; }
        public string ImgLarge { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }

        public static void Adicionar(string nome, double valor, string img, string imgLarge, Categoria categoria, string descricao)
        {

            
            string Nome = nome;
            double Valor = valor;
            string Img = img;
            string ImgLarge = imgLarge;
            //Produto.Categoria = categoria;
            String Descricao = descricao;


        }

        public static void Remover(string nome, double valor, string img, string imgLarge, Categoria categoria, string descricao)
        {
            string Nome = nome;
            double Valor = valor;
            string Img = img;
            string ImgLarge = imgLarge;
            //Categoria = categoria;
            String Descricao = descricao;

        }

        public static void Editar()
        {

        }





    }

    


}
