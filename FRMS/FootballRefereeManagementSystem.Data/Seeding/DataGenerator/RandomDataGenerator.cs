namespace FootballRefereeManagementSystem.Data.Seeding.DataGenerator
{
    internal static class RandomDataGenerator
    {
        internal static int GenerateRandomAge(int ageMinValue, int ageMaxValue)
        {
            Random randomAgeGenerator = new Random();

            int age = randomAgeGenerator.Next(ageMinValue, ageMaxValue);

            return age;
        }

        internal static string GenerateRandomFirstName()
        {
            string[] namesPool = { "Иван", "Петър", "Георги", "Николай", "Димитър", "Александър", "Владимир",
                "Стефан", "Кристиян", "Мартин", "Васил", "Любомир", "Радослав", "Андрей", "Тодор", "Радослав",
                "Павел", "Илиян", "Виктор", "Михаил", "Христо", "Калоян", "Ивайло", "Симеон", "Борис", "Иво",
                "Стефано", "Алексей", "Румен", "Даниел", "Янко", "Християн", "Велин", "Борислав", "Георгиос",
                "Антон", "Марин", "Георги", "Михаел", "Любен", "Димо", "Илия", "Ангел", "Марио", "Габриел",
                "Антонио", "Емил", "Максим", "Стефанос", "Никола", "Роберт", "Йордан" };

            Random random = new Random();

            return namesPool[random.Next(namesPool.Length)];
        }

        internal static string GenerateRandomLastName()
        {
            string[] namesPool = { "Иванов", "Петров", "Георгиев", "Николов", "Димитров", "Александров", "Владимиров",
                "Стефанов", "Кристиянов", "Мартинов", "Василев", "Любомиров", "Радославов", "Андреев", "Тодоров",
                "Павлов", "Илиев", "Викторов", "Михайлов", "Христов", "Калоянов", "Ивайлов", "Симеонов", "Борисов",
                "Ивов", "Стефанов", "Алексеев", "Руменов", "Даниелов", "Янков", "Христов", "Велинов", "Бориславов",
                "Георгиев", "Антонов", "Маринов", "Георгиев", "Михаелов", "Любенов", "Димов", "Илиев", "Ангелов",
                "Маринов", "Габриелов", "Антониев", "Емилов", "Максимов", "Стефаносов", "Николов", "Робертов",
                "Йорданов", "Алексиев", "Иванов", "Димитров", "Георгиев", "Мартинов", "Николов", "Петров",
                "Стефанов", "Кристиянов", "Иванов" };

            Random random = new Random();

            return namesPool[random.Next(namesPool.Length)];
        }

        internal static string GeneratePhoneNumber()
        {
            Random randomPhoneNumberGenerator = new Random();

            int PhoneNumberMinValue = 800000000;
            int PhoneNumberMaxValue = 999999999;

            string phoneNumber = randomPhoneNumberGenerator
                .Next(PhoneNumberMinValue, PhoneNumberMaxValue)
                .ToString()
                .Insert(0, "0");

            return phoneNumber; // should look like this: 0894124526
        }

        /// <summary>
        /// Generates a new DateTime that will be between the starting parameters and today's date.
        /// </summary>
        /// <param name="startingYear">Minimum year value</param>
        /// <param name="startingMonth">Minimum month value</param>
        /// <param name="startingDay">Minimum day value</param>
        /// <returns>Random DateTime</returns>
        internal static DateTime GenerateRandomDateTime(int startingYear, int startingMonth, int startingDay)
        {
            Random random = new Random();

            DateTime startingDate = new DateTime(startingYear, startingMonth, startingDay);
            int range = (DateTime.Today - startingDate).Days;

            return startingDate.AddDays(random.Next(range));
        }
    }
}
