using BL_Crud_Server_Net8.Data;
using BL_Crud_Server_Net8.Entities;
using BL_Crud_Server_Net8.Implementation.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BL_Crud_Server_Net8.Implementation.Services
{
    public class GameService : IGameService
    {
        private readonly AppDbContext _context;

        public GameService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }
    }
}
