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
        private readonly IMongoCollection<MovieItem> _movies;
        public MovieService(IMoviesDatabaseSettings settings)
        {
           if(settings.ConnectionString!=null)
            {
                var client = new MongoClient(settings.ConnectionString);
                var database = client.GetDatabase(settings.DatabaseName);

                _movies = database.GetCollection<MovieItem>(settings.MoviesCollectionName);
            }
        }

        public List<MovieItem> Get() => _movies.Find(book => true).ToList();

        public MovieItem Get(int Id) =>
            _movies.Find<MovieItem>(movie => movie.Id == Id).FirstOrDefault();

        public MovieItem Create(MovieItem movieItem)
        {
            _movies.InsertOne(movieItem);
            return movieItem;
        }

        public bool Update(int Id, MovieItem movieIn)
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

        public void Delete(MovieItem movieItem)
        {
            _movies.DeleteOne(movie => movie.Id == movieItem.Id);
        }

        public MovieItem Find(int Id)
        {
            return _movies.Find(movie => movie.Id == Id).FirstOrDefault();
        }
    } 
}
