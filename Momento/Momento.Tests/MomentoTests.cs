using System;
using NUnit.Framework;
using Moq;
using System.Threading;

namespace Momento.Tests
{
    [TestFixture]
    public class MomentoTests
    {
        Movie testMovie;
        Movie movie;
        MovieState testState;
        IMovieDB movieDB;

        [SetUp]
        public void Setup()
        {
            testMovie = new Movie() { Name = "Terminator", Length = 100};
            var movieDBMock = new Mock<IMovieDB>();

            testState = new MovieState() { Name = "Banana", Length = 100, Position = 10 };
            movieDBMock.Setup(m => m.GetMovie(It.IsAny<string>())).Returns(testState);
            movieDB = movieDBMock.Object;
        }
        [Test]
        public void IsMovie()
        {
            Assert.That(testMovie.Name, Is.EqualTo("Terminator"));
        }
        [Test]
        public void ReturnMovieState()
        {
            var movie = new Movie() { Name = "Banana", Length = 100 };
            var state = movie.GetState();
            Assert.That(state.Name, Is.EqualTo(testState.Name));
        }
        [Test]
        public void PlayingMovieUpgradedPosition()
        {
            var movie = new Movie() { Name = "Banana", Length = 100 };
            movie.Play();
            Thread.Sleep(4000);
            movie.Stop();
            var state = movie.GetState();
            Assert.That(state.Position, Is.GreaterThanOrEqualTo(3));

        }
        [Test]
        public void NewMovieSetState()
        {
            var movie = new Movie();
            movie.SetState(testState);
            Assert.That(movie.Name, Is.EqualTo(testState.Name));
        }

    }
}
