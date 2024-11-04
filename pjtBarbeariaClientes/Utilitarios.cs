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
        public String enderecoLista = @"D:\C#\Semestre2\BClientes.json";

        public void salvarCliente(List<Cliente> clientes)
        {
            String jsonCliente = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(enderecoLista, jsonCliente);
        }

        public List<Cliente> carregarCliente()
        {
            if (File.Exists(enderecoLista))
            {
                String jsonString = File.ReadAllText(enderecoLista);
                return JsonSerializer.Deserialize<List<Cliente>>(jsonString);
            }
            return new List<Cliente>();
        }

        public static Int64 myHash(string str, string salt)
        {
            if (str == String.Empty)
            {
                return 0;
            }

            try
            {
                Int64 hash = 0;

                Int32[] chave = {
                            0x4adfae,
                            0x3bcd13,
                            0x4afe56,
                            0x1fda56,
                            0x653219,
                            0x765754,
                            0x124678,
                            0x014321,
                            0x58fba0,
                            0xfad5fa,
                            0x234987,
                            0xdfa5bc,
                            0xabcdef,
                            0xfedcab,
                            0x1234ab,
                            0xab1234,
                            0x112233,
                            0x445566,
                            0xaabbcc,
                            0xddeeff,
                          };

                char[] bytes = String.Concat(str.Trim(), salt.Trim()).Trim().ToArray();

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash += bytes[i] * (chave[i % 20] + chave[bytes[i] % 20]);
                }

                return hash % 0xffffffff;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
