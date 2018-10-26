using BurgerShack.Data;
using BurgerShack.Entities;
using System;
using System.Collections.Generic;

namespace BurgerShack.Business
{   

    public class BurgersService
    {
        private readonly IBurgersRepo _burgersRepo;

        public BurgersService(IBurgersRepo burgersRepo)
        {
            _burgersRepo = burgersRepo;
           
        }

        public Burger GetById(int id)
        {   
            //autheticate here maybe
            return _burgersRepo.GetById(id);
        }
        
        public List<Burger> GetAll()
        {
            return _burgersRepo.GetAll();
        }

        public Burger Update(Burger burger)
        {   
            //do some work
            return _burgersRepo.Update(burger);
        }

        public Burger Create(Burger burger)
        {
            return _burgersRepo.Create(burger);
        }
    }
}
