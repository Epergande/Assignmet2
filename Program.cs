
﻿// ask for input
Console.WriteLine("Enter 1 to create data file.");
Console.WriteLine("Enter 2 to parse data.");
Console.WriteLine("Enter anything else to quit.");
// input response
string? resp = Console.ReadLine();

if (resp == "1")
{
    // create data file

    // ask a question
    Console.WriteLine("How many weeks of data is needed?");
    // input the response (convert to int)
    int weeks = Convert.ToInt32(Console.ReadLine());
    // determine start and end date
    DateTime today = DateTime.Now;
    // we want full weeks sunday - saturday
    DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
    // subtract # of weeks from endDate to get startDate
    DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));
    // random number generator
    Random rnd = new();
    // create file
    StreamWriter sw = new("data.txt");

    // loop for the desired # of weeks
    while (dataDate < dataEndDate)
    {
        // 7 days in a week
        int[] hours = new int[7];
        for (int i = 0; i < hours.Length; i++)
        {
            // generate random number of hours slept between 4-12 (inclusive)
            hours[i] = rnd.Next(4, 13);
        }
        // M/d/yyyy,#|#|#|#|#|#|#
        Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
        // Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
        sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
        // add 1 week to date
        dataDate = dataDate.AddDays(7);
    }
    sw.Close();
}




else if (resp == "2")
{
    List<string> dates = new List<string>();
    List<string> hours = new List<string>();
    string file = "data.txt";

    StreamReader reader = new StreamReader(file);
    string? line = reader.ReadLine();

while(line != null)
{
    string[] splitdate = line.Split(',');
    string[] date = line.Split('/');
    string[] splithour = line.Split('|');
    Console.WriteLine("Week of {0:MMM},{1:dd},{2:yyyy}",date[0],date[1],date[2]);
    Console.WriteLine("Week of {0:MMM} {1:dd} {2:yyyy}",date[0],date[1],date[2]);
    Console.WriteLine("Su  Mo  Tu  We  Th  Fr  Sa");
    Console.WriteLine("--  --  --  --  --  --  --");
    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}\n",splithour[0],splithour[1],splithour[2],splithour[3],splithour[4],splithour[5],splithour[6]);
    line = reader.ReadLine();

}

‎data.txt

        } 

} 

 
