//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Enter number from 1 to 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int num)
{
	if (num > 0 && num < 8)
  {
 		if (num == 7 || num == 6)
    {
 			Console.Write( num + " - holiday");
    }
 		else
    {
 			Console.Write( num + " - work");
    }
  }
 	else
  {
 		Console.Write("enter a number from 1 to 7");
  }
 	return " day.";
}