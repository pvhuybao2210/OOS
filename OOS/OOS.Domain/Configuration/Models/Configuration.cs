﻿using MongoDB.Bson.Serialization.Attributes;
using OOS.Infrastructure.Mongodb;
using OOS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Domain.Configuration.Models
{
    [BsonIgnoreExtraElements]
    public class Configuration: IAggregateRoot
    {
        public string Id { get; set; }
        public List<string> Carousel { get; set; }
        public Currency Currency { get; set; }
    }
}