using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Pokemon
{
    public int strength;

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value.ToUpper();
        }
    }
}

