using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Nome", sobrenome: "Sobrenome");
Pessoa p2 = new Pessoa(nome: "Nome", sobrenome: "Sobrenome");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
foreach (Pessoa hospede in hospedes)
{
    Console.WriteLine($"Hóspede: {hospede.Nome} {hospede.Sobrenome}");
}

Console.WriteLine($"Quantidade de dias: {reserva.DiasReservados}");
Console.WriteLine($"Valor da diária: {suite.ValorDiaria.ToString("C")}");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");