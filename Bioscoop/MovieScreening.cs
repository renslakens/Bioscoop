namespace Bioscoop;

public class MovieScreening {
    private DateTime dateAndTime { get; }
    private double pricePerSeat;
    private Movie movie;
    private List<MovieTicket> tickets;

    public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat) {
        this.movie = movie;
        this.dateAndTime = dateAndTime;
        this.pricePerSeat = pricePerSeat;
    }

    public double getPricePerSeat() {
        return this.pricePerSeat;
    }
    
    public DateTime getDateAndTime() {
        return this.dateAndTime;
    }

    public Movie GetMovie() {
        return this.movie;
    }

    public override string ToString() {
        return this.movie + " Tijd: " + this.dateAndTime + " Prijs per stoel: " + this.pricePerSeat;
    }
}