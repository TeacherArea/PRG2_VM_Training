using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace VM_Training.ViewModel
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private int count = 28;
        public string? CounterBtnText { get; set; } = "Click me!";
        public ICommand? CounterBtnCommand { get; set; }

        public MainPageViewModel()
        {
            CounterBtnCommand = new Command(() => OnCounterClicked());
        }

        public void OnCounterClicked()
        {
            count++;
            if (count == 1)
            {
                CounterBtnText = $"Clicked {count} time";
            }
            else
            {
                CounterBtnText = $"Clicked {count} times";
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CounterBtnText)));
        }
    }
}
