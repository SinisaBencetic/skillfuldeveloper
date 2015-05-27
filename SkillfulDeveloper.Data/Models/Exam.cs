using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace SkillfulDeveloper.Data.Models
{
    [TableName("Exam")]
    [PrimaryKey("Id")]
    public class Exam
    {        
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
