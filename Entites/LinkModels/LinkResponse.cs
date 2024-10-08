﻿using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.LinkModels
{
    public class LinkResponse
    {
        public bool HasLinks { get; set; }
        public List<Entity> ShapedEntites { get; set; }
        public LinkCollectionWrapper<Entity> LinkedEntites { get; set; }

        public LinkResponse()
        {
            ShapedEntites = new List<Entity>();
            LinkedEntites = new LinkCollectionWrapper<Entity>();
        }
    }
}
