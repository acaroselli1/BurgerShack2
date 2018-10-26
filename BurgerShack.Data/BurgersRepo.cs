using BurgerShack.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurgerShack.Data
{   

    public interface IBurgersRepo
    {
        //CRUD
        Burger GetById(int id);
        Burger Update(Burger burger);
        List<Burger> GetAll();
        Burger Create(Burger burger);

    }



    public class BurgersRepo : IBurgersRepo
    {
        private readonly IDbConnection _db;

        public List<Burger> GetAll()
        {
            return Fakedb.Burgers;
        }

        public Burger GetById(int id)
        {
            return Fakedb.Burgers.Find(b => b.Id == id);
        }

        public Burger Update(Burger burger)
        {
            var b = GetById(burger.Id);
            if (b == null) { throw new Exception("Burger not found, invalid id."); }
            b.Name = burger.Name;
            b.Description = burger.Description;
            b.Price = burger.Price;
            return b;

        }

        public BurgersRepo(IDbConnection db)
        {
            _db = db;
        }

        public Burger Create (Burger burger)
        {
            burger.Id = Fakedb.NextId;
            Fakedb.NextId += 1;
            Fakedb.Burgers.Add(burger);
            return burger;

        }
    }

}
