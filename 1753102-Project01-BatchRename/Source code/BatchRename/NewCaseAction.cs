using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    class NewCaseAction : IAction
    {
        // implement interface
        public string ClassName => "NewCaseAction";

        public List<string> KeyWord
        {
            get
            {
                List<string> result = new List<string>();
                result.Add(ClassName);
                result.Add(Case);

                return result;
            }
        }

        public string Description => $"Make string {Case}";

        public IAction Create(List<string> arguments)
        {

            IAction result = null;

            if (arguments != null && arguments.Count >= 1)
            {
                result = new NewCaseAction()
                {
                    Case = arguments[0]
                };
            }


            return result;
        }

        public string Process(string inputString, bool isFilename)
        {
            // get arguments


            // split
            string name = inputString;
            string extension = "";
            if (isFilename)
            {
                name = Path.GetFileNameWithoutExtension(inputString);
                extension = inputString.Remove(0, name.Length);
            }

            // process
            name = makeStringCase[caseIndex](name);

            // combine and return
            string result = name + extension;
            return result;
        }


        // arguments

        /// <summary>
        /// new case: uppercase, lowercase or capitalizedcase
        /// </summary>
        public string Case
        {
            get => newCase;
            set
            {
                if (value.ToLower() == NewCaseAction.Uppercase.ToLower())
                {
                    caseIndex = 0;
                    newCase = Uppercase;
                }
                else if (value.ToLower() == NewCaseAction.Lowercase.ToLower())
                {
                    caseIndex = 1;
                    newCase = Lowercase;
                }
                else if (value.ToLower() == NewCaseAction.Capitalizedcase.ToLower())
                {
                    caseIndex = 2;
                    newCase = Capitalizedcase;
                }
            }
        }


        // attributes
        private string newCase;

        private int caseIndex = 0;

        private StringProcess.TypeStringProcess[] makeStringCase =
            new StringProcess.TypeStringProcess[]
            {
                StringProcess.MakeStringUpper,
                StringProcess.MakeStringLower,
                StringProcess.MakeStringCapitalized,

            };

        // static values
        public static string Uppercase => "Uppercase";
        public static string Lowercase => "Lowercase";
        public static string Capitalizedcase => "Capitalizedcase";


    }
}
