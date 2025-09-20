using Sistema_de_Hospedagem.Models;

Suite suiteA = new()
{
  Capacidade = 2,
  TipoSuite = "Presidencial",
  ValorDiaria = 1385.97M
};

Suite suiteB = new()
{
  Capacidade = 1,
  TipoSuite = "Exclusiva Premium Individual",
  ValorDiaria = 2499.99M
};

Pessoa hospede1 = new()
{
  Nome = "José Santiago"
};

Pessoa hospede2 = new()
{
  Nome = "Talita Rachel"
};

Reserva reserva1 = new();

reserva1.CadastrarSuite(suiteA);

reserva1.CadastrarHospedes([hospede1, hospede2]);

reserva1.DiasReservados = 15;

Console.WriteLine(reserva1.ObterQuantidadeHospedes());

Console.WriteLine(reserva1.CalcularValorDiaria().ToString("C"));