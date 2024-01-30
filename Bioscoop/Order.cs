namespace Bioscoop;

public class Order {
    private int orderNr;
    private bool isStudentOrder;
    private List<MovieTicket> tickets = new List<MovieTicket>();

    public Order(int orderNr, bool isStudentOrder) {
        this.orderNr = orderNr;
        this.isStudentOrder = isStudentOrder;
    }
    
    public int GetOrderNr() {
        return orderNr;
    }
    
    public void addSeatReservation(MovieTicket ticket) {
        this.tickets.Add(ticket);
    }

    public double calculatePrice() {
        double totalPrice = 0;
        
        // Loop over de tickets en sla elke 2e ticket over voor studenten
        for (int i = 0; i < tickets.Count; i++) {
            double ticketPrice = tickets[i].getPrice();

            // Add premium price for student and non-student orders
            if (tickets[i].isPremiumTicket()) {
                ticketPrice += isStudentOrder ? 2 : 3;
            }

            // Check if it's a student order or a weekday for non-student orders
            if (isStudentOrder) {
                // Every second ticket is free
                if (i % 2 == 0) {
                    totalPrice += ticketPrice;
                }
            } else {
                totalPrice += ticketPrice;
            }
        }
        
        return totalPrice;
    }

    public void export(TicketExportFormat exportFormat) {
        
    }
}