using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------Starting with option 2---------------------
//Write your parent classes first.These will be the classes you will 
//subclass to create the appropriate objects.For example, you might 
//have a personnel class, a weapons class, a missions class, and a 
//vehicles class.
//-----------------------------------------------------------------

//----------------------------Second Part--------------------------
//If you chose to implement Option 1 in the first part, implement 
//Option 2 in in this part.If you chose to implement Option 2 in the
//first part, in this part, implement the appropriate subclasses. 
//For example, if one of your parent classes is Weapon, in this
//class you may elect to implement SmallCaliberWeapon,
//IndirectFireWeapon, and DirectFireWeapon.
//-----------------------------------------------------------------

//----------------------------Third part---------------------------
//If you chose to implement Option 2 in the first part, in this part 
//implement the appropriate methods as virtual and overidden methods,
//or use another suitable technique.As an example, if you have a method
//named mount(), it will exhibit different behavior depending on whether 
//it's called on a type RifleSight or a type Helicopter. As another example,
//if you have a method named load(), it will exhibit different behavior
//depending on whether it's called on a type AutomaticWeapon or a type
//Howitzer. Otherwise, implement your subclasses.
//-----------------------------------------------------------------

//--------------------------Finally block--------------------------
//If you chose to implement Option 2 in the first part, in this part 
//implement Option 1 in this part.Otherwise, implement the methods as 
//instructed for the third part. Note that you may chose to implement
//the main class first and the data type classes second, or the data
//type classes first and the main class second. In both cases, you need
//a main class to instantiate objects of the data types you create and
//exercise the methods of those data types.Generally most developers will
//implement the data types first and the main class second. Doing it the 
//other way is part of a discipline called test-driven development, and 
//is associated with agile techniques.Regardless of what you choose, you
//should be familiar with both processes.
//-----------------------------------------------------------------

namespace Military_Units
{
    class Infantry : Personnel
    {
        public Infantry()
        {
            unitType = "Infantry";
            health = 50;
            attackPower = 3;
            weapon = Weapons.Rifle;
            status = "Alive";

            attackPower += (int)weapon;
        }

        public override void attack()
        {
            Console.WriteLine($"{unitType} fires their rifle and deals {attackPower}.");
        }
    }

    class Radioman : Personnel
    {
        protected bool comm = true;

        public Radioman()
        {
            unitType = "Radio Operator";
            health = 45;
            attackPower = 3;
            weapon = Weapons.Pistol;
            status = "Alive";

            attackPower += (int)weapon;
        }

        public override void die()
        {
            base.die();
            comm = false;
        }
    }

    class Corpsman : Personnel
    {
        public bool healing = true;

        public Corpsman()
        {
            unitType = "Corpsman";
            health = 40;
            attackPower = 2;
            weapon = Weapons.Rifle;
            status = "Alive";

            attackPower += (int)weapon;
        }

        public override void die()
        {
            base.die();
            healing = false;
        }
    }

    class Tank : Vehicle
    {
        public Tank()
        {
            unitType = "Tank";
            status = "Functioning";
            health = 500;
            attackPower = 35;
        }
    }
}
