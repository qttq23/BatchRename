using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    class ReplaceAction : IAction
    {
        // implement interface
        public string ClassName => "ReplaceAction";

        public List<string> KeyWord
        {
            get
            {
                List<string> result = new List<string>();
                result.Add(ClassName);
                result.Add(Needle);
                result.Add(Hammer);
                result.Add(Area);

                return result;
            }
        }

        public string Description => $"Replace '{Needle}' with '{Hammer}' in {Area}";

        public IAction Create(List<string> arguments)
        {
            IAction result = null;
            if (arguments != null && arguments.Count >= 3)
            {
                result = new ReplaceAction()
                {
                    Needle = arguments[0],
                    Hammer = arguments[1],
                    Area = arguments[2]
                };
            }

            return result;
        }

        public string Process(string inputString, bool isFilename)
        {
            // get arguments
            string needle = this.Needle;
            string hammer = this.Hammer;
            string area = this.Area;

            // split name and extension
            string name = inputString;
            string extension = "";
            if (isFilename)
            {
                name = Path.GetFileNameWithoutExtension(inputString);
                extension = inputString.Remove(0, name.Length);
            }

            // process
            if (isFilename && area == ReplaceAction.ExtensionArea)
            {
                extension = StringProcess.ReplaceString(extension, needle, hammer);
            }
            else
            {
                name = StringProcess.ReplaceString(name, needle, hammer);
            }

            // conbine and return
            string result = name + extension;
            return result;
        }


        // arguments

        /// <summary>
        /// string to be replaced
        /// </summary>
        public string Needle { get; set; } = "";

        /// <summary>
        /// string replaced to
        /// </summary>
        public string Hammer { get; set; } = "";

        /// <summary>
        /// filename have two area: name and extension
        /// </summary>
        public string Area { get; set; } = ReplaceAction.NameArea;


        // static values
        public static string NameArea => "Name";

        public static string ExtensionArea => "Extension";
    }
}
