using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillfulDeveloper.Data.Models
{
    [TableName("Tag")]
    [PrimaryKey("Name")]
    public class Tag
    {
        public string Name { get; set; }
    }
}
