using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(CourseMaterialMetaData))]
    public partial class CourseMaterial
    {

    }

    public class CourseMaterialMetaData
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        [DisplayName("Name")]
        public string MaterialName { get; set; }
        [DisplayName("Student Cost") ]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal CostToStudent { get; set; }
        [DisplayName("FHI Cost")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal CostToOrg { get; set; }
        [DisplayName("Options")]
        public string PurchaseOptions { get; set; }
        [DisplayName("Vendor")]
        public Nullable<int> VendorId { get; set; }

    }
}


