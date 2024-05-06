﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product
    {
        private PBL3Entities db = new PBL3Entities();
        public List<tb_Product> GetProductsFromTable(string tableName)
        {

            return db.tb_Product.ToList();

        }
        public tb_Product getItem(string id) { return db.tb_Product.FirstOrDefault(x => x.ProductID == id); }
        public bool checkExist(string id)
        {
            List<tb_Product> tb_Product = GetProductsFromTable("tb_Product");

            foreach (var account in tb_Product)
            {
                if (account.ProductID.Trim() == id)
                {
                    return true;
                }
            }

            return false;
        }

        public tb_Product AddNew(tb_Product customer)
        {
            try
            {
                db.tb_Product.Add(customer);
                db.SaveChanges();
                return customer;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception Message: " + ex.InnerException.Message);
                }

                throw;
            }

        }
        public tb_Product Update(tb_Product product)
        {
            try
            {
                var _dt = db.tb_Product.FirstOrDefault(x => x.ProductID == product.ProductID);
                _dt.ProductName = product.ProductName;
                _dt.Price = product.Price;
                _dt.AddedDate = product.AddedDate;
                _dt.DeleteDate = product.DeleteDate;
                _dt.Description = product.Description;
                _dt.CategoryID = product.CategoryID;
                _dt.ImageProduct = product.ImageProduct;
                db.SaveChanges();

                return product;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                var _dt = db.tb_Product.FirstOrDefault(x => x.ProductID == id);
                db.tb_Product.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
