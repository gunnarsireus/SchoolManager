﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Client.Models.CarViewModel
{
    public class CarListViewModel : Car
    {
        public List<SelectListItem> CompanySelectList { get; set; }
        public List<Car> Cars { get; set; }
    }
}