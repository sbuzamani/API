using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MyLibrary.Domain.Entities;
namespace MyLibrary.Domain

{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoClient _client;

        private readonly IMongoDatabase database;

        public BookRepository(string connectionString, string databaseName)
        {
            _client = new MongoClient(connectionString);
            database = _client.GetDatabase(databaseName);
        }

        public void DeleteAll()
        {
            var collection = GetCollection();

            var filter = Builders<Book>.Filter.Empty;

            collection.DeleteMany(filter);
        }

        public IList<Book> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Book GetOne(string v)
        {
            throw new System.NotImplementedException();
        }

        public Book GetOneById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new System.NotImplementedException();
        }
        protected IMongoCollection<Book> GetCollection()
        {
            var collectionName = GetCollectionName();

            return database.GetCollection<Book>(collectionName);
        }
        private string GetCollectionName()
        {
            return typeof(Book).GetType().Name;
        }
    }
}