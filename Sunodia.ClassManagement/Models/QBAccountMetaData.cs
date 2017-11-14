using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(QBAccountMetaData))]
    public partial class QBAccount
    { }

    public class QBAccountMetaData
    {
        [DisplayName("Account")]
        public string QBAccount1 { get; set; }
        [DisplayName("Credit")]
        public bool IsCredit { get; set; }

        //public int Id { get; set; }
        //public string Description { get; set; }

    }
}

