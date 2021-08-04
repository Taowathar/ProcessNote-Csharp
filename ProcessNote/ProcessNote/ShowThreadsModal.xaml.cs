using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace ProcessNote
{
    /// <summary>
    /// Interaction logic for ShowThreadsModal.xaml
    /// </summary>
    public partial class ShowThreadsModal : Window
    {
        public ProcessThreadCollection Threads { get; }

        public ShowThreadsModal(Process process)
        {
            InitializeComponent();
            DataContext = this;
            Threads = process.Threads;
        }
    }
}
