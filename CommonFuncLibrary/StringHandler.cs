using System;

namespace CommonFunctionalityLibrary
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts space before every capital letter
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpacesInProductNames(this string source)  // Extension method
        {
            string result = string.Empty;
            if (!String.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (letter.Equals(' '))
                    {
                        continue;
                    }
                    if (char.IsUpper(letter))
                    {
                        result += " ";              
                    }
                    result += letter;
                }
            }
            return result.Trim();
        }

    }
}
