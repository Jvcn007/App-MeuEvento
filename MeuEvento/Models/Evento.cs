namespace MeuEvento.Models
{
    public class Evento
    {


        public String Nome { get; set; }
        public String LocalEvento { get; set; }
        public int CustoParticipante { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }
        public int NumParticipantes { get; set; }

        public int QntDias
        {
            get
            {
                TimeSpan Diferença = DtFinal - DtInicial;
                return Diferença.Days;
            }
        }

        public double ValorTotal
        {
            get
            {
                double PreçoTotal = CustoParticipante * NumParticipantes;
                return PreçoTotal;
            }
        }

    }

}
