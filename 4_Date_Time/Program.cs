// Date

using Microsoft.VisualBasic;
using System.Reflection.PortableExecutable;

DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime current = DateTime.Now;
Console.WriteLine(current);

String date = current.ToShortDateString();
Console.WriteLine(date);

String Time = current.ToShortTimeString();
Console.WriteLine(Time);

String format = current.ToString("dd MMMM yyyy");
Console.WriteLine(format);

String format1 = current.ToString("MM/dd/yyyy");
Console.WriteLine(format1);



