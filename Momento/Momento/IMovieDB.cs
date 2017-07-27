namespace Momento
{
    public interface IMovieDB
    {
        void AddMovie(MovieState movie);
        MovieState GetMovie(string name);
        int Count { get;}
    }
}
