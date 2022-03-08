using _2301854403_Benny_Kharisma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2301854403_Benny_Kharisma.Factory
{
    public class ClothFactory
    {
        public static Cloth createCloth(string name, string type, string desc, int price)
        {
            Cloth cloth = new Cloth
            {
                Name = name,
                Type = type,
                Description = desc,
                Price = price,
            };
            return cloth;
        }
    }
}