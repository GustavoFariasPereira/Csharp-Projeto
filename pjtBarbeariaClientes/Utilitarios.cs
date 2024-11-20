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

        public void fecharForm()
        {
            Application.Exit();
        }

        public static void trocarForm(Form form)
        {
            Form formAtual = Form.ActiveForm;
            formAtual.Hide();
            form.ShowDialog();
            form.Show();
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
    }
}
