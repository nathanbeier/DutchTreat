﻿using System.Collections.Generic;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        
        bool SaveAll();
        bool SaveChanges();
        void AddEntity(object model);
    }
}