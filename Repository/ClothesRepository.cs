using _2301854403_Benny_Kharisma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2301854403_Benny_Kharisma.Repository
{
    public class ClothesRepository
    {

        public static List<Cloth> getAllClothes()
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            List<Cloth> clothes = (from x in db.Clothes select x).ToList();
            return clothes;
        }

        public static void insertClothes(Cloth cloth)
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            db.Clothes.Add(cloth);
            db.SaveChanges();
        }

        public static Cloth getClothesbyId(int id)
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            Cloth cloth = (from x in db.Clothes where x.ClothId == id select x).FirstOrDefault();
            return cloth;
        }

        public static bool checkName(string name)
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            Cloth cloth = (from x in db.Clothes where x.Name.Equals(name) select x).FirstOrDefault();
            if (cloth == null) return true;
            else return false;
        }

        public static void updateClothes(int id, Cloth newCloth)
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            Cloth cloth = (from x in db.Clothes where x.ClothId == id select x).FirstOrDefault();
            cloth.Name = newCloth.Name;
            cloth.Price = newCloth.Price;
            cloth.Type = newCloth.Type;
            cloth.Description = newCloth.Description;

            db.SaveChanges();
        }

        public static void deleteClothes(int id)
        {
            ClothesStoreEntities db = new ClothesStoreEntities();
            Cloth cloth = (from x in db.Clothes where x.ClothId == id select x).FirstOrDefault();
            db.Clothes.Remove(cloth);
            db.SaveChanges();
        }
    }
}