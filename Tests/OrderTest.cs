using Bioscoop;
using Xunit;


namespace Tests;

public class OrderTest {
    [Fact]
    public void TestThreeTickets() {
        Movie movie = new Movie("The Matrix");
        // set friday 1st of january 2022 10:00
        DateTime dateTime = new DateTime(2022, 1, 1, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, false);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, false);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, false);
        Order order = new Order(1, false);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(30, price);
    }

    [Fact]
    public void TestThreePremiumTickets() {
        Movie movie = new Movie("The Matrix");
        DateTime dateTime = new DateTime(2022, 1, 1, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, true);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, true);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, true);
        Order order = new Order(1, false);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(39, price);
    }

    [Fact]
    public void TestThreeStudentTickets() {
        Movie movie = new Movie("The Matrix");
        DateTime dateTime = new DateTime(2022, 1, 1, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, false);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, false);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, false);
        Order order = new Order(1, true);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(20, price);
    }

    [Fact]
    public void TestThreeStudentPremiumTickets() {
        Movie movie = new Movie("The Matrix");
        DateTime dateTime = new DateTime(2022, 1, 1, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, true);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, true);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, true);
        Order order = new Order(1, true);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(24, price);
    }

    [Fact]
    public void TestSixTickets() {
        Movie movie = new Movie("The Matrix");
        DateTime dateTime = new DateTime(2022, 1, 1, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, false);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, false);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, false);
        MovieTicket ticket4 = new MovieTicket(screening, 4, 4, false);
        MovieTicket ticket5 = new MovieTicket(screening, 5, 5, false);
        MovieTicket ticket6 = new MovieTicket(screening, 6, 6, false);
        Order order = new Order(1, false);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);
        order.addSeatReservation(ticket4);
        order.addSeatReservation(ticket5);
        order.addSeatReservation(ticket6);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(60, price);
    }

    [Fact]
    public void TestTuesdayDiscount() {
        Movie movie = new Movie("The Matrix");
        // Tuesday
        DateTime dateTime = new DateTime(2022, 1, 4, 10, 0, 0);
        MovieScreening screening = new MovieScreening(movie, dateTime, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, false);
        MovieTicket ticket2 = new MovieTicket(screening, 2, 2, false);
        MovieTicket ticket3 = new MovieTicket(screening, 3, 3, false);
        Order order = new Order(1, true);
        order.addSeatReservation(ticket);
        order.addSeatReservation(ticket2);
        order.addSeatReservation(ticket3);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);

        var price = order.calculatePrice();

        // Assert
        Assert.Equal(20, price);
    }
}