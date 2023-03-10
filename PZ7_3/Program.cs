using PZ7_3;

Holiday NewYear = new Holiday("New year", new DateTime(2024, 12, 31));
NewYear.RegisterClient(new Client("Fedor", Status.VIP));

NewYear.Notify();