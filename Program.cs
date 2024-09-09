double COST_OF_SANDWICH = 4.75;
double COST_OF_TOPPING = 0.55;
double DISCOUNT_AMOUNT = 0.10;

double totalSandwichCost;
double totalToppingCost;
double baseCost;

System.Console.WriteLine("How many sandwiches are you buying today?");
int numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like?");
int numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter your tip");
double tip = double.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

System.Console.WriteLine("Your total order comes out to $" +orderCost);