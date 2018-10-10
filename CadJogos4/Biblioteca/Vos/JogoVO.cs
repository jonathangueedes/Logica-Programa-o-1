using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Vos
{
    public class JogoVO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double valor  { get; set; }
        public DateTime Data { get; set; }
        public int CategoriaId { get; set; }
    }
}
