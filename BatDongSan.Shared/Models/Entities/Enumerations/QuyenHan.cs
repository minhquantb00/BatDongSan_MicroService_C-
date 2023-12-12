using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QuyenHan
    {
        Admin = 1,
        Employee = 2,
        Manager = 3,
        Owner = 4,
    }
}
