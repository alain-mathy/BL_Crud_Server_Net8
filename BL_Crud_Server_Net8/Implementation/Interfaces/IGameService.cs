using BL_Crud_Server_Net8.Entities;

namespace BL_Crud_Server_Net8.Implementation.Interfaces
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        Task CreateGame(Game game);
        Task UpdateGame(int id, Game game);
        Task DeleteGame(int id);
    }
}
