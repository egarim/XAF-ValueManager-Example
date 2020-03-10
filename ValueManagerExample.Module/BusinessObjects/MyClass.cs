using System;
using System.Linq;
using DevExpress.Data.Filtering;


namespace ValueManagerExample.Module.BusinessObjects
{

  
    public class MyClass : ICustomFunctionOperator
    {
        static readonly MyClass instance = new MyClass();
        public static void Register()
        {
            CriteriaOperator.RegisterCustomFunction(instance);
        }
        public static bool Unregister()
        {
            return CriteriaOperator.UnregisterCustomFunction(instance);
        }
        public MyClass()
        {

        }

        public string Name => nameof(MyClass);

        public object Evaluate(params object[] operands)
        {
            //DateTimeOffset dto = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            DateTimeOffset dto = new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, TimeSpan.Zero);
            return dto.ToUnixTimeSeconds();

        }

        public Type ResultType(params Type[] operands)
        {
            return typeof(int);
        }
    }
}