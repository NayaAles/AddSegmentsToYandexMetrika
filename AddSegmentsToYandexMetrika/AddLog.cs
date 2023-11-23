using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSegmentsToYandexMetrika
{
    public class AddLog
    {
        public int Id { get; set; }
        public string SegmentName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? Logs { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public static class Status
    {
        public static readonly string Success = "Success";
        public static readonly string Error = "Error";
    }
}
