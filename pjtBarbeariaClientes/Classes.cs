﻿using Microsoft.VisualBasic.Logging;
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
    public class HorarioSemana
    {
        public Funcionamento segunda { get; private set; }
        public Funcionamento terca { get; private set; }
        public Funcionamento quarta { get; private set; }
        public Funcionamento quinta { get; private set; }
        public Funcionamento sexta { get; private set; }
        public Funcionamento sabado { get; private set; }
        public Funcionamento domingo { get; private set; }

        [JsonConstructor]
        public HorarioSemana(Funcionamento segunda, Funcionamento terca, Funcionamento quarta,
            Funcionamento quinta, Funcionamento sexta, Funcionamento sabado, Funcionamento domingo)
        {
            this.segunda = segunda;
            this.terca = terca;
            this.quarta = quarta;
            this.quinta = quinta;
            this.sexta = sexta;
            this.sabado = sabado;
            this.domingo = domingo;
        }
    }

    public class Funcionamento : IComparable<Funcionamento>
    {
        public DateTime dia {  get; private set; }
        public TimeSpan abertura { get; private set; }
        public TimeSpan pausa { get; private set; }
        public TimeSpan fechamento { get; private set; }

        [JsonConstructor]
        public Funcionamento(DateTime dia, TimeSpan abertura, TimeSpan pausa, TimeSpan fechamento)
        {
            this.dia = dia;
            this.abertura = abertura;
            this.pausa = pausa;
            this.fechamento = fechamento;
        }

        public int CompareTo(Funcionamento? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = dia.CompareTo(outro.dia);
            }
            return pos;
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
                pos = horaAgendamento.CompareTo(outro.horaAgendamento);
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
        public float valor { get; private set; }
        public int id { get; private set; }

        [JsonConstructor]
        public Produto(string nome, float valor)
        {
            this.nome = nome;
            this.valor = valor;
            id = gerarId();
        }
        public Produto(int id)
        {
            nome = "";
            valor = 0;
            this.id = id;
        }

        public float totalPagar(float valor, int quantidade)
        {
            return valor * quantidade;
        }

        private static int gerarId()
        {
            return ++ultimoId; // Incrementa e retorna o próximo ID.
        }
        public override String ToString()
        {

            return String.Format("Nome: {0}, Valor: R${1:###.00}, Id: {2}.{3}", nome, valor, id, Environment.NewLine);

        }

        public int CompareTo(Produto? outro)
        {
            int pos;
            if (outro == null) pos = -1;
            else
            {
                pos = id.CompareTo(outro.id);
            }
            return pos;
        }

        public int compareNome(List<Produto> lista)
        {
            // Verifica se a lista é nula ou vazia
            if (lista == null || lista.Count == 0)
                return -1;

            // Procura um produto com o mesmo nome na lista (ignorando maiúsculas e minúsculas)
            bool exists = lista.Any(p =>
                p.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            // Retorna -1 se não encontrar, 0 se encontrar
            return exists ? 0 : -1;
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
