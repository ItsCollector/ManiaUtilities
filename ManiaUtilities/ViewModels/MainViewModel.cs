using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ManiaUtilities.Models;

namespace ManiaUtilities.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<Preset> presets = new()
    {
        new Preset { Name = "Convert to FLN", FlnConversionEnabled = true, FlnGapMs = 80 },
        new Preset { Name = "Remove LNs", RemoveLnsEnabled = true }
    };
    
    [ObservableProperty] private string mapTitle = "Placeholder Title";
    [ObservableProperty] private string mapAuthor = "Placeholder Author";
    [ObservableProperty] private string mapVersion = "Placeholder Version";
    
    [ObservableProperty]
    private Preset? selectedPreset;

    partial void OnSelectedPresetChanged(Preset? value)
    {
        if (value is null) return;
        
        selectedPreset = value;
    }
}