using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise2
{
    class Helper
    {
        public static bool IsInvalid(string[] exactPostTime, string[] showPostTime)
        {
            for (int i = 0; i < exactPostTime.Length; i++)
            {
                for (int j = i + 1; j < exactPostTime.Length; j++)
                {
                    if (exactPostTime[i] == exactPostTime[j])
                    {
                        if (showPostTime[i] != showPostTime[j])
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
