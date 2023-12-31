﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities.Products
{
    public class Monitor : Product
    {
        public string? Diagonal { get; set; }
        public string? Frequency { get; set; }
        public string? Reaction { get; set; }
        public string? Brightness { get; set; }
        public string? MatrixType { get; set; }
        public string? Interfaces { get; set; }
        public string? Contrast { get; set; }
        public string? Ratio { get; set; }
    }
}
