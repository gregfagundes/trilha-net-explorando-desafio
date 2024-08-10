namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool permiteCapacidadeDeHospedes = hospedes.Count <= Suite.Capacidade;
            if (permiteCapacidadeDeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de hóspedes excede a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;
            bool possuiDesconto = DiasReservados >= 10;

            if (possuiDesconto)
            {
                valor *= 0.9m;
            }

            return valor;
        }
    }
}