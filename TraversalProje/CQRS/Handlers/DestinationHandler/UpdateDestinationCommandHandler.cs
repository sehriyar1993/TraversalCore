using DataAcsesslayer.Concrete;
using TraversalProje.CQRS.Commands.DestinationCommands;

namespace TraversalProje.CQRS.Handlers.DestinationHandler
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.ID);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            
            _context.SaveChanges();
        }
    }
}
