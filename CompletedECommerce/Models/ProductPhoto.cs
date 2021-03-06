﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class ProductPhoto
    {
        public int Id { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Select product.")]
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public bool Featured { get; set; }

        public Product Product { get; set; }
    }
}
