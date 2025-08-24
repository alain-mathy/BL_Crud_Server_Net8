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

        public async Task CreateGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGame(int id)
        {
            var result = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (result is null)
            {
                throw new Exception("Game not found");
            }

            _context.Games.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            var result = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);
            if(result is null)
            {
                throw new Exception("Game not found");
            }

            return result;
        }

        public async Task UpdateGame(int id, Game game)
        {
            var result = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (result is null)
            {
                throw new Exception("Game not found");
            }

            result.Name = game.Name;
            result.Developer = game.Developer;
            result.Release = game.Release;

            await _context.SaveChangesAsync();
        }
    }
}
