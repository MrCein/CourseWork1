using System.Windows;
using WpfAppСourseWork.Model;

namespace WpfAppСourseWork.View
{
    public partial class ErrorMessage : Window
    {
        public ErrorMessage(ErrorMessageModel _errorMessageModel)
        {
            InitializeComponent();
            DataContext = _errorMessageModel;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
