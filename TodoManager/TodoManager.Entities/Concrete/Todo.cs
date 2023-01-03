using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Core.Entities.Abstract;

namespace TodoManager.Entities.Concrete
{
    public class Todo : IEntity
    {
        [Key]
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}
