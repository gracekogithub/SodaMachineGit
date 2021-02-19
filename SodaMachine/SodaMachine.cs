using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A) - "fields"
        private List<Coin> _register;
        private List<Can> _inventory;
        private int coinCount;
        int i = 0;

        public int CoinCount
        {
            get
            {
                return coinCount;
            }
            set
            {
                coinCount = value;
            }
        }

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();        
            _inventory = new List<Can>();

            FillInventory();
            FillRegister();
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.
        public void FillRegister()
        {
            double initalQuarterAmount = 20;
            double initalDimesAmount = 10;
            double initalNickelsAmount = 20;
            double initalPenniesAmount = 50;
            for (int i = 0; i <= initalQuarterAmount; i++)
            {
                Coin quarter = new Coin("quarter", 0.25);
               _register.Add(quarter);

            }
            for (int i = 0; i <= initalDimesAmount; i++)
            {
                Coin dime = new Coin("dime", 0.10);
                _register.Add(dime);
            }
            for (int i = 0; i <= initalNickelsAmount; i++)
            {
                Coin nickel = new Coin("nickel", 0.05);
                _register.Add(nickel);
            }
            for (int i = 0; i <= initalPenniesAmount; i++)
            {
                Coin penny = new Coin("penny", 0.01);
                _register.Add(penny);

            }
            Console.WriteLine($"Soda Machine has total amount of {_register}.");
            
        }
        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory()
        {
            double eachCanSlotSpace = 40;
            for (int i = 0; i < eachCanSlotSpace; i++)
            {
                Can orangeSoda = new Can("orange soda", 0.60);
                Can cola = new Can("cola", 0.50);
                Can rootBeer = new Can("root beer", 0.30);
                _inventory.Add(orangeSoda);
                _inventory.Add(cola);
                _inventory.Add(rootBeer);
            }
            Console.WriteLine($"Soda Machine has total cans of {_inventory}.");
            

        }
        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
            else
            {
                Console.WriteLine("Please step aside to allow another customer to make a selection.");
            }
        }
        
        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {
            //need to get a soda from inventory, that method needs a string, it will return a can.
            string customerCanSelection = UserInterface.SodaSelection(_inventory);
            Can canChoice = GetSodaFromInventory(customerCanSelection);
            List<Coin>chosenCoin = customer.GatherCoinsFromWallet(canChoice);
            CalculateTransaction(chosenCoin, canChoice, customer);
        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string sodaSelection)
        {
            List<Coin> coin =;
            Can chosenCan =;
            UserInterface.CoinSelection(chosenCan, coin);

            return chosenCan;
        }

        //This is the main method for calculating the result of the transaction.
        //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
        //This is the method that will determine the following:
        //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Despense soda, and change to the customer.
        //If the payment is greater than the cost of the soda, but the machine does not have ample change: Despense payment back to the customer.
        //If the payment is exact to the cost of the soda:  Despense soda.
        //If the payment does not meet the cost of the soda: despense payment back to the customer.
        private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
            List<Coin> sodaPrice = ;
            
            UserInterface.DisplayCost(chosenSoda);
            bool coinLeftInRegister = true;
            double changeAmount;
            double priceOfSoda;
            foreach (var coin in payment)
            {
                Console.WriteLine("soda you chose is: "+ chosenSoda + " Insert coins:");
                string userInput = Console.ReadLine();
            }
            
            if (payment > priceOfSoda)
            {
                if (coinLeftInRegister==true)
                {
                   
                    Console.WriteLine("Enjoy your" + chosenSoda);
                    Console.WriteLine("Dispense $"+ changeAmount);
                }
                if(coinLeftInRegister == false)
                {
                    Console.WriteLine("Dispense payment back to the customer");
                }

            }
      
            if (payment == priceOfSoda)
            {
                Console.WriteLine("Dispense soda");
            }
            else 
            {
                Console.WriteLine("Dispense payment back to the customer");
            }
            
        }
        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double changeValue)
        {
            List<Coin> change = new List<Coin>();

            
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
            FillRegister();
            
      
        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            
        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange()
        {
            double change;
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You inserted (this amount)"+ amount);
            double priceOfSoda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("cost of soda is (chosen soda from list)"+ priceOfSoda);
            Console.WriteLine(change=amount-priceOfSoda);

            return change;
            
        }
        //Takes in a list of coins to return the total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
            
            //double x = Convert.ToInt32(Console.ReadLine());
            //double totalCoin = coinCount * _register.Count;
            //return totalCoin;
            
            
        }
        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {
            coins = new List<Coin>();
            
           foreach (var coin in coins)
            {
                Console.WriteLine(coin.Name);
                Console.WriteLine(coin.Value);
            }
        }
    }
}
