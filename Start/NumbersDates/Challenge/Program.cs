using System;

while (true) // Loop to keep the program running
{
    Console.WriteLine("Enter a date (MM/DD/YYYY) or type 'exit' to quit:");
    string userInput = Console.ReadLine();

    // Exit condition
    if (userInput.ToLower() == "exit") // Corrected: userInput.ToLower() needs parentheses
    {
        break; // Use break to exit the loop
    }

    // Try parsing the entered date
    DateTime dateIn;
    if (DateTime.TryParse(userInput, out dateIn))
    {
        DateTime currentDate = DateTime.Now;
        TimeSpan dateDifference = dateIn - currentDate; // Calculate the difference from the current date

        // Calculate days since New Year's Day
        DateTime newYear = new DateTime(currentDate.Year, 1, 1);
        TimeSpan daysSinceNewYear = currentDate - newYear;

        // Calculate days until the next New Year's Day
        DateTime nextNewYear = new DateTime(currentDate.Year + 1, 1, 1);
        TimeSpan daysUntilNextNewYear = nextNewYear - currentDate;

        // Calculate days since April 1st
        DateTime aprilFirst = new DateTime(currentDate.Year, 4, 1);
        TimeSpan daysSinceAprilFirst = currentDate - aprilFirst;

        // Display calculations
        Console.WriteLine($"Days since New Year's Day: {daysSinceNewYear.Days}");
        Console.WriteLine($"Days until next New Year's Day: {daysUntilNextNewYear.Days}");

        if (currentDate.Month > 4 || (currentDate.Month == 4 && currentDate.Day > 1))
        {
            // If the current date is after April 1st, calculate the days since April 1st
            Console.WriteLine($"Days since April 1st: {daysSinceAprilFirst.Days}");
        }
        else
        {
            // If the current date is before April 1st, calculate the days until April 1st of the current year
            TimeSpan daysUntilAprilFirst = aprilFirst - currentDate;
            Console.WriteLine($"Days until April 1st: {daysUntilAprilFirst.Days}");
        }

        // Check the date input to determine its status (future, past, or today)
        if (dateDifference.TotalDays > 0) // Date is ahead (future)
        {
            Console.WriteLine($"There are {Math.Ceiling(dateDifference.TotalDays)} days remaining until {dateIn.ToShortDateString()}.");
        }
        else if (dateDifference.TotalDays < 0) // Date is in the past
        {
            Console.WriteLine($"{Math.Abs(Math.Floor(dateDifference.TotalDays))} days have passed since {dateIn.ToShortDateString()}.");
        }
        else // Date is today
        {
            Console.WriteLine("The entered date is today!");
        }
    }
    else
    {
        // Handle invalid date input
        Console.WriteLine("Invalid date format. Please enter a valid date in MM/DD/YYYY format.");
    }

    Console.WriteLine(); // Optional: Print an empty line for better readability in the loop
}

Console.WriteLine("Program has exited.");
