using System;
using System.Collections.Generic;
using System.Text;
using AdvertApi.Models;

namespace WebAdvert.SearchWorker
{
    public class MappingHelper
    {
        public static AdvertType Map(AdvertConfirmMessage message)    
        {
            var doc = new AdvertType
            {
                Id = message.Id,
                Title = message.Title,
                CreationDateTime = DateTime.UtcNow
            };
             
            return doc;
        }
    }
}