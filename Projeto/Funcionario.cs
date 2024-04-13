using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Funcionario
    {

        // Propriedades
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Contacto { get; set; }
        public DateTime DataFimContrato { get; set; }
        public DateTime DataRegistroCriminal { get; set; }
        public int Chefe { get; set; }
        public string Area { get; set; }
        public string Insencao { get; set; }
        public string BonusMensal { get; set; }
        public string Carro { get; set; }
        public string Disponibilidade { get; set; }
        public int ValorHora { get; set; }
        public string Horario { get; set; }

        // Construtor
        public Funcionario(int id, string nome, string morada, string contacto, DateTime dataFimContrato, DateTime dataRegistroCriminal, int chefe, string area, string insencao, string bonusMensal, string carro, string disponibilidade, int valorHora, string horario)
        {
            ID = id;
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            DataFimContrato = dataFimContrato;
            DataRegistroCriminal = dataRegistroCriminal;
            Chefe = chefe;
            Area = area;
            Insencao = insencao;
            BonusMensal = bonusMensal;
            Carro = carro;
            Disponibilidade = disponibilidade;
            ValorHora = valorHora;
            Horario = horario;
        }
        public Funcionario()
        {

        }
    }
}