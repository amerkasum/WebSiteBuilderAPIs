using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class MessageUsViewModel
    {
        public string EmailSender { get; set; }
        public string Message { get; set; }
        public int MessageUsReasonId { get; set; }

    }
}
