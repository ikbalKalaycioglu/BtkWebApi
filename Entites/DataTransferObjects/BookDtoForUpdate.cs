﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DataTransferObjects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; set; }

    }
}
