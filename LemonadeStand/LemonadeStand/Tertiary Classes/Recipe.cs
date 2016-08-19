using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Tertiary_Classes
{
    public class Recipe
    {

        Random random;
        int customerPreference;

        public Recipe() //Constructor
        {
            this.random = new Random();
        }

        public void MakeLemonade() //Tested and verified by A. Amini-Hajibashi on 8/19/2016
        {
            customerPreference = random.Next(1, 3);

            if (customerPreference == 1)
            {
                //recipe for sweet

                Console.WriteLine("One sweet glass of lemonade coming up!");
            }
            else if (customerPreference == 2)
            {
                //recipe tart
                Console.WriteLine("One tart glass of lemonade coming up!");
            }
            else
            {
                //recipe for normal
                Console.WriteLine("One normal glass of lemonade coming up!");
            }
        }

        //public void MakeLemonade(Tertiary_Classes.Recipe recipe)
        //{
        //recipe object
        //lemonadeFormala = (3*lemons) + (1*sugar) + (4*ice) //member variables from the store class inserted in 
        //Lemon = Lemon - 3; //lemon variable in inventory reduced by 3 return to player
        //Sugar = sugar - 1;// sugar variable in inventory reduced by 3 return to player
        //Ice = Ice - 4;// ice variable in inventory reduced by 3 return to player
        //return Lemon, sugar, ice
        //Player.Profit += 1 //add 1 lemonade multiplier to profit variable on player object 

        //public void MakeNormalLemonade()
        //{
        //    tartRecipe = 1 lemon + 1 sugar + 1 ice
        //    associate a cashbox (cost)with this recipe
        //    associate inventory with recipe
        //}


        public virtual GetPrice()
        {
            //price = (1 * lemon.GetPrice()) + (0 * sugar.GetPrice()) + (1 * ice.GetPrice());
        }



       

    }
  
}
