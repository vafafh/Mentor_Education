using Mentor_Education.Models;

namespace HomeWork_Mentor_Education.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }


    }
}
