using System;
using NUnit.Framework;

namespace Momento.Tests
{
    [TestFixture]
    public class MomentoTests2
    {
        MovieState testState;

        [SetUp]
        public void Setup()
        {
            testState = new MovieState() { Name = "Banana", Length = 100, Position = 10 };
        }

        [Test]
        public void AddMovieIncrementCount()
        {
            var movieDB = new MovieDB();
            movieDB.AddMovie(testState);
            Assert.That(movieDB.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetMovieRetursMovie()
        {
            var movieDB = new MovieDB();
            movieDB.AddMovie(testState);
            var state = movieDB.GetMovie("Banana");
            Assert.That(state.Name, Is.EqualTo(testState.Name));
        }

        [Test]
        public void GetInvalidMovieRetursNull()
        {
            var movieDB = new MovieDB();
            var state = movieDB.GetMovie("Banana");
            Assert.That(state, Is.Null);
        }
    }
}
