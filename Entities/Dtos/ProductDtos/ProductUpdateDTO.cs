﻿using Base.Entities;

namespace Entities.Dtos.Product
{
    public class ProductUpdateDTO : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double? UnitCalorie { get; set; }
        public string ProductType { get; set; }
        public byte[] Image { get; set; }
    }
}
