﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtService.Domain.Entities.Estates;
public class Restaurant: CommercialEstate
{
    public int MaxGuestNumber { get; set; }
}
