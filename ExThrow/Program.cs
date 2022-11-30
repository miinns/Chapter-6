using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class UserException : ApplicationException { }
class UserExThrowApp
{
    static void Method()
    {
        throw new UserException();
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Here: 1");
            Method(); // static 메소드
            Console.WriteLine("Here: 2");
        }
        catch (UserException)
        {
            Console.WriteLine("User-defined Exception");
        }
    }
}