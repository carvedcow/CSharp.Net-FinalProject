using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Net_FinalProject
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public List<CPU> cpuList { get; set; }
        public List<GPU> gpuList { get; set; }
        public List<MB> mbList { get; set; }
        public List<RAM> ramList { get; set; }
        public List<Storage> storageList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
