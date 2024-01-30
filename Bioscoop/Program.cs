using Bioscoop;

Movie movie = new Movie("The Matrix");
MovieScreening screening = new MovieScreening(movie, DateTime.Now, 10.0);
MovieTicket ticket = new MovieTicket(screening, 1, 1, false);
MovieTicket ticket2 = new MovieTicket(screening, 2, 2, false);
MovieTicket ticket3 = new MovieTicket(screening, 3, 3, false);
Order order = new Order(1, true);
order.addSeatReservation(ticket);
order.addSeatReservation(ticket2);
order.addSeatReservation(ticket3);

Console.WriteLine($"Orderprice: {order.calculatePrice()}");