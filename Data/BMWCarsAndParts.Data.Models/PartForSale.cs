﻿namespace BMWCarsAndParts.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BMWCarsAndParts.Data.Common.Models;

    public class PartForSale : BaseDeletableModel<int>
    {
        [Required]
        public int PartTypeId { get; set; }

        public virtual PartType PartType { get; set; }

        [Required]
        public string CarModelId { get; set; }

        public virtual CarModel CarModel { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string SellerId { get; set; }

        public virtual ApplicationUser Seller { get; set; }

        public string ImageId { get; set; }

        public virtual Image Image { get; set; }
    }
}
