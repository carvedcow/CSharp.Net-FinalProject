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
        //Context
        PCContext context = new PCContext();

        //public string FirstName { get; set; }

        private List<CPU> _cpuList;
        public List<CPU> cpuList
        {
            get
            {
                return _cpuList;
            }
            set
            {
                _cpuList = value;
                INotifyPropertyChanged();
            }
        }

        private List<GPU> _gpuList;
        public List<GPU> gpuList
        {
            get
            {
                return _gpuList;
            }
            set
            {
                _gpuList = value;
                INotifyPropertyChanged();
            }
        }

        private List<MB> _mbList;
        public List<MB> mbList
        {
            get
            {
                return _mbList;
            }
            set
            {
                _mbList = value;
                INotifyPropertyChanged();
            }
        }

        private List<RAM> _ramList;
        public List<RAM> ramList
        {
            get
            {
                return _ramList;
            }
            set
            {
                _ramList = value;
                INotifyPropertyChanged();
            }
        }

        private List<Storage> _storageList;
        public List<Storage> storageList
        {
            get
            {
                return _storageList;
            }
            set
            {
                _storageList = value;
                INotifyPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            fillLists();
        }

        private void fillLists()
        {
            //populate cpuList
            var c = (from i in context.CPUs select i).ToList();
            this.cpuList = c;
            //populate gpuList
            var g = (from j in context.GPUs select j).ToList();
            this.gpuList = g;
            //populate mbList
            var m = (from k in context.MBs select k).ToList();
            this.mbList = m;
            var r = (from l in context.RAMs select l).ToList();
            this.ramList = r;
            var s = (from o in context.Storages select o).ToList();
            this.storageList = s;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void INotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
