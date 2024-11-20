using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pjtBarbeariaClientes
{
    public class Barbearia
    {
        public List<Cliente> clientes { get; private set; }
        public List<Agendamento> agendamentos { get; private set; }
        public List<Produto> produtos { get; private set; }

        public Barbearia(List<Cliente> clientes, List<Agendamento> agendamentos, List<Produto> produtos)
        {
            this.clientes = clientes;
            this.agendamentos = agendamentos;
            this.produtos = produtos;  
        }
    }

    public class Agendamento : IComparable<Agendamento>
    {
        public Cliente cliente {  get; private set; }
        public DateTime dataAgendamento { get; private set; }
        public TimeSpan horaAgendamento { get; private set; }
        public List<Produto> produtos { get; private set; }

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

            return String.Format("Nome: {0}, Aniversário: {1}, Contato: {2:(##) #####-####}, E-mail: {3}.", nome, dataNascimento.ToString("dd/MM/yyyy"), Convert.ToInt64(telefone), email);

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
        public String nome { get; set; }
        public String valor { get; set; }

        public Produto(string nome, string valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public float totalPagar(float valor, int quantidade)
        {
            return valor * quantidade;
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
