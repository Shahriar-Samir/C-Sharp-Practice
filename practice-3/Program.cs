static double Substraction(string a, string b){
   double num1 = Convert.ToDouble(a);
   double num2 = Convert.ToDouble(b);
    return num1-num2;
}

Console.WriteLine("Enter a");
string a = Console.ReadLine();
Console.WriteLine("Enter b");
string b = Console.ReadLine();

Console.WriteLine(Substraction(a, b));
