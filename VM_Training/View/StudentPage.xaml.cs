using VM_Training.ViewModel;

namespace VM_Training
{
    public partial class StudentPage : ContentPage
    {
        public StudentPage()
        {
            InitializeComponent();
            BindingContext = new StudentPageViewModel();
        }
    }
}