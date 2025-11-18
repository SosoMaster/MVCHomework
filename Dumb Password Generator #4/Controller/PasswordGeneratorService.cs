using Dumb_Password_Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumb_Password_Generator.Controller
{
    public class PasswordGeneratorService
    {
        public PasswordGeneratorResult Generate(PasswordGeneratorInput input)
        {
            var result = new PasswordGeneratorResult();

            int n = input.N;
            int l = input.L;

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (char c1 = 'a'; c1 < 'a' + l; c1++)
                    {
                        for (char c2 = 'a'; c2 < 'a' + l; c2++)
                        {
                            for (int d3 = 1; d3 <= n; d3++)
                            {
                                if (d3 > d1 && d3 > d2)
                                {
                                    string pass = $"{d1}{d2}{c1}{c2}{d3}";
                                    result.Passwords.Add(pass);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
