using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote.Entities
{
    public class Comment
    {
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public Comment(string content, DateTime date)
        {
            Content = content;
            Date = date;
        }
    }
}
