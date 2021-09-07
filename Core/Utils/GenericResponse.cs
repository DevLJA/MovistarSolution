using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public class GenericResponse<T>
    {
        public T Result { get; set; }
        public bool Successful { get; set; }
        public Exception Error { get; set; }

        public GenericResponse(T result)
        {
            Successful = true;
            Result = result;
        }

        public GenericResponse(Exception error)
        {
            Successful = false;
            Error = error;
        }
        public GenericResponse(Exception error, string text)
        {
            Successful = false;
            Error = new Exception(text, error);
        }
    }
}
