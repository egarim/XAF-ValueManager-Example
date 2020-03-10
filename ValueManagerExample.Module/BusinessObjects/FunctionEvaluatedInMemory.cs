using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueManagerExample.Module.BusinessObjects
{
    public class FunctionEvaluatedInMemory : ICustomFunctionOperator
    {

        static readonly FunctionEvaluatedInMemory instance = new FunctionEvaluatedInMemory();
        public static void Register()
        {
            CriteriaOperator.RegisterCustomFunction(instance);
        }
        public static bool Unregister()
        {
            return CriteriaOperator.UnregisterCustomFunction(instance);
        }

        public string Name => nameof(FunctionEvaluatedInMemory);

        public object Evaluate(params object[] operands)
        {
            return MainValueManager.CurrentUser;
        }

        public Type ResultType(params Type[] operands)
        {
            return typeof(string);
        }
    }
}
