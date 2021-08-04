using ProcessNote.Entities;
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
    /// Interaction logic for Comment.xaml
    /// </summary>
    public partial class CommentModal : Window
    {
        private int _id;
        public String ProcessName { get; private set; }

        public CommentCollection Comments { get; private set; }

        public CommentModal()
        {
            InitializeComponent();
        }

        public CommentModal(int id, CommentCollection comments)
        {
            InitializeComponent();
            DataContext = this;
            _id = id;
            ProcessName = Process.GetProcessById(id).ProcessName;
            Comments = comments;
        }
            
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newComment = new Comment(CommentTextBox.Text, DateTime.Now);
            Comments.Add(newComment);
            CommentTextBox.Clear();
        }
    }
}
