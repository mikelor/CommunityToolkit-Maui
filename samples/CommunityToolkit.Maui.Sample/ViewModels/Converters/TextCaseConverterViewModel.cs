﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace CommunityToolkit.Maui.Sample.ViewModels.Converters;

public class TextCaseConverterViewModel : BaseViewModel
{
	[ObservableProperty]
	string input = string.Empty;
}