using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Models
{
    public class SavedImage
    {
        public int Id { get; set; }
        public string OriginalFileName { get; set; }
        public Guid AccessKey { get; set; }
        public string SafeFileName { get; set; }
        public byte[] Hash { get; set; }
        public string Base64Image { get; set; }
        public string Folder { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedByUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }

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
