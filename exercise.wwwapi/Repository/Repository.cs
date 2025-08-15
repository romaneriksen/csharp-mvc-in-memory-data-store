using Microsoft.EntityFrameworkCore;
using System;
using exercise.wwwapi.Data;
using exercise.wwwapi.Models;
using workshop.wwwapi.Repository;

namespace exercise.wwwapi.Repository
{
    public class Repository : IRepository
    {

        private DataContext _db;
        public Repository(DataContext db)
        {
            _db = db;
        }

    }
}
