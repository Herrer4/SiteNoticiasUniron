using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ConteudoViewModel
    {
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Data do Cadastro")]
        public DateTime DataDoCadastro { get; set; }
        public string Texto { get; set; }
        [DisplayName("Link da imagem")]
        public string LinkImagem { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }     
        [DisplayName("Nome do autor")]
        public string NomeAutor { get; set; }
        public string Linkedin { get; set; }
        
    }
    
}
