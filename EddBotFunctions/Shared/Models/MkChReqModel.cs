using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddBotFunctions.Shared.Models
{
    public class MkChReqModel
    {
        public string? Category { get; set; }
        public string? ChannelName { get; set; }
        public List<string>? Threads { get; set; }
    }
}
