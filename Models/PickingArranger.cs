using System.Runtime;

namespace practices_basics.Models
{

    // unsafe variables as any where in code it can be changed;
    // use of getter - setter gives us privacy by encapsulation
    // only using private access modifier will results in variable access
    //propertise have same name , fields
    //get , set accessor 
    //value is a keyword used by the set to assign value into variable
    public class PickingArranger
    {

        private int amount;
        public int Amount
        {
            get { return amount; }
            set
            {

                amount = value;
                
            }

        }

    }
}