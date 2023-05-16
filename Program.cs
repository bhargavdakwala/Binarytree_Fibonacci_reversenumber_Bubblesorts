// See https://aka.ms/new-console-template for more information

    // Array of integers
    int[] intArray = new int[] {9,2,4,3,1,5};
    Console.WriteLine("Original array");
    foreach (int i in intArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    // Sort array in ASC order
    Console.WriteLine("Sorted array in ASC order");
    Array.Sort(intArray);
    foreach (int i in intArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Sorted array in DESC order");
    // Sort Array in DESC order
    Array.Reverse(intArray);
    foreach (int i in intArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();


/// Bubble sorts

int[] arr = new[] { 99, 12, 11, 300, 400, 10, 9, 3, 6, 5, 7, 8 };

int temp = 0;

for (int write = 0; write < arr.Length; write++)
{
    for (int sort = 0; sort < arr.Length - 1 - write; sort++)
    {
        if (arr[sort] > arr[sort + 1])
        {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}   
Console.WriteLine("Bubble sorts");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}


/// reverse a string  in C#. 
/// 
string str = "", reverse = "";
int Length = 0;
Console.WriteLine("Enter a Word");
//Getting String(word) from Console  
str = Console.ReadLine();
//Calculate length of string str  
Length = str.Length - 1;
while (Length >= 0)
{
    reverse = reverse + str[Length];
    Length--;
}
//Displaying the reverse word  
Console.WriteLine("Reverse word is {0}", reverse);
Console.ReadLine();

/// reverse a number in C#. 

Console.WriteLine("Enter a No. to reverse");
int Number = int.Parse(Console.ReadLine());
int Reverse = 0;
while (Number > 0)
{
    int remainder = Number % 10;
    Reverse = (Reverse * 10) + remainder;
    Number = Number / 10;
}
Console.WriteLine("Reverse No. is {0}", Reverse);
Console.ReadLine();


//Calculate Fibonacci Series 
int len = 10;
int a = 0, b = 1, c = 0;
Console.Write("{0} {1}", a, b);
for (int i = 2; i < len; i++)
{
    c = a + b;
    Console.Write(" {0}", c);
    a = b;
    b = c;
}


/// Binary tree
/// 

int[] numArray = new int[100];
bool isNum = false;
int sizeNum;
Console.WriteLine("Enter the limit of array:");
string sizeString = Console.ReadLine();
isNum = Int32.TryParse(sizeString, out sizeNum);
if (isNum)
{
    Console.WriteLine("Enter array values (numeric only) in ascending order. ");
    for (int i = 0; i < sizeNum; i++)
    {
        int tempValue;
        string arrayItem = Console.ReadLine();
        isNum = Int32.TryParse(arrayItem, out tempValue);
        if (isNum)
        {
            numArray[i] = tempValue;
        }
        else
        {
            Console.WriteLine("You enters a non-numeric value!");
            break;
        }
    }
    Console.WriteLine("Enter search value (numeric only).");
    int searchNum;
    string searchString = Console.ReadLine();
    isNum = Int32.TryParse(searchString, out searchNum);
    if (isNum)
    {
        int lowNum = 0;
        int highNum = sizeNum - 1;
        while (lowNum <= highNum)
        {
            int midNum = (lowNum + highNum) / 2;
            if (searchNum < numArray[midNum])
            {
                highNum = midNum - 1;
            }
            else if (searchNum > numArray[midNum])
            {
                lowNum = midNum + 1;
            }
            else if (searchNum == numArray[midNum])
            {
                Console.WriteLine("Search successful");
                Console.WriteLine("Value {0} found at location {1}\n", searchNum, midNum + 1);
                Console.ReadLine();
                return;
            }
        }
        Console.WriteLine("Value {0} was not found \n", searchNum);
        Console.ReadLine();
        return;
    }
    else
    {
        Console.WriteLine("Search value must be numeric!");
        Console.ReadLine();
        return;
    }
}
else
{
    Console.WriteLine("You must enter a numeric value!");
    Console.ReadLine();
}
Console.ReadLine();
  