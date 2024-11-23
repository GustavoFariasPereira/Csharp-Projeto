using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pjtBarbeariaClientes
{
    public class Barbearia
    {
        public String diaFuncionamento {  get; private set; }
        public String horaFuncionamento { get; private set; }
        public char horaLivre { get; private set; }

        public Barbearia(string diaFuncionamento, string horaFuncionamento, char horaLivre)
        {
            this.diaFuncionamento = diaFuncionamento;
            this.horaFuncionamento = horaFuncionamento;
            this.horaLivre = horaLivre;
        }
    }

    public class Agendamento : IComparable<Agendamento>
    {
        public Cliente cliente {  get; private set; }
        public DateTime dataAgendamento { get; private set; }
        public TimeSpan horaAgendamento { get; private set; }
        public List<Produto> produtos { get; private set; }

        [JsonConstructor]
        public Agendamento(Cliente cliente, DateTime dataAgendamento, TimeSpan horaAgendamento,
            List<Produto> produtos)
        {
            this.cliente = cliente;
            this.dataAgendamento = dataAgendamento;
            this.horaAgendamento = horaAgendamento;
            this.produtos = produtos;
        }

        public int CompareTo(Agendamento? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = cliente.login.CompareTo(outro.cliente.login);
            }
            return pos;
        }
    }

    public class Cliente : Pessoa, IComparable<Cliente>
    {
        public String login { get; private set; }
        public String hashSenha { get; private set; }
        public List<ClienteMenorIdade> filhos { get; private set; }

        [JsonConstructor]
        public Cliente(String login, String hashSenha, String nome,
            DateTime dataNascimento, String telefone) :
            base(nome, dataNascimento, telefone)
        {
            this.login = login;
            this.hashSenha = hashSenha;
            filhos = new List<ClienteMenorIdade>();
        }

        public Cliente(String login) : base("", DateTime.Now, "")
        {
            this.login = login;
            hashSenha = "";
        }

        public override String ToString()
        {

            return String.Format("Nome: {0}, Login: {1}, Aniversário: {2}, Contato: {3:(##) #####-####}, E-mail: {4}, Filhos: {5}.{6}", nome, login, dataNascimento.ToString("dd/MM/yyyy"), Convert.ToInt64(telefone), email, filhos, Environment.NewLine);

        }

        public int CompareTo(Cliente? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = login.CompareTo(outro.login);
            }
            return pos;
        }
    }

    public class ClienteMenorIdade : IComparable<ClienteMenorIdade>
    {
        public String nome { get; private set; }
        public DateTime aniversario { get; private set; }
        public Cliente responsavel { get; private set; }

        [JsonConstructor]
        public ClienteMenorIdade(String nome, DateTime aniversario, Cliente responsavel)
        {
            this.nome = nome;
            this.aniversario = aniversario;
            this.responsavel = responsavel;
        }

        public int CompareTo(ClienteMenorIdade? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = nome.CompareTo(outro.nome);
            }
            return pos;
        }
    }

    public class Produto : IComparable<Produto>
    {
        private static int ultimoId = 0;

        public String nome { get; private set; }
        public String valor { get; private set; }
        public int id { get; private set; }

        [JsonConstructor]
        public Produto(string nome, string valor)
        {
            this.nome = nome;
            this.valor = valor;
            id = GerarId();
        }

        public float totalPagar(float valor, int quantidade)
        {
            return valor * quantidade;
        }

        private static int GerarId()
        {
            return ++ultimoId; // Incrementa e retorna o próximo ID.
        }
        public override String ToString()
        {

            return String.Format("Nome: {0}, Valor: R${1:###.00}, Id: {2}.{4}", nome, valor, id, Environment.NewLine);

        }

        public int CompareTo(Produto? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = nome.CompareTo(outro.nome);
            }
            return pos;
        }
    }

    public abstract class Pessoa
    {
        public String nome { get; private set; }
        public DateTime dataNascimento { get; private set; }
        public String telefone { get; private set; }
        public String email { get; set; }

        public Pessoa(String nome, DateTime dataNascimento, String telefone)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            email = "";
        }
    }
}
