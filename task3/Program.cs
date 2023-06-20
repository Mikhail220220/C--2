Console.WriteLine("Enter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <=0 || number > 7 ){
    Console.WriteLine("Enter a number from 1 to 7: ");
    return;
} 
else if (number <= 5)
    Console.WriteLine("This day is not a holiday");
else if (number > 5)
    Console.WriteLine("This day is a holiday");