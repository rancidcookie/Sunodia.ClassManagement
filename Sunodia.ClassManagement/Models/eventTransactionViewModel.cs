using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Models
{
    public class eventTransactionViewModel
    {
        [Key]
        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<vwEventTransaction> Transactions { get; set; }
        public IEnumerable<SelectListItem> TransactionCategories { get; set; }
    }
}
