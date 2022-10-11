// See https://aka.ms/new-console-template for more information
Console.WriteLine("Luhn Algorithm");

long creditCardNumber;

do
{


    do
    {
    Console.WriteLine("Enter Card Number: ");
    creditCardNumber = Convert.ToInt64(Console.ReadLine());
}
while (creditCardNumber <= 0);

long ccTest = creditCardNumber;

long sum = 0;
long count = 0;
long divisor = 10;
//string result;


while (ccTest > 0)
{
    long lastDigit = ccTest % 10;
    sum = sum + lastDigit;
    ccTest = ccTest / 100;
}

ccTest = creditCardNumber / 10;

while (ccTest > 0)
{
    long lastDigit = (ccTest) % 10;
    long timesTwo = lastDigit * 2;
    sum = sum + (timesTwo % 10) + (timesTwo / 10);
    ccTest = ccTest / 100;
}

// length of the number / digit count
ccTest = creditCardNumber;
while (ccTest != 0)
{
    ccTest = ccTest / 10;
    count++;
}

// divisor
for (int i = 0; i < count - 2; i++)
{
    divisor = divisor * 10;
}

long firstDigit = creditCardNumber / divisor;
long firstTwoDigits = creditCardNumber / (divisor / 10);

// final checks
if (sum % 10 == 0)
{
    if (firstDigit == 4 && (count == 13 || count == 16))
    {
        Console.WriteLine("Card Type: VISA");
    }
    else if ((firstTwoDigits == 34 || firstTwoDigits == 37) && count == 15)
    {
        Console.WriteLine("Card Type: AMEX");
    }
    else if ((50 < firstTwoDigits && firstTwoDigits < 56) && count == 16 ||firstTwoDigits== 22 && count==16 )
    {
        Console.WriteLine("Card Type: MASTERCARD");
    }
    else if (firstTwoDigits == 35 && count == 16)
    {
        Console.WriteLine("Card Type: JB");
    }
    else if (firstTwoDigits == 60 && count == 16 || firstTwoDigits == 60 && count == 15) 
    {
        Console.WriteLine("Card Type: Discover");

    }
    else if(firstTwoDigits == 30 && count ==14)
    {
        Console.WriteLine("Card Type: Diners Club");

    }
    else
    {
        Console.WriteLine("INVALID");
    }
}
else
{
    Console.WriteLine("INVALID");
}

Console.WriteLine("Card Number: " + creditCardNumber);

  
} while (true);