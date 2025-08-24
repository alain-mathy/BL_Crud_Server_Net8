using BL_Crud_Server_Net8.Entities;

namespace BL_Crud_Server_Net8.Implementation.Interfaces
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}
