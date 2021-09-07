using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class RunFunction
    {
        public static GenericResponse<T> Run<T>(Func<T> body)
        {
            try
            {
                var result = body();
                return new GenericResponse<T>(result);
            }
            catch (DivideByZeroException ex)
            {
                return new GenericResponse<T>(ex, "Se intenta realizar una división por cero");
            }
            catch (ArithmeticException ex)
            {
                return new GenericResponse<T>(ex, "Se presenta un error aritmético");
            }
            catch (NullReferenceException ex)
            {
                return new GenericResponse<T>(ex);
            }
            catch (ArgumentException ex)
            {
                return new GenericResponse<T>(ex);
            }
            catch (Exception ex)
            {
                return new GenericResponse<T>(ex);
            }
        }
    }
}
