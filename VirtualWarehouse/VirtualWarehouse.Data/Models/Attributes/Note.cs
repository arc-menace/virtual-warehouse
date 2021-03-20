using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualWarehouse.Data.Models.Attributes
{
    public class Note : ThingAttribute
    {
        public string NoteContent { get; set; }
    }
}
