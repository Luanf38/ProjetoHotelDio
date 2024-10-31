using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHotelDio.Models.Suite
{
    internal class SuiteModel(string tipoSuite, int capacidade, decimal diaria)
    {
        public  string tipoSuite = tipoSuite;
        public  int capacidade = capacidade;
        public  decimal diaria = diaria;
    }
}
