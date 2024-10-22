using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pjtBarbeariaClientes
{
    public class Utilitarios
    {
        public static List<Pessoa> loadUsuario(string arquivo)
        {
            try
            {
                if (!File.Exists(arquivo)) return null;
                string json = File.ReadAllText(arquivo);
                if (string.IsNullOrWhiteSpace(json)) return null;

                List<Pessoa> lista = JsonSerializer.Deserialize<List<Pessoa>>(json);
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void saveUsuario(List<Pessoa> lista, string arquivo)
        {
            if (lista.Count == 0) return;
            try
            {
                string json = JsonSerializer.Serialize(lista);
                File.WriteAllText(arquivo, json);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
