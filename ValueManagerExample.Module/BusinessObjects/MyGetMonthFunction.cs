using System;
using System.Linq;

namespace ValueManagerExample.Module.BusinessObjects
{

    using DevExpress.Data.Filtering;
    using DevExpress.Xpo.DB;
    using System;
    public class MyGetMonthFunction : ICustomFunctionOperatorFormattable
    {
        #region ICustomFunctionOperatorFormattable Members
        // The function's expression to be evaluated on the server.
        string ICustomFunctionOperatorFormattable.Format(Type providerType, params string[] operands)
        {
            // This example implements the function for MS Access databases only.
            //if (providerType == typeof(AccessConnectionProvider))
            //    return string.Format("datepart(\"m\", {0})", operands[0]);
            
            throw new NotSupportedException(string.Concat(
                "This provider is not supported: ", providerType.Name));
        }

        public static int MyGetMonth(DateTime date)
        {
            return date.Month;
        }
        #endregion

        #region ICustomFunctionOperator Members
        // Evaluates the function on the client.
        object ICustomFunctionOperator.Evaluate(params object[] operands)
        {
            return MyGetMonth((DateTime)operands[0]);
        }

        string ICustomFunctionOperator.Name
        {
            get { return nameof(MyGetMonth); }
        }

        Type ICustomFunctionOperator.ResultType(params Type[] operands)
        {
            return typeof(int);
        }
        #endregion
    }
}