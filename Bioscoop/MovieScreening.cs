namespace Bioscoop;

public class MovieScreening {
    private LocalDateTime dateAndTime;
    private double pricePerSeat;
    private Movie movie;
    private MovieTicket[] tickets;

    public void MovieScreening(Movie movie, LocalDateTime dateAndTime, double pricePerSeat) {
        this.movie = movie;
        this.dateAndTime = dateAndTime;
        this.pricePerSeat = pricePerSeat;
    }

    public double getPricePerSeat() {
        return this.pricePerSeat;
    }

    public override string ToString() {
        return this.movie + " " + this.dateAndTime + " " + this.pricePerSeat;
    }
}