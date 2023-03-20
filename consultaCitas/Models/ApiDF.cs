using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultaCitas.Models
{
    public class ApiDFRequest
    {
        public string id { get; set; }
        public string sessionId { get; set; }
        public string timestamp { get; set; }
        public string lang { get; set; }
        public ApiDFResult result { get; set; }

    }
    public class ApiDFResult
    {

        public string source { get; set; }
        public string resolvedQuery { get; set; }
        public Dictionary<string, string> parameters { get; set; }
        public Dictionary<string, string> contexts { get; set; }
        public Dictionary<string, string> metadata { get; set; }

    }

    public class ApiAiResponse
    {
        public string speech { get; set; }
        public string fulfillmentText { get; set; }

    }
}
