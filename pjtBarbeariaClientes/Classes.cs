using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtBarbeariaClientes
{
    public class Cliente : Pessoa
    {
        public String login { get; private set; }
        private String hashSenha { get; set; }
        public String filhosMenorIdade { get; private set; }

        public Cliente(String login, String hashSenha, String nome,
            DateTime dataNascimento, String telefone) :
            base(nome, dataNascimento, telefone)
        {
            this.login = login;
            this.hashSenha = hashSenha.GetHashCode().ToString();
            this.filhosMenorIdade = "";
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
    [Serializable]
    public class Pessoa
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

        public override String ToString()
        {

            return nome + ", " + dataNascimento.ToString("dd/MM/yyyy") + ", " + telefone + ", " + email;

        }


    }
}
