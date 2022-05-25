using HomeWork_Mentor_Education.Models;
using System.Collections.Generic;

namespace Mentor_Education.Models
{
    public class Position
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Trainer> Trainers { get; set; }
        public List<Courses> Courses { get; set; }





    }
}
