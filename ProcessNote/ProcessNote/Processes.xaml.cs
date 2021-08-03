using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using ProcessNote.Entities;

namespace ProcessNote
{
    /// <summary>
    /// Interaction logic for Processes.xaml
    /// </summary>
    public partial class Processes : UserControl
    {


        private ProcessCollection _processes;

        public ProcessCollection AllProcesses
        {
            get { return _processes; }
        }

        public Processes()
        {
            InitializeComponent();
            DataContext = this;
            _processes = new ProcessCollection();
        }

        public void GetAllProcesses()
        {
           
            foreach (var p in Process.GetProcesses())
            {
                _processes.Add(p);
            }
        }

        public void RefreshProcess(int id)
        {
            var process = AllProcesses.FirstOrDefault(p => p.Id == id);
            process.Refresh();
        }

        public ProcessThreadCollection Threads(int id)
        {
            var process = AllProcesses.FirstOrDefault(p => p.Id == id);
            return process.Threads;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllProcesses();
        }
    }
}
