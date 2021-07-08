using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exeption_Interceptor
{
    
    public interface IExeptionTrasnlator{
         Exception Translate(Exception exception);
        
        
    }
    public class ExceptionTranslator{
        
        
     
         public Exception Translate(Exception exception)
         {
          vart message=   exception.ExtractFullmessage();
           var ex=Activator.CreateInstance(exception)
             return  ex;
         }
        
    }
    
    
    public class ExecptionInterceptor : IInterceptor
    {
       IExeptionTrasnlator transltor;
    
        public ExecptionInterceptor(ILogger logger,IExeptionTrasnlator transltor){
        
        transltor=transltor;
        
        }
    
        public void Intercept(IInvocation invocation)
        {
            try
            {
            
            invocation.Proceed();
            
            }
            catch((Exception  ex )
            {
            
          var translate=  transltor.trasnlate(ex);
          throw translate;
            
            }
            
        }
    }
}
