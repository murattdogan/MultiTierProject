﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MultiTierProject.Core.Model
{
    public class Region
    {
        public Region()
        {
            Cities = new Collection<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
