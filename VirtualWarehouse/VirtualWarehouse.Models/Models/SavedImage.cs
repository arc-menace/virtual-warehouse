using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Interfaces;

namespace VirtualWarehouse.Models.Models
{
    public class SavedImage : IDbItem
    {
        public int Id { get; set; }
        public string OriginalFileName { get; set; }
        public Guid AccessKey { get; set; }
        public string SafeFileName { get; set; }
        public byte[] Hash { get; set; }
        public string Folder { get; set; }

        [NotMapped]
        public string Base64Image { get; set; }

        public int CreatedByUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public Status Status { get; set; }


        public string GetFileExtension(bool includePeriod = true)
        {
            string extension = Path.GetExtension(OriginalFileName);

            if (!includePeriod)
            {
                extension = extension[1..];
            }

            return extension;
        }
    }
}
