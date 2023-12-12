using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonConverterAttribute = System.Text.Json.Serialization.JsonConverterAttribute;

namespace BatDongSan.Shared.Models.Entities.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ThongBao
    {
        ThanhCong = 1,
        ThongTin = 2,
        CanhBao = 3,
        Loi = 4,
        FatalError = 5
    }
}
