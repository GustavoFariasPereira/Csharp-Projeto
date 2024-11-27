using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pjtBarbeariaClientes
{
    public class Utilitarios
    {
        public void salvarObjeto(object obj)
        {
            String endereco = @"D:\C#\Semestre2\Bfuncionamento.json";
            if (obj is HorarioSemana)
            {
                endereco = @"D:\C#\Semestre2\BhorarioSemana.json";
            }
            
            String json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(endereco, json);
        }

        public void salvarLista<T>(List<T> lista)
        {
            String enderecoLista = @"D:\C#\Semestre2\BClientes.json";

            if (lista is List<Produto>)
            {
                enderecoLista = @"D:\C#\Semestre2\BProdutos.json";
            }
            else if (lista is List<Agendamento>)
            {
                enderecoLista = @"D:\C#\Semestre2\BAgendamentos.json";
            }
                
            String json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(enderecoLista, json);
        }

        public static List<T> carregarLista<T>(string enderecoLista)
       {
          if (File.Exists(enderecoLista))
          {
             string jsonString = File.ReadAllText(enderecoLista);
             return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
          }
          return new List<T>();
       }
        
        public static string myHash(string input)
        {
           
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }

                return hashString.ToString();
            }
        }

        public String relatorio<T>(List<T> lista)
        {
            StringBuilder ret = new StringBuilder();

            foreach (T item in lista)
            {
                ret.Append(item.ToString() + Environment.NewLine);
            }

            return ret.ToString();
        }

        public static void fecharAplicativo(Form formAtual)
        {
            formAtual.Close();         
            Application.Exit();        
        }

        public static void abrirNovoForm<T>(Form formAtual) where T : Form, new()
        {
            formAtual.Hide();

            using (var form = new T())
            {
                form.ShowDialog();
            }

            if (!formAtual.IsDisposed)
            {
                formAtual.Show();
            }
        }

        public void limparCampos(Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
            }
        }

        static string TraduzirDiaSemana(DayOfWeek dia)
        {
            return dia switch
            {
                DayOfWeek.Sunday => "Domingo",
                DayOfWeek.Monday => "Segunda-feira",
                DayOfWeek.Tuesday => "Terça-feira",
                DayOfWeek.Wednesday => "Quarta-feira",
                DayOfWeek.Thursday => "Quinta-feira",
                DayOfWeek.Friday => "Sexta-feira",
                DayOfWeek.Saturday => "Sábado",
                _ => throw new ArgumentOutOfRangeException() // Exceção para casos não tratados
            };
        }

    }
}
