using MongoDB.Driver;
using MvcMovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieApi.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<Movie> _movies;
        public MovieService(IMoviesDatabaseSettings settings)
        {
           if(settings.ConnectionString!=null)
            {
                var client = new MongoClient(settings.ConnectionString);
                var database = client.GetDatabase(settings.DatabaseName);

                _movies = database.GetCollection<Movie>(settings.MoviesCollectionName);
            }
        }

        public List<Movie> Get() => _movies.Find(book => true).ToList();

        public Movie Get(int? Id) =>
            _movies.Find<Movie>(movie => movie.Id == Id).FirstOrDefault();

        public Movie Create(Movie movieItem)
        {
            _movies.InsertOne(movieItem);
            return movieItem;
        }

        public bool Update(int Id, Movie movieIn)
        {
            try
            {
                _movies.ReplaceOne(movie => movie.Id == Id, movieIn);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Delete(int Id)
        {
           _movies.DeleteOne(movie => movie.Id == Id);
        }

        public void Delete(Movie movieItem)
        {
            _movies.DeleteOne(movie => movie.Id == movieItem.Id);
        }

        public Movie Find(int? Id)
        {
            return _movies.Find(movie => movie.Id == Id).FirstOrDefault();
        }
    } 
}
