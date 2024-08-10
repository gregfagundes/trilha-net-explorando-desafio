using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedesFamilia1 = new List<Pessoa>();
List<Pessoa> hospedesFamilia2 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");
Pessoa p7 = new Pessoa(nome: "Hóspede 7");
Pessoa p8 = new Pessoa(nome: "Hóspede 8");


hospedesFamilia1.Add(p1);
hospedesFamilia1.Add(p2);
hospedesFamilia1.Add(p3);
hospedesFamilia1.Add(p4);
hospedesFamilia1.Add(p5);

hospedesFamilia2.Add(p6);
hospedesFamilia2.Add(p7);
hospedesFamilia2.Add(p8);

// Cria a suíte
Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 100);
Suite suiteBasica = new Suite(tipoSuite: "Basica", capacidade: 2, valorDiaria: 50);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 10);
reserva1.CadastrarSuite(suitePremium);
reserva1.CadastrarHospedes(hospedesFamilia1);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva1.CalcularValorDiaria()}");

// Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva2 = new Reserva(diasReservados: 5);
// reserva2.CadastrarSuite(suiteBasica);
// reserva2.CadastrarHospedes(hospedesFamilia2);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");
