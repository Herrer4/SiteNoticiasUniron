using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClassificadoViewModel
    {
        [DisplayName("Título")]
        public string Nome { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
    }
}
