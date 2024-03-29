﻿namespace Bioscoop;

public class MovieTicket {
    private int RowNr;
    private int SeatNr;
    private bool isPremium;
    private MovieScreening movieScreening;

    public MovieTicket(MovieScreening movieScreening, int RowNr, int SeatNr, bool isPremium) {
        this.movieScreening = movieScreening;
        this.RowNr = RowNr;
        this.SeatNr = SeatNr;
        this.isPremium = isPremium;
    }

    public bool isPremiumTicket() {
        return this.isPremium;
    }

    public double getPrice() {
        return this.movieScreening.getPricePerSeat();
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