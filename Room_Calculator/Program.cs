//METHODS
double GetLengthOfRoom()
{
    double lengthOfRoom;
    while(true)
    {
        Console.WriteLine("Please enter the Length of the room in ft please.");
        
        bool lengthParsed = double.TryParse(Console.ReadLine(), out lengthOfRoom);
        if  (lengthParsed)
        {
            return lengthOfRoom;
            break;
        }
        else
        {
            Console.WriteLine("that is not a valid entry");
        }
    }
}

double GetWidthOfRoom()
{
    double widthOfRoom;
    while (true)
    {
        Console.WriteLine("please enter the width of the room in ft please");

        bool widthParsed = double.TryParse(Console.ReadLine(), out widthOfRoom);
        if (widthParsed)
        {
            return widthOfRoom;
            break;
        }
        else
        {
            Console.WriteLine("that is not a valid entry");
        }
    }
}

double RoomCalculations( out double perimeter)
{
    double width = GetWidthOfRoom();
    double length = GetLengthOfRoom();
    double area = length * width;
     perimeter = (length * 2.0) + (width * 2.0);
    return area;
}

void RoomCalculator()
{
    double perimeterValue;
    double areaValue = RoomCalculations(out perimeterValue);

    if (areaValue <= 250)
    {
        Console.WriteLine($"the room has {areaValue} sqFt so it is small");
    }
    else if (areaValue >= 650) 
    {
        Console.WriteLine($"the room has {areaValue} sqFt so it is large");
    }
    else
    {
        Console.WriteLine($"the roomhas {areaValue} sqFt so it is medium");
    }
}


bool BreakLoop()
{
    Console.WriteLine("Would you like to try again? please enter Yes or Y");
    string tryAgain = Console.ReadLine();
    if (tryAgain.ToLower() != "yes" && tryAgain.ToLower() != "y")
    {
        Console.WriteLine("Goodbye!");
        return false;
    }
    else
    {
        return true;
    }
}

//running program in a loop

while (true)
{
    RoomCalculator();
    bool breakLoop = BreakLoop();
    if(!breakLoop)
    {
        break;
    }
}