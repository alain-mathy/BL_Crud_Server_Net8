namespace BL_Crud_Server_Net8.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public DateTime? Release { get; set; }
    }
}
