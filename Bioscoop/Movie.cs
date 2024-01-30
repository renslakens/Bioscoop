namespace Bioscoop;

public class Movie {
    private string title;
    private List<MovieScreening> screenings;

    public Movie(string title) {
        this.title = title;
    }

    public void addScreening(MovieScreening screening) {
        screenings.Add(screening);
    }

    public override string ToString() {
        return this.title + " " + this.screenings;
    }
}