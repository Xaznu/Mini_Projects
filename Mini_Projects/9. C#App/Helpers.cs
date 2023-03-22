using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._C_App
{
    public class Helpers
    {
        public int GiveMeNumber()
        {
            SomeStructure structure = new SomeStructure();
        


        int number = 5;

            return number;
        }
}
public enum ItemTypes
{
    Grocery,
    Clothing,
    Electronics
}

public struct SomeStructure
{
    private int numberForStructure;
    private string nameOfStructure;
    public SomeStructure(int number, string name)
    {
        numberForStructure = number;
        nameOfStructure = name;
    }
        
    }
}
}
