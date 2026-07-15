using CommunityToolkit.Mvvm.ComponentModel;

namespace ManiaUtilities.ViewModels;

public partial class FlnConversionViewModel : ModuleViewModel
{
    [ObservableProperty] private int gapMs = 80;
    
    public override string Name => "FLN conversion";
}