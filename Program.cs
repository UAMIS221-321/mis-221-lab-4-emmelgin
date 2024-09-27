// start main
DisplayMenu();
Random random = new Random();
int randomRows = random.Next(8,13);
string userChoice = GetUserChoice();
while (userChoice !="4"){ 
    RouteEm(userChoice, randomRows);
    DisplayMenu();
    userChoice= GetUserChoice();
}
// end main

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Welcome to my PIZZA PALACE! Choose a pizza option below");
    Console.WriteLine("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. No Pizza");
}

static void RouteEm(string userChoice, int randomRows){
    switch (userChoice){
        case "1":
            PlainZa(randomRows);
            break;
        case "2":
            CheeseZa(randomRows);
            break;
        case "3":
            PepZa(randomRows);
            break;
        default: 
            BadInput();
            break;
    }
}

static void PlainZa(int randomRows){
        for(int i=0; i<randomRows +1; i++){
            for(int j=0; j<randomRows-i-1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    Pause();
}

static void CheeseZa(int randomRows){
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

static void PepZa(int randomRows){
    Random random = new Random();
    int randomPep = random.Next(1,13);
    for(int i=randomRows; i>=0; i--){
            for(int j=0; j<i+1; j++){
                if(i==randomRows|| i==0 || j==0 || j==i){
                    Console.Write("*");
                }
                else if (i==randomPep || j==randomPep){
                    randomPep = randomPep/2;
                    Console.Write("[]");
                }
                else {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    Pause();
}
    
static string GetUserChoice(){
    return Console.ReadLine();
}

static void BadInput(){
    Console.WriteLine("Invalid menu choice");
    Pause();
}

static void Pause(){
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}
