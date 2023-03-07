using Entites.RequestFeatures;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DataTransferObjects
{
    public record class LinkParameters
    {
        public BookParameters BookParameters { get; init; }
        public HttpContext HttpContext { get; init; }
    }
}
