using System;
string i = "hhh";
Console.WriteLine(DateTime ToDateTime(i) is DateTime);  // output: True

object iBoxed = i;
Console.WriteLine(iBoxed is DateTime);  // output: True
Console.WriteLine(iBoxed is long);  // output: False