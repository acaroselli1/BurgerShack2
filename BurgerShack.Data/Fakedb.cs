using BurgerShack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShack.Data
{
    public static class Fakedb
    {
        public static int NextId = 4;
        public static List<Burger> Burgers = new List<Burger>() {

        new Burger()
        {
            Id =1,
            Name = "Plain Jane",
            Price = 7.99m,
            Description = "Delicious yet lacking somehow"
        },
        new Burger()
        {
            Id = 2,
            Name = "Plain Jane with Cheese",
            Price = 8.99m,
            Description = "Delicious"
        },
        new Burger(){
            Id = 3,
            Name = "Hawaiian",
            Price = 12.99m,
            Description = "Pineapple YUM!!"
        }
    };
    }
   

}






