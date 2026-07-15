using CommunityToolkit.Mvvm.ComponentModel;

namespace ManiaUtilities.ViewModels;

public abstract partial class ModuleViewModel : ViewModelBase
{
    [ObservableProperty] private bool isEnabled;
    [ObservableProperty] private bool isExpanded;
    
    public abstract string Name { get; }
}