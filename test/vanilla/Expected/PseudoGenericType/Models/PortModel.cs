// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zapappi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PortModel
    {
        /// <summary>
        /// Initializes a new instance of the PortModel class.
        /// </summary>
        public PortModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortModel class.
        /// </summary>
        public PortModel(int? id = default(int?), string reference = default(string), string state = default(string), System.DateTime? portDate = default(System.DateTime?), System.DateTime? requestedPortDate = default(System.DateTime?), string type = default(string), int? loaId = default(int?), string loaURL = default(string), string billURL = default(string), string billingNumber = default(string), System.DateTime? createdDate = default(System.DateTime?))
        {
            Id = id;
            Reference = reference;
            State = state;
            PortDate = portDate;
            RequestedPortDate = requestedPortDate;
            Type = type;
            LoaId = loaId;
            LoaURL = loaURL;
            BillURL = billURL;
            BillingNumber = billingNumber;
            CreatedDate = createdDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PortDate")]
        public System.DateTime? PortDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestedPortDate")]
        public System.DateTime? RequestedPortDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LoaId")]
        public int? LoaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LoaURL")]
        public string LoaURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BillURL")]
        public string BillURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BillingNumber")]
        public string BillingNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public System.DateTime? CreatedDate { get; set; }

    }
}
