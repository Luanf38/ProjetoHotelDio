using SistemaDeHotelDio.Models.Pessoa;
using SistemaDeHotelDio.Models.Reserva;
using SistemaDeHotelDio.Models.Suite;

internal class Program
{
    private static void Main(string[] args)
    {
        List<PessoaModel> pessoas = new List<PessoaModel>();

        pessoas.Add(item: new PessoaModel(nome: "Luan", sobrenome: "Lima"));
        pessoas.Add(item: new PessoaModel(nome: "Luana", sobrenome: "Coelho"));

        SuiteModel suite = new SuiteModel(tipoSuite: "Premium", capacidade: 4, diaria: 100.00M);

        ReservaModel reserva = new ReservaModel(hospedes: pessoas, suite: suite, diasReservados: 10);

        Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
        Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
    }
}