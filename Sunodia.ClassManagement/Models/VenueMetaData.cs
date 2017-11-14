using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(VenueMetaData))]
    public partial class Venue
    {


    }

    public class VenueMetaData
    {
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(3)]
        public string State { get; set; }

    }
}


