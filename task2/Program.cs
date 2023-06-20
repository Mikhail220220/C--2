Console.WriteLine("Enter number: ");

    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 99){
        Console.WriteLine("Please enter a three-digit number");
        return;
    }

    else {
        // number = Convert.ToString(Console.ReadLine());
string str = number.ToString();
Console.WriteLine(str[2]);
    }