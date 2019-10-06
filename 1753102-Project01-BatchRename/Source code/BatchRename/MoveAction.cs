using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    class MoveAction : IAction
    {
        // implement interface
        public string ClassName => "MoveAction";

        public List<string> KeyWord =>
            new List<string>() { ClassName, StartAt.ToString(), Length.ToString(), Destination.ToString() };

        public string Description =>
            $"Move {Length.ToString()} character(s) " +
            $"from index {StartAt.ToString()} to the {((Destination == Begin) ? "begin" : "end")}";

        public IAction Create(List<string> arguments)
        {
            IAction result = null;
            if (arguments != null && arguments.Count >= 3)
            {
                int startAt = Int32.Parse(arguments[0]);
                int length = Int32.Parse(arguments[1]);
                int destination = Int32.Parse(arguments[2]);

                result = new MoveAction()
                {
                    StartAt = startAt,
                    Length = length,
                    Destination = destination,
                };

            }

            return result;
        }

        public string Process(string inputString, bool isFilename)
        {
            // get arguments
            int startAt = StartAt;
            int length = Length;
            int destination = Destination;

            // split
            string name = inputString;
            string extension = "";
            if (isFilename)
            {
                name = Path.GetFileNameWithoutExtension(inputString);
                extension = inputString.Remove(0, name.Length);
            }

            // process
            int indexMoveTo = (destination == Begin) ? 0 : name.Length - length;
            name = StringProcess.MoveString(name, startAt, length, indexMoveTo);

            // combine and return
            string result = name + extension;
            return result;
        }

        // arguments

        /// <summary>
        /// index start at
        /// </summary>
        public int StartAt { get; set; } = 0;

        /// <summary>
        /// number of characters from index start at
        /// </summary>
        public int Length { get; set; } = ISBNLength;

        /// <summary>
        /// move to: begin or end
        /// </summary>
        public int Destination { get; set; } = Begin;


        // static values
        public static int ISBNLength => 13;

        public static int Begin => 0;

        public static int End => 1;




    }
}
