﻿using Application.Interface.ProductInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Command
{
    public class ProductCommand : IProductCommand
    {
        private readonly AppDbContext _context;

        public ProductCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertProduct(Product product) 
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task PutProduct(Product product)
        {
            _context.Entry(product).CurrentValues.SetValues(product);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveProduct(Product product)
        {
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
