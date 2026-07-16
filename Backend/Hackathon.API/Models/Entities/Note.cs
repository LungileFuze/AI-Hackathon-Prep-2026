namespace Hackathon.API.Models.Entities
{
    public class Note
    {
        public  int Id { get; set; }

        public string Title { get; set; } = string.Empty;   

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;


    }
}
