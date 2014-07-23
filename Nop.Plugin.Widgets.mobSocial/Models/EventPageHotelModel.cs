﻿using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nop.Plugin.Widgets.mobSocial.Models
{
    public class EventPageHotelModel : BaseNopEntityModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipPostalCode { get; set; }
    }
}