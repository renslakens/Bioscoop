namespace Bioscoop;

public class Movie {
    private string title;
    private MovieScreening[] screenings;

    public Movie(string title) {
        this.title = title;
    }

    public void addScreening(MovieScreening screening) {
        this.screenings.add(screening);
    }

    public override string ToString() {
        return this.title + " " + this.screenings;
    }
}