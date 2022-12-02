﻿using Lanches.Context;
using Lanches.Models;
using Lanches.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                   Where(c => c.IsLanchePreferido).
                                   Include(c => c.Categoria);
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(c => c.LancheId == lancheId);
        } 
    }
}
