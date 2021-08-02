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

namespace ProcessNote
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Processes : Page
    {

        private Process[] _processes;

        public Process[] AllProcesses
        {
            get { return _processes; }
        }

        public Processes()
        {
            GetAllProcesses();
            InitializeComponent();
        }

        public void GetAllProcesses()
        {
            _processes = Process.GetProcesses();
        }

        public void RefreshProcess(int id)
        {
            var process = AllProcesses.FirstOrDefault(p => p.Id == id);
            process.Refresh();
        }

        public ProcessThreadCollection Threads (int id)
        {
            var process = AllProcesses.FirstOrDefault(p => p.Id == id);
            return process.Threads;
        }
    }
}
