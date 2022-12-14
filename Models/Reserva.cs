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
            // Implantado!!
            if (hospedes.Count >= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implantado!!
                Console.WriteLine("Número de hospedes é maior que a capacidade!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implantado!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implantado!!
            int numeroHospedes = Hospedes.Count;
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Implantado!!
            if (DiasReservados >= 10)
            {
                valor -= Decimal.Divide(Decimal.Multiply(valor, 10), 100);
            }

            return valor;
        }
    }
}