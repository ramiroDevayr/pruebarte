using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaPantalla
{
    public interface IEmail
    {
        void EnviarEmail(string manda, string recibe, string asunto, string cuerpo);
    }
}
