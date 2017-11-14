using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(PeopleMetaData))]
    public partial class Person
    {


    }
    public class PeopleMetaData
    {
        //[DisplayFormat(DataFormatString = "{0:dd - MMM - yyyy}")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        public string Email { get; set; }

        [DisplayName("Cell Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone#")]
        public string Phone { get; set; }
        public string Street { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }
        [DisplayName("Alternate Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone#")]
        public string Phone2 { get; set; }
        public string Comments { get; set; }
    }
}


