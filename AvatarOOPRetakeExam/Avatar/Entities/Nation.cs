
using System.Collections.Generic;
using System.Text;

public class Nation
{
    private List<Bender> type;
    public Nation()
    {
        this.Type = new List<Bender>();
    }

    public List<Bender> Type
    {
        get { return this.type; }
        set { this.type = value; }
    }


}

