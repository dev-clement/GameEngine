using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalEditor.GameProject
{
    class NewProject : ViewModelBase
    {
        private string _name = "New Project";
        
        public string Name
        {
            get => _name;
            set 
            { 
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PrimalProject\";

        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }
    }
}
