using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Recipe
{
    class Recipe
    {

        //member variabes - lemon (object), sugar (object), Ice (object)
        //member methods - .MakeLemonade ()
        Lemon lemon = new Lemon;
        Sugar sugar = new Sugar;
        Ice ice = new Ice;
        int lemonade;
    }
    public CheckInventory()
    {
        //check inventory for 3 lemon, 1 sugar, 4 ice prior to makelemonade
        //if there is 3 lemon, 1 sugar, 4 ice run MakeLemonade method
        //if there is not enough lemons return "purchase more lemons" and return available money
        //if there is not enough sugar return "purchase more sugar" and return available money
    }
    //public void MakeLemonade()
    //{
    //    //lemonadeFormala = (3*lemons) + (1*sugar) + (4*ice) //member variables from the store class inserted in 
    //    Lemon = Lemon - 3; //lemon variable in inventory reduced by 3 return to player
    //    Sugar = sugar - 1;// sugar variable in inventory reduced by 3 return to player
    //    Ice = Ice - 4;// ice variable in inventory reduced by 3 return to player
    //    return Lemon, sugar, ice
    //Player.Profit +=1 //add 1 lemonade multiplier to profit variable on player object 
        
    //}

}
