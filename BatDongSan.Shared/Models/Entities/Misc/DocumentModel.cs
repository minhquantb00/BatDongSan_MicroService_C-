using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Misc
{
    public class DocumentModel : BaseEntity
    {
        public int NguoiDungId { get; set; }
        public string FileName { get; set; }
        public string LoaiNoiDung { get; set; }
        public long KichThuocFile { get; set; }
        public byte[] NoiDungFile { get; set; }
        public DocumentModel() 
        {
            Id = 0;
            NguoiDungId = 0;
            FileName = "";
            LoaiNoiDung = "";
            KichThuocFile = 0;
            NoiDungFile = null;
        }
    }
}
