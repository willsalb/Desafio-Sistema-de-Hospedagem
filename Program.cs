using System.Text;
using Desafio_Hospedagem.models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tipoSuite: "Premiun", capacidade: 2, valorDiaria: 50);


Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);  
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");

