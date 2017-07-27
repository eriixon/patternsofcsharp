using System;
using System.Collections.Generic;

namespace Momento
{
    public class MovieDB: IMovieDB
    {
        private Dictionary<string, MovieState> storage;
        public MovieDB()
        {
            storage = new Dictionary<string, MovieState>();
        }

        public int Count
        {
            get { return storage.Count; }
        }

        public void AddMovie(MovieState movie)
        {
            if (storage.ContainsKey(movie.Name))
            {
                storage[movie.Name] = movie;
            }
            else storage.Add(movie.Name, movie);
        }
        public MovieState GetMovie(string name)
        {
            if (storage.ContainsKey(name))
            {
                return storage[name];
            }
            else return null;
        }
    }
}
