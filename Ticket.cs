namespace TicketsManager
{
    class Ticket
    {
        public int Id { get; set; }
        public string DepartureDate { get; set; }
        public string Name { get; set; }
        public string FlightNumber { get; set; }

        public Ticket() { }
        public Ticket(string name, string flightNumber, string departureDate)
        {
            Name = name;
            FlightNumber = flightNumber;
            DepartureDate = departureDate;
        }

        public string ToString()
        {
            return $"Имя= {Name}; Номер рейса= {FlightNumber}; Дата вылета= {DepartureDate}";
        }

    }
}
