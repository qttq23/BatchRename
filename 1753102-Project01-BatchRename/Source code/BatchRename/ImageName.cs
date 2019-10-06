using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BatchRename
{
    /// <summary>
    /// class contains all image names in particular folder
    /// </summary>
    public class ImageName
    {
        const string foldername = @"Images\";

        public ImageName()
        {
            LoadImageName();
        }

        public void LoadImageName()
        {
            // open folder, get all filenames
            //AppDomain.CurrentDomain.BaseDirectory

            string path = AppDomain.CurrentDomain.BaseDirectory + foldername;
            string[] filenames = Directory.GetFiles(path);


            // check filename to assign to variables
            foreach (var fullname in filenames)
            {
                string filename = Path.GetFileName(fullname);
                
                string[] tokens = StringProcess.SplitString(filename, new string[] { "_"});
                
                if (tokens[0].ToLower() == "Application".ToLower())
                {
                    ApplicationIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Option".ToLower())
                {
                    OptionIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Remove".ToLower())
                {
                    RemoveIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "RemoveAll".ToLower())
                {
                    RemoveAllIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Add".ToLower())
                {
                    AddIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Preview".ToLower())
                {
                    PreviewIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Start".ToLower())
                {
                    StartIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Refresh".ToLower())
                {
                    RefreshIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Help".ToLower())
                {
                    HelpIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Open".ToLower())
                {
                    OpenIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Save".ToLower())
                {
                    SaveIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Information".ToLower())
                {
                    InformationIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "File".ToLower())
                {
                    FileIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Folder".ToLower())
                {
                    FolderIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "Action".ToLower())
                {
                    ActionIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }
                else if (tokens[0].ToLower() == "List".ToLower())
                {
                    ListIcon.Add
                    (
                        new MyString()
                        {
                            Value = path + filename
                        }
                    );
                }


            }

        }

        public BindingList<MyString> ApplicationIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> OptionIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> RemoveIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> RemoveAllIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> AddIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> PreviewIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> StartIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> RefreshIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> HelpIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> OpenIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> SaveIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> InformationIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> FileIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> FolderIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> ActionIcon { get; set; } = new BindingList<MyString>();
        public BindingList<MyString> ListIcon { get; set; } = new BindingList<MyString>();


    }
}
