using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(Cost2StudentMetaData))]
    public partial class EventCost2Student
    {

    }

    public class Cost2StudentMetaData
    {

        [DisplayName("Description")]
        public string CostDescription { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal Cost { get; set; }
    }
}







