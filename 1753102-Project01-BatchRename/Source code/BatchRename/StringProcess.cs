using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    /// <summary>
    /// static function for processing string
    /// associates with IAction to processing stirng
    /// </summary>
    public static class StringProcess
    {
        public delegate string TypeStringProcess(string inputString);

        static public string MakeStringLower(string inputString)
        {
            return inputString.ToLower();
        }

        static public string MakeStringUpper(string inputString)
        {
            return inputString.ToUpper();
        }

        static public string MakeStringCapitalized(string inputString)
        {
            string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString.ToLower());
            return result;
        }

        static public string MakeStringNormalized(string inputString)
        {
            string result = "";


            // capitalize
            string capitaliedString = StringProcess.MakeStringCapitalized(inputString);

            // split to tokens
            string[] tokens = StringProcess.SplitString(capitaliedString, new string[] { " " });

            // combine all token, one space between each two tokens
            for (int i = 0; i < tokens.Length; i++)
            {
                if (i == tokens.Length - 1)
                    result += tokens[i];
                else
                    result += tokens[i] + " ";
            }


            return result;
        }

        static public string ReplaceString(string inputString, string needle, string hammer)
        {
            string result = inputString.Replace(needle, hammer);

            return result;
        }

        static public string MoveString(string inputString, int startIndex, int length, int indexMoveTo)
        {
            inputString = inputString.TrimStart(' ');
            inputString = inputString.TrimEnd(' ');

            // find first-number-character string
            string part = inputString.Substring(startIndex, length);
            part = " " + part;
            string body = inputString.Substring(length);


            // move to destination
            string result = body.Insert(indexMoveTo, part);
            result = result.TrimStart(' ');
            result = result.TrimEnd(' ');
            return result;
        }

        static public string TransformString(string inputString)
        {
            // generate a GUID
            Guid g = Guid.NewGuid();
            string result = g.ToString();

            return result;
        }

        static public string[] SplitString(string inputString, string[] seperators)
        {
            string[] result = inputString.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        static public string MakeNewFilename(string oldFilename, string difference)
        {
            // get file name without extension
            string extension = Path.GetExtension(oldFilename);
            string result = oldFilename.Insert(oldFilename.Length - extension.Length, difference);

            return result;
        }

        static public string MakeNewFoldername(string oldFoldername, string difference)
        {

            string result = oldFoldername.Insert(oldFoldername.Length, difference);

            return result;
        }
    }
}
