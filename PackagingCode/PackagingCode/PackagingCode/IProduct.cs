﻿using System;
using System.Collections.Generic;
using System.Text;

namespace packagingcode
{
    public interface IProduct
    {
        int ID { get; set; }

        string Name { get; set; }

        decimal Mrp { get; set; }

        void ExecutePostOrder();
    }
}
