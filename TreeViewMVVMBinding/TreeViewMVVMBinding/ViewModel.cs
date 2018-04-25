using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;

namespace TreeViewMVVMBinding
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<Node> _dirItems;
        private string text = "1";
        private object _selectedItem;
        private string _nameNode;
        private string _testText;
        public ViewModel()
        {
            var itemProvider = new NodeProvider();
            DirItems = itemProvider.DirItems;
            ClickCommand = new Command(arg => ClickMethod());
        }

        public ICommand ClickCommand { get; set; }
        private void ClickMethod()
        {
            MessageBox.Show(Text);
            MessageBox.Show(TestText);
            TestText = "111";
        }

        public string Text
        {
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }

            get
            {
                return text;
            }
        }

        public string TestText
        {
            set
            {
                _testText = value;
                OnPropertyChanged("TestText");
            }
            get
            {
                return _testText;
            }
        }
        public object SelectedItem
        {
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
            get
            {
                return _selectedItem;
            }
        }

        public string NameNode
        {
            set
            {
                _nameNode = value;
                OnPropertyChanged(nameof(NameNode));
            }
            get
            {
                return SelectedItem.ToString();
            }
        }

        public List<Node> DirItems
        {
            get { return _dirItems; }
            set
            {
                _dirItems = value;
                OnPropertyChanged(nameof(DirItems));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
