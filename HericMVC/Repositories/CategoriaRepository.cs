﻿using HericMVC.Context;
using HericMVC.Models;
using HericMVC.Repositories.Interfaces;

namespace HericMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
