using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public class categoriasDAO
    {
          /// <summary>
            /// Retorna um DataTable com todas as cidades por ordem alfabética
            /// </summary>
            /// <returns>DataTable com todas as cidades por ordem alfabética</returns>
            public static DataTable ListaCategorias()
            {
                string sql = "select * from categorias order by descricao";
                DataTable tabela = Metodos.ExecutaSelect(sql, null);
                return tabela;
            }
        }

    }

