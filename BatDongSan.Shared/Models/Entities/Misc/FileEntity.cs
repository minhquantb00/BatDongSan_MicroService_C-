using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Misc
{
    public class FileEntity : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        [StringLength(255)]
        public string FileType { get; set; }

        [Required]
        public byte[] Data { get; set; }
    }
}
