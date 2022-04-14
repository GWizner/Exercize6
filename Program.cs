// See https://aka.ms/new-console-template for more information
string y = "y";
string yes = "yes";
string no = "no";
string n = "n";
string userAns;

begin:
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to cointinue (y/n)?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();
    if (userAns == n || userAns == no)
        goto end;
   
}
while (userAns == y || userAns == yes);

Console.WriteLine("I do not recognize your input.");
Console.WriteLine();
goto begin;

end:
Console.WriteLine("Goodbye.");
    



