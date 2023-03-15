
namespace Lab2.Models.Domain
{
    public class Ticket
    {
        public DateTime CreatedTime { get; set; }
        public bool IsClosed { get; set; }
        public Severity Severity { get; set; }

        public string Description { get; set; } = string.Empty;

            
        public Ticket() {
            CreatedTime = DateTime.Now;
        }
        public Ticket (
            bool isClosed,
            Severity severity,
            string description) 
        { 

            IsClosed= isClosed;
            Severity= severity;
            Description= description;
        }

        private static readonly  List<Ticket> _tickets = new() {};

        public static List<Ticket> GetTickets() => _tickets;


    }
}
