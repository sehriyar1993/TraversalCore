﻿using DataAcsesslayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalProje.CQRS.Result.DestinationResault;

namespace TraversalProje.CQRS.Handlers.DestinationHandler
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                dayNight = x.DayNight,
                price = x.Price

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
