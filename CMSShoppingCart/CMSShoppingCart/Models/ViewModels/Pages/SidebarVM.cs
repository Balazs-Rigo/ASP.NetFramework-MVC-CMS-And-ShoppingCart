using CMSShoppingCart.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSShoppingCart.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM(SidebarDTO row)
        {
            Id = row.Id;
            Body = row.Body;
        }

        public SidebarVM()
        {

        }
        public int Id { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}