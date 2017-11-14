using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Models
{
    public static class modelExtensions
    {
        public static SelectList PreAppend(this SelectList list, string dataTextField, string selectedValue, bool selected = false)
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Selected = selected, Text = dataTextField, Value = selectedValue });
            //items.AddRange(list.Items.Cast<SelectListItem>().ToList());
            return new SelectList(items, "Value", "Text");
        }
        public static SelectList Append(this SelectList list, string dataTextField, string selectedValue, bool selected = false)
        {
            var items = list.Items.Cast<SelectListItem>().ToList();
            items.Add(new SelectListItem() { Selected = selected, Text = dataTextField, Value = selectedValue });
            return new SelectList(items, "Value", "Text");
        }
        public static SelectList Default(this SelectList list, string DataTextField, string SelectedValue)
        {
            return list.PreAppend(DataTextField, SelectedValue, true);
        }
    }
}