// start main

Console.ForegroundColor = ConsoleColor.DarkCyan;
DisplayMenu();
Random random = new Random();
int randomRows = random.Next(10,21);
string userChoice = GetUserChoice();
while (userChoice !="4"){
    RouteEm(userChoice, randomRows);
    DisplayMenu();
    userChoice= GetUserChoice();
}

// end main

static void DisplayMenu(){ //menu display
    Console.Clear();
    Console.WriteLine("1. unit conversion\n2. rock classification\n3. lunch break\n4. exit");
}

static string GetUserChoice(){ //collects menu choice for next few methods
    return Console.ReadLine();
}

static void RouteEm(string userInput, int randomRows){ //method routes user to their selected menu
    switch (userInput){
        case "1":
            UnitConvert();
            break;
        case "2":
            ClassyRock();
            break;
        case "3":
            CheeseZa(randomRows);
            break;
        default: 
            BadInput();
            break;
    }
}

static void CheeseZa(int randomRows){ //method used after user selects "3" for lunch
    Console.WriteLine("you chose lunch break!\nhere is a cheese pizza from the breakroom");
    for(int i=randomRows; i>=0; i--){
            for(int j=0; j<i+1; j++){
                if(i==randomRows|| i==0 || j==0 || j==i){
                    Console.Write("*");
                }
                else {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    Pause();
}

static void UnitConvert(){ //routes user to the type of conversion they select here
    Console.Clear();
    Console.WriteLine("you chose the unit conversion menu option");
    Console.WriteLine("1. length\n2. mass\n3. temperature\n4. exit");
    int typeChoice = int.Parse(Console.ReadLine());
        if (typeChoice == 1){
            ConvertLength();
        }
        else if (typeChoice == 2){
            ConvertMass();
        }   
        else if (typeChoice == 3){
            ConvertTemp();
        }       
    Pause();
}

static void ConvertLength(){ //prompts user to select fromUnit and toUnit for length and calculate
    Console.Clear();
    Console.WriteLine("enter the unit you want to convert from: mm, cm, km, meters, inches, yards or miles?");
    string fromUnit = Console.ReadLine();
    Console.WriteLine("enter the unit you want to convert to: mm (from in), cm (from in), km (from miles), meters (from yards)\nyards (from meters), miles (from km), or inches (from cm or mm)");
    string toUnit = Console.ReadLine();
    double answer = 0;
        if (fromUnit == "yards"){
            Console.WriteLine("enter number of yards to convert to meters");
            int yards = int.Parse(Console.ReadLine());
            answer = yards / 1.0936;        
        }
        else if (fromUnit == "miles"){
            Console.WriteLine("enter number of miles to convert to km");
            int miles = int.Parse(Console.ReadLine());
            answer = miles / 0.6214;
        }
        else if (fromUnit == "inches"){
            Console.WriteLine("would you like to convert to cm or mm?");
            string inchChoice = Console.ReadLine();
            if (inchChoice == "cm"){
                Console.WriteLine("enter number of inches to convert to cm");
                int inches1 = int.Parse(Console.ReadLine());
                answer = inches1 / 0.3937;
            }
            else if (inchChoice == "mm"){
                Console.WriteLine("enter number of inches to convert to mm");
                int inches2 = int.Parse(Console.ReadLine());
                answer = inches2 / 0.03937;
            }
        }
        else if (fromUnit == "meters"){
            Console.WriteLine("enter number of meters to convert to yards");
            int meters = int.Parse(Console.ReadLine());
            answer = meters * 1.0936;
        }
        else if (fromUnit == "km"){
            Console.WriteLine("enter number of km to convert to miles");
            int km = int.Parse(Console.ReadLine());
            answer = km * 0.6214;
        }
        else if (fromUnit == "mm"){
            Console.WriteLine("enter number of mm to convert to inches");
            int mm = int.Parse(Console.ReadLine());
            answer = mm * 0.03937;
        }
        else if (fromUnit == "cm"){
            Console.WriteLine("enter number of cm to convert to inches");
            int cm = int.Parse(Console.ReadLine());
            answer = cm * 0.3937;
        }
        else{
            BadInput();
            return;
        }
    Console.WriteLine($"{fromUnit} to {toUnit} is {answer}");
}

static void ConvertMass(){ //prompts user to select fromUnit and toUnit for mass and calculate
    Console.Clear();
    Console.WriteLine("enter the unit you want to convert from: grams (to oz), kilograms (to lbs), lbs (to kilograms), or oz (to grams)");
    string fromUnit = Console.ReadLine();
    Console.WriteLine("enter the unit you want to convert to: grams (from oz), kilograms (from lbs), lbs (from kilometers), oz (from grams)");
    string toUnit = Console.ReadLine();
    double answer = 0;
        if (fromUnit == "grams"){
            Console.WriteLine("enter number of grams to convert to oz");
            int grams = int.Parse(Console.ReadLine());
            answer = grams * 0.353;
        }
        if (fromUnit == "oz"){
            Console.WriteLine("enter number of oz to convert to grams");
            int oz = int.Parse(Console.ReadLine());
            answer = oz / 0.353;
        }
        if (fromUnit == "kilograms"){
            Console.WriteLine("enter number of kilograms to convert to lbs");
            int kilograms = int.Parse(Console.ReadLine());
            answer = kilograms * 2.2046;
        }
        if (fromUnit == "lbs"){
            Console.WriteLine("enter number of lbs to convert to kilograms");
            int lbs = int.Parse(Console.ReadLine());
            answer = lbs / 2.2046;
        }
    Console.WriteLine($"{fromUnit} to {toUnit} is {answer}");
}

static void ConvertTemp(){ //prompts user to select fromUnit and toUnit for temp and calculate
    string toUnit = "";
    Console.WriteLine("you can use this menu to convert celcius temperature to fahrenheit, type celcius or fahrenheit to continue: ");
    string fromUnit = Console.ReadLine();
    Console.WriteLine("enter the temperature to convert: ");
    int amount = int.Parse(Console.ReadLine());
    double result = 0;
        if (fromUnit == "celcius"){
            result = (amount * 9.0 / 5.0) + 32;
            toUnit = "fahrenheit";
            Console.WriteLine($"{amount} {fromUnit} = {result} {toUnit}");
        }
        else if (fromUnit == "farenheit" ){
            result = (amount-32) * 5.0 / 9.0;
            toUnit = "celcius";
            Console.WriteLine($"{amount} {fromUnit} = {result} {toUnit}");
        }
}

static void ClassyRock(){ //method for asking users questions regarding the sample and calculating the point total
    int numRock = 0;
    Console.WriteLine("you chose the rock classification menu option");
    Console.WriteLine("how many identical rock samples were found");
    numRock = int.Parse(Console.ReadLine());
    double rockPoints = numRock*4.5;
    Console.WriteLine("transport rock? (enter answer as yes or no)");
    string transport = Console.ReadLine();
        if (transport == "yes"){
            rockPoints = rockPoints + 7.3 * numRock;
        }
        else if (transport == "no"){
            rockPoints = rockPoints + 0;            
        }
        else {
            BadInput();     
        }
    Console.WriteLine("what is the surface temperature of the rock sample in degrees celcius?");
    double temp = double.Parse(Console.ReadLine());
        if (temp<0){
            rockPoints = rockPoints + numRock* 9.2;
        }
    Console.WriteLine("how much does the rock sample weigh in kilograms to the nearest kilogram?");
    int weight = int.Parse(Console.ReadLine());
        if (weight>25){
        rockPoints = rockPoints * 1.17;
    }
    Console.WriteLine($"the total point value for this sample is {rockPoints}");
    Console.WriteLine("would you like to edit this point total? (enter answer as yes or no)");
    string pointChange = Console.ReadLine();
        if (pointChange == "yes"){
            AdjustPoints(ref rockPoints);
        }
        else if (pointChange == "no"){
            Console.WriteLine($"your final point value for this sample is {rockPoints}");
        }
        else{
            BadInput();
        }
        Pause();
}

static void AdjustPoints(ref double points){ //method for adding or subtracting points from the classyrock total
    double adjustment;
    bool loop = true;
    string choice = "";
    while (loop){ // start while loop for point adjust
        Console.WriteLine("enter the point value you'd like to adjust by (positive or negative value): ");
        if (double.TryParse(Console.ReadLine(), out adjustment)){
            if (Math.Abs(adjustment) <= points){
                points += adjustment;
                Console.WriteLine($"the updated point value is: {points}");
            }
            else{
            Console.WriteLine("the adjustment cannot be greater than the original point value. try again.");
            }
        }
        else{
            Console.WriteLine("invalid input. enter a valid number.");
        }
    Console.WriteLine($"your final point total for the sample is {points}");
    Console.WriteLine("are you satisfied with rock points (enter yes or no)");
    choice = Console.ReadLine();
    if (choice == "yes"){
        loop = false;
    }
    } //end while loop point adjust
    Pause();
} 

static void BadInput(){ //used throughout to let users know they did not input the correct type
    Console.WriteLine("invalid menu choice");
    DrawBunny();
    Pause();
}

static void Pause(){ //used to end each section and prompt user back to the initial menu
    Console.WriteLine("press any key to continue");
    Console.ReadKey();
}

static void DrawBunny(){ //bunny drawing method
    Console.Clear();
    Console.WriteLine("        (\\_/)");
    Console.WriteLine("        (o.o)");
    Console.WriteLine("        (> <)");
    Console.WriteLine("       try again!");
}

