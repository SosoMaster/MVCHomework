using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumb_Password_Generator.Models
{
    public class PasswordGeneratorResult
    {
        public List<string> Passwords { get; }

        public PasswordGeneratorResult()
        {
            Passwords = new List<string>();
        }
    }
}
