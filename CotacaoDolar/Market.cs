using Newtonsoft.Json;

namespace CotacaoDolarMS
{
    public class Market
    {
        public Market()
        {
            Currency = new Currency();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}