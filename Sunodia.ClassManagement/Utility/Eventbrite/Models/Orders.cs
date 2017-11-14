using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunodia.ClassManagement.Utility.Eventbrite.Models
{
    [DataContract]
    public class Orders
    {
        [DataMember]
        public Pagination pagination { get; set; }
        [DataMember]
        public List<Order> orders { get; set; }
    }

    [DataContract]
    public class BasePrice
    {
        [DataMember]
        public string display { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string major_value { get; set; }
    }
    [DataContract]
    public class EventbriteFee
    {
        [DataMember]
        public string display { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string major_value { get; set; }
    }
    [DataContract]
    public class Gross
    {
        [DataMember]
        public string display { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string major_value { get; set; }
    }
    [DataContract]
    public class PaymentFee
    {
        [DataMember]
        public string display { get; set; }
        [DataMember]
        public string currency { get; set; }
                [DataMember]
        public int value { get; set; }
        [DataMember]
        public string major_value { get; set; }
    }
    [DataContract]
    public class Tax
    {
        [DataMember]
        public string display { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public int value { get; set; }
        [DataMember]
        public string major_value { get; set; }
    }
    [DataContract]
    public class Costs
    {
        [DataMember]
        public BasePrice base_price { get; set; }
        [DataMember]
        public EventbriteFee eventbrite_fee { get; set; }
        [DataMember]
        public Gross gross { get; set; }
        [DataMember]

        public PaymentFee payment_fee { get; set; }
        [DataMember]
        public Tax tax { get; set; }
    }
    [DataContract]
    public class Order
    {
        [DataMember]
        public Costs costs { get; set; }
        [DataMember]
        public string resource_uri { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string changed { get; set; }
        [DataMember]
        public string created { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string first_name { get; set; }
        [DataMember]
        public string last_name { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public object time_remaining { get; set; }
        [DataMember]
        public string event_id { get; set; }
    }


}
