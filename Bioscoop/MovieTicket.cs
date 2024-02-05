using Bioscoop.Ticket;

namespace Bioscoop;

public class MovieTicket {
    private int RowNr;
    private int SeatNr;
    private bool isPremium;
    private MovieScreening movieScreening;
    private PremiumTicket premiumTicket;

    public MovieTicket(MovieScreening movieScreening, int RowNr, int SeatNr, bool isPremium) {
        this.movieScreening = movieScreening;
        this.RowNr = RowNr;
        this.SeatNr = SeatNr;
        //this.isPremium = isPremium;
        if (isPremium) {
            this.premiumTicket = new IsPremiumTicket();
        } else {
            this.premiumTicket = new IsNotPremiumTicket();
        }
    }

    public bool isPremiumTicket() {
        return this.isPremium;
    }

    public double getPrice() {
        double price = this.premiumTicket.calculatePrice() + this.movieScreening.getPricePerSeat();
        return price;
    }

    public MovieScreening GetMovieScreening() {
        return this.movieScreening;
    }

    public int GetRowNr() {
        return this.RowNr;
    }

    public int GetSeatNr() {
        return this.SeatNr;
    }

    public override string ToString() {
        return this.movieScreening + " RijNr: " + this.RowNr + " StoelNr: " + this.SeatNr + " IsPremium: " + this.isPremium;
    }
}