using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Desafio_Hospedagem.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set;}
        public Suite Suite { get; set;}
        public int DiasReservados {get; set;}

        public Reserva() { }

        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            if(Suite?.Capacidade >= hospedes.Count) {
                Hospedes = hospedes;
            } else {
                throw new Exception("Não existe mais vagas para essa suite");
            }
        }

        public void CadastrarSuite(Suite suite) {
            Suite = suite;
        }

        public int ObterQuantHospedes() {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria() {
            decimal quantidadeDias = DiasReservados;
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valorFinal = Convert.ToDecimal(quantidadeDias) * valorDiaria;
            decimal valor = Convert.ToDecimal(valorFinal);

            if(DiasReservados >= 10) {
                double desconto = 0.10 * Convert.ToDouble(valor);
                valor = valor - Convert.ToDecimal(desconto);
            }

            return valor;
        }

    }
}