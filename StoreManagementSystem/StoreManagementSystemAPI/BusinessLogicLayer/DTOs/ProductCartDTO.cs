﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    internal class ProductCartDTO:ProductDTO
    {
        public List<CartDTO> Carts { get; set; }
        public ProductCartDTO()
        {
            Carts = new List<CartDTO>();
        }
    }
}
