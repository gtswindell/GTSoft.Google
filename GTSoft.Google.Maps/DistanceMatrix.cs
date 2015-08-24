using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GTSoft.Google.Maps
{
    public class DistanceMatrix : GoogleMapsAPIBase<DistanceMatrix.DistanceResult>
    {

        public class DataType
        {
            [JsonProperty(PropertyName="text")]
            public string Text { get; set; }
            [JsonProperty(PropertyName = "value")]
            public int Value { get; set; }
        }

        public class Element
        {
            [JsonProperty(PropertyName = "distance")]
            public DataType Distance { get; set; }
            [JsonProperty(PropertyName = "duration")]
            public DataType Duration { get; set; }
            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }
        }

        public class Row
        {
            [JsonProperty(PropertyName = "elements")]
            public List<Element> Elements { get; set; }
        }

        public class DistanceResult
        {
            [JsonProperty(PropertyName = "destination_addresses")]
            public List<string> DestinationAddresses { get; set; }
            [JsonProperty(PropertyName = "origin_addresses")]
            public List<string> OriginAddresses { get; set; }
            [JsonProperty(PropertyName = "rows")]
            public List<Row> Rows { get; set; }
            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }
        }

        public DistanceMatrix(string apiKey)
            : base(apiKey)
        {

        }

        protected override string Url
        {
            get
            {
                string url = BaseUri + "distancematrix/json?key=" + APIKey;

                return url;
            }
        }

        protected override string APIName
        {
            get
            {
                throw new NotImplementedException();
            }
        }


    }
}
