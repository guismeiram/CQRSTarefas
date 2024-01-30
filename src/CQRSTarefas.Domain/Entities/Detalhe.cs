using CQRSTarefas.Domain.Common.Models;

namespace CQRSTarefas.Domain.Entities
{
    public class Detalhe : Entity
    {
        public DateTime TempoMinimo { get; set; }//tempo minimo para fazer a atividade
        public DateTime DataHorarioMarcado { get; set; }//Data e horario previsto para começar
        public string Observacoes { get; set; } // Observações da atividade
        
    }
}