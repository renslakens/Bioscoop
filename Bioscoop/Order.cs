namespace Bioscoop;

public class Order {
    private int orderNr;
    private bool isStudentOrder;

    public Order(int orderNr, bool isStudentOrder) {
        this.orderNr = orderNr;
        this.isStudentOrder = isStudentOrder;
    }
    
    public int GetOrderNr() {
        return orderNr;
    }
    
    public void addSeatReservation(MovieTicket ticket) {
        
    }

    public double calculatePrice() {
        return 0;
    }

    public void export(TicketExportFormat exportFormat) {
        
    }
}