using System.Collections.ObjectModel;
using System.Windows.Input;
using TodoMauiMacApp.Models;
using Microsoft.Maui.Controls;

namespace TodoMauiMacApp.ViewModels;

public class TodoListViewModel : BindableObject
{
    private string _newTitle = string.Empty;

    public string NewTitle
    {
        get => _newTitle;
        set { _newTitle = value; OnPropertyChanged(); }
    }

    public ObservableCollection<TodoItem> Items { get; set; } = new ObservableCollection<TodoItem>();

    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand ToggleCompleteCommand { get; }

    public TodoListViewModel()
    {
        AddCommand = new Command(AddItem);
        DeleteCommand = new Command<TodoItem>(DeleteItem);
        ToggleCompleteCommand = new Command<TodoItem>(ToggleComplete);
    }

    private void AddItem()
    {
        if (!string.IsNullOrWhiteSpace(NewTitle))
        {
            Items.Add(new TodoItem { Title = NewTitle, IsCompleted = false });
            NewTitle = string.Empty;
        }
    }

    private void DeleteItem(TodoItem item)
    {
        if (item != null && Items.Contains(item))
            Items.Remove(item);
    }

    private void ToggleComplete(TodoItem item)
    {
        if (item != null)
            item.IsCompleted = !item.IsCompleted;
    }
}