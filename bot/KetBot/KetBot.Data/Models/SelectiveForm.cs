﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.Models
{
    public class SelectiveForm
    {
        [Key]
        public long Id { get; set; }

        [Index(IsUnique = true)]
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }

        public string Form { get; set; }
    }
}
