using DataAcsesslayer.Concrete;
using TraversalProje.CQRS.Commands.DestinationCommands;

namespace TraversalProje.CQRS.Handlers.DestinationHandler
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;
        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
