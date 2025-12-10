using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TodoMauiMacApp.Models;

public class TodoItem : INotifyPropertyChanged
{
    private string _title = string.Empty;
    private bool _isCompleted;

    public string Id { get; } = System.Guid.NewGuid().ToString();

    public string Title
    {
        get => _title;
        set { _title = value; OnPropertyChanged(); }
    }

    public bool IsCompleted
    {
        get => _isCompleted;
        set { _isCompleted = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}