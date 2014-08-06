using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ames.Entities {
    public class EFileInfo {

        [Key]
        public int EFileID { get; set; }

        public DateTime CreatedDateTime { get; set; }

        //[Range(1900,2100)]
        public int Year { get; set; }

        //[Range(1,12)]
        public int Month { get; set; }

        //[StringLength(500)]
        public string DirectoryPath { get; set; }

        //[StringLength(150)]
        //[FileExtensions(Extensions="pdf|xls|doc|xlsx|docx|ppt|pptx")]
        public string EFileName { get; set; }

        //[StringLength(50)]
        public string Location { get; set; }

        //[StringLength(50)]
        public string Brand { get; set; }

        //[StringLength(50)]
        public string Department { get; set; }

        //[StringLength(50)]
        public string Type { get; set; }

        //[StringLength(50)]
        public string GeneratedFrom { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public Guid FileGUID { get; set; }


    }
}
