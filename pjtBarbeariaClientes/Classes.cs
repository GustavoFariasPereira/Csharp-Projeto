using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pjtBarbeariaClientes
{
    [Serializable]
    public class Cliente : Pessoa, IComparable<Cliente>
    {
        public String login { get; private set; }
        public String hashSenha { get; private set; }
       // public String filhosMenorIdade { get; private set; }

        public Cliente(String login, String hashSenha, String nome,
            DateTime dataNascimento, String telefone) :
            base(nome, dataNascimento, telefone)
        {
            this.login = login;
            this.hashSenha = Utilitarios.myHash(hashSenha, "").ToString();
           // this.filhosMenorIdade = "";
        }

        public Cliente(String login) : base("", DateTime.Now, "")
        {
            this.login= login;
            hashSenha = "";
        }

        public override String ToString()
        {

            return String.Format("Nome: {0}, Aniversário: {1}, Contato: {2}, E-mail: {3}", nome, dataNascimento.ToString("dd/MM/yyyy"), telefone, email);

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
    public class Agendamento
    {
        public DateTime dataAgendamento { get; private set; }
        public TimeSpan horaAgendamento { get; private set; }

        public String descricaoServico { get; private set; }

        public Agendamento(DateTime dataAgendamento, TimeSpan horaAgendamento,
            String descricaoServico)
        {
            this.dataAgendamento = dataAgendamento;
            this.horaAgendamento = horaAgendamento;
            this.descricaoServico = descricaoServico;
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
            this.email = "";
        }
    }
}
