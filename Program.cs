namespace TicketsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions command = new Functions();
            if (!command.IsExist("Стивен Сигал")) command.Add(new Ticket("Стивен Сигал", "N5532", "09-11-2024"));
            if (!command.IsExist("Леонардо Ди Каприо")) command.Add(new Ticket("Леонардо Ди Каприо", "A1233", "10-11-2024"));
            if (!command.IsExist("Антонио Бандерос")) command.Add(new Ticket("Антонио Бандерос", "T9911", "11-11-2024"));
            if (!command.IsExist("Деми Мур")) command.Add(new Ticket("Деми Мур", "H233", "12-11-2024"));
            if (!command.IsExist("Кристофер Ноллан")) command.Add(new Ticket("Кристофер Ноллан", "P3300", "13-11-2024"));

            command.ShowAll();
            Ticket ticket = command.FindByName("Капр");
            Console.WriteLine("Билет с подстрокой \"Капр\" найден= ");
            Console.WriteLine(ticket.ToString());
            ticket.DepartureDate = "11 - 11 - 2024";
            ticket.FlightNumber = "A1233";
            command.Update(ticket);

            List<Ticket> list = new List<Ticket>();
            for (int i = 0; i <= 1; i++)
            {
                list.Add(command.FindByDate($"{12 + i}-11-2024"));
            }

            for (int i = 0; i < list.Count; i++)
            {
                command.Remove(list[i]);
            }

            Console.WriteLine("Все изменения : ");
            command.ShowAll();
        }
    }
}
