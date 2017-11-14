using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(PaymentMethodMetaData))]
    public partial class PaymentMethod
    { }

    public class PaymentMethodMetaData
    {
        [DisplayName("Payment Method")]
        public string PaymentMethod1 { get; set; }

    }
}