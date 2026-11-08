using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using VM_Training.Model;

namespace VM_Training.ViewModel
{
    internal class StudentPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Student> StudentList { get; set; } = new ObservableCollection<Student>();
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand AddStudentCommand { get; set; }
        public string Name {  get; set; }
        public string Age { get; set; }

        public StudentPageViewModel()
        {
            AddStudentCommand = new Command( () => AddStudentTOList());
        }

        private void AddStudentTOList()
        {
            Student student = new Student(Name, int.Parse(Age));
            StudentList.Add(student);

            OnPropertyChanged(Name = "");
            OnPropertyChanged(Age = "");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
