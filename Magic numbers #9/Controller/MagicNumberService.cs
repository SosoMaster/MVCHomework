using Magic_Numbers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers.Controller
{
    public class MagicNumberService
    {
        public MagicNumberResult Generate(MagicNumberInput input)
        {
            int target = input.MagicNumber;
            var _results = new List<string>();

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int e = 1; e <= 9; e++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    if (a * b * c * d * e * f == target)
                                    {
                                        _results.Add($"{a}{b}{c}{d}{e}{f}");
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return new MagicNumberResult(_results);
        }
    }
}
