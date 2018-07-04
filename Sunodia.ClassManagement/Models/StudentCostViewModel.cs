using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Sunodia.ClassManagement.Models
{
    public class StudentCostViewModel
    {
        [Key]
        public int EventId { get; set; }
        public  Event Event { get; set; }
        public Person Student { get; set; }

        public List<vwEventTransaction> StudentTransactions { get; set; }
        public List<StudentCost> DefaultCosts { get; set; }
        public IEnumerable<SelectListItem> EventDescs { get; set; }
        public IEnumerable<SelectListItem> RegTypes { get; set; }
        public IEnumerable<SelectListItem> PaymentTypes { get; set; }
        public SelectList EventDescs2 { get; set; }
        public SelectList RegTypes2 { get; set; }

    }

}

