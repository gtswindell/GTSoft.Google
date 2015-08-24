using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSoft.Google.Maps
{
    public abstract class GoogleMapsAPIBase<T>
    {
        const string baseUrl = @"https://maps.googleapis.com/maps/api/";
        //public enum OutputType { JSON, XML };
        public enum UnitType { Metric, Imperial };

        protected GoogleMapsAPIBase(string apiKey)
        {
            this.APIKey = apiKey;
            //Output = OutputType.JSON;
            Unit = UnitType.Metric;
        }

        public T GetData()
        {
            string url = Url;
            return default(T);
        }

        protected string BaseUri {
            get
            {
                return baseUrl;
            }
        }
        protected abstract string APIName { get; }
        protected abstract string Url{ get; }
        
        public string APIKey { get; private set; }
        public UnitType Unit { get; set; }
    }
}
