using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainWebApp.Data
{
    public class Train
    {
        public int train_no { get; set; }
        public string train_name { get; set; }
        public string source_name { get; set; }
        public string destination_name { get; set; }

        public TimeSpan start_time { get; set; }

        public TimeSpan end_time { get; set; }
    }
}