namespace Bioscoop;

public class MovieTicket {
    private int RowNr;
    private int SeatNr;
    private boolean isPremium;
    private MovieScreening movieScreening;

    public void MovieTicket(MovieScreening movieScreening, int RowNr, int SeatNr, boolean isPremium) {
        this.movieScreening = movieScreening;
        this.RowNr = RowNr;
        this.SeatNr = SeatNr;
        this.isPremium = isPremium;
    }

    public boolean isPremiumTicket() {
        return this.isPremium;
    }

    public double getPrice() {
        return this.movieScreening.getPricePerSeat();
    }

    public override string ToString() {
        return this.movieScreening + " " + this.RowNr + " " + this.SeatNr + " " + this.isPremium;
    }
}