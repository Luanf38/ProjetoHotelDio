using SistemaDeHotelDio.Models.Pessoa;
using SistemaDeHotelDio.Models.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHotelDio.Models.Reserva
{
    internal class ReservaModel
    {
        public ReservaModel(List<PessoaModel> hospedes, SuiteModel suite, int diasReservados) 
        { 
            this.hospedes = hospedes;
            this.suite = suite;  
            this.diasReservados = diasReservados;
        }
        private List<PessoaModel> hospedes;
        private SuiteModel suite;
        private int diasReservados;
        public List<PessoaModel> Hospedes
        {
            get
            {
                return this.hospedes;
            }

            set
            {
                if (this.hospedes.Count <= this.suite.capacidade)
                {
                    hospedes.Clear();
                    foreach (PessoaModel hospede in this.hospedes)
                    {
                        this.Hospedes.Add(hospede);
                    }
                } else
                {
                    Console.WriteLine("Número de hospedes maior do que o numero de vagas na suíte");
                }
            }
        }
        public  SuiteModel Suite { get { return suite; } }
        public int DiasReservados { get { return this.diasReservados; }}

        public void CadastrarHospedes(List<PessoaModel> hospedes) 
        {
            if (hospedes.Count <= Suite.capacidade) 
            {
                foreach (PessoaModel pessoaModel in hospedes) 
                {
                    Hospedes.Add(pessoaModel);
                }
            }
        }

        public void CadastrarSuite(SuiteModel suite) 
        {
            this.suite = suite;
        }

        public int ObterQuantidadeDeHospedes ()
        {
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return this.diasReservados * this.suite.diaria;
        }
    }
}
