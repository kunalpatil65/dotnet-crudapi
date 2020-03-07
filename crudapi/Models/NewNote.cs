using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudapi.Models
{
    public class NewNote
    {
        public string Content { get; set; }

        public bool IsActive { get; set; }
    }
}