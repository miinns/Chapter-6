using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ObsoleteAttrApp
{
    [Obsolete("경고, Obsolete Method입니다.")]
    public static void OldMethod()
    {
        Console.WriteLine("In the Old Method ...");
    }
    public static void NormalMethod()
    {
        Console.WriteLine("In the Normal Method ...");
    }
    public static void Main()
    {
        ObsoleteAttrApp.OldMethod();
        ObsoleteAttrApp.NormalMethod();
    }
}