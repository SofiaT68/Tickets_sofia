namespace TicketsManager
{
    class Functions
    {
        private readonly ApplicationContext _context;

        public Functions()
        {
            _context = new ApplicationContext();
            _context.Database.EnsureCreated();
        }

        public void Add(Ticket newTicket)
        {
            _context.Tickets.Add(newTicket);
            _context.SaveChanges();
        }
        public void Remove(Ticket remTicket)
        {
            _context.Tickets.Remove(remTicket);
            _context.SaveChanges();
        }
        public void Update(Ticket updateTicket)
        {
            _context.Tickets.Update(updateTicket);
            _context.SaveChanges();
        }
        public bool IsExist(string name)
        {
            return FindByName(name) != null;
        }
        public Ticket FindByName(string name)
        {
            return _context.Tickets.FirstOrDefault(ticket => ticket.Name.Contains(name));
        }
        public Ticket FindByDate(string date)
        {
            return _context.Tickets.FirstOrDefault(ticket => ticket.DepartureDate.Contains(date));
        }
        public void ShowAll()
        {
            foreach (var item in _context.Tickets)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
