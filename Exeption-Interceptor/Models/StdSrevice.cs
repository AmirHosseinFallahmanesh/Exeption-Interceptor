using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exeption_Interceptor.Models
{
    [Intercept(typeof(ExecptionInterceptor))]
    public class StdSrevice: IStdSrevice
    {
        public void Print()
        {

        }
    }
    public interface IStdSrevice
    {
         void Print();
    }
}
