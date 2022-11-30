using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyAttrAttribute : Attribute
{ 
    public MyAttrAttribute(string message)
    { 
        this.message = message;
    }
    private string message; 
    public string Message
    { 
        get { return message; }
    }
}
[MyAttr("This is Attribute test.")]
class MyAttributeApp
{
    public static void Main()
    {
        Type type = typeof(MyAttributeApp);
        object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
        if (arr.Length == 0)
            Console.WriteLine("This class has no custom attrs.");
        else
        {
            MyAttrAttribute ma = (MyAttrAttribute)arr[0];
            Console.WriteLine(ma.Message);
        }
    }
}
