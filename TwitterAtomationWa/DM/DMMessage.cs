using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterAtomationWa.DM
{
    public class DMMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public DateTime DateSended { get; set; }
    }
}
