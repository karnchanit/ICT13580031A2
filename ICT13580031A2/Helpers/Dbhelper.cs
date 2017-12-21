using System;
using ICT13580031A2.Models;
using SQLite;
namespace ICT13580031A2.Helpers
{
    public class Dbhelper

    {
        SQLiteConnection db;

        public Dbhelper(string dbPath)
        {
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Product>();
  		}

        public int AddProduct(Product product)
        {
             db.Insert(product);
            return product.id;
        }


    }
}
