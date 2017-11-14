using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Models
{
    public class PickClassViewModel
    {
        public SelectList Classes { get; set; }
        public int SelectedClass { get; set; }

    }
}