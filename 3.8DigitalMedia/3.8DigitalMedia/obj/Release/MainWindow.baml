   M S B A M L   `   `   `  ���� J  F3.8DigitalMedia, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:_3._8DigitalMedia_3._8DigitalMedia  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes G CToggleSwitch, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:ToggleSwitch;assembly=ToggleSwitchToggleSwitch "    _3._8DigitalMedia.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:_3._8DigitalMedia     ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     ?TS0clr-namespace:ToggleSwitch;assembly=ToggleSwitch       � WindowStartupLocation$  CenterScreen=�$��20(�   MainBackgroundBrush1#���     MainTextColour#���   � WindowState$ 	Maximized=� � Title$ Main Window - GenreCalc��$
��1056��$
��1936��$��Stretch=�$��Stretch=�.��� -    �Name$ MainGrid��$��10q� � UseLayoutRounding .  � RowDefinitions �� �� �� �� ��  � ColumnDefinitions �� �� �� .+��� $��Definitions (Start Here!)��$��4��$��10q�$��1��$��36(�$��5q���.  . $��Stretch=�$��Stretch=�$
��Bold"�.��� $��10q� .  �� �� �� �� �� ��  �� �� .+��� -    ��Name$ BPMBox��$��10,20q�$��24(�$��Center=�$��Center=�$��1��$��5q� . $��Normal"�.@��� -    ��Name$ SlowBPM��$
��Slow��#���  �� -   $ 	MediumBPM��$��Medium��#���  �� -   $ FastBPM��$
��Fast��#���  �� -   $ 	InsaneBPM��$��Insane��#���  �� -   $ 	TuningBox��$��10,20q�$��24(�$��Center=�$��Center=�$��1��$��1��$��5q� . $��Normal"�.@��� -   $ StandardTuning��$��Standard��#���  �� -	   $ 	LowTuning��$	��Low��#���  �� -
   $ 
TimeSigBox��$��10,20q�$��24(�$��Center=�$��Center=�$��1��$��2��$��5q���.  . $��Normal"�.@��� -   $ StaticTimeSig��$��Static��#���  �� -   $ DynamicTimeSig��$��Dynamic��#���  �� -   $ SongLengthBox��$��10,20q�$��24(�$��Center=�$��Center=�$��1��$��3��$��5q�$��Normal"�.@��� -   $ MediumSongLength��$��Medium��#���  �� -   $ LongSongLength��$
��Long��#���  �� $��Beats Per Minute��$��Center=�$��Center=�  DefinitionsLabels#���  $��10,20q�$��Normal"��� -   	 ��Name$	 TuningTitleLabel��$��Tuning (DISABLED)��$��10,20q�$��Center=�$��Center=�#���  $��1��$��Normal"��� -   $	 TimeSigTitleLabel��$"��Time Signature
  (DISABLED)��$��10,20q�$��Center=�$��Center=�#���  $��2��$��Normal"��� $��Song Length��$��10,20q�$��Center=�$��Center=�#���  $��3��$��Normal"��� $��Instrumentation��$��10,20q�$��Center=�$��Center=�#���  $��4��$��Normal"��� -   $ InstrumentBox��$��10,20q�$��24(�$��Center=�$��Center=�$��1��$��4��$��5q�$��Normal"�.@��� -   $ Classic��$��Classic��#���  $��Center=�$��Center=��� -   $
 Rock��$
��Rock��#���  $��Center=�$��Center=��� -   $ 
Orchestral��$��
Orchestral��#���  $��Center=�$��Center=��� -   $ 	NorseFolk��$��Norwegian Folk��#���  $��Center=�$��Center=��� -   $ TraditionalFolk��$��Traditional Folk��#���  $��Center=�$��Center=��� -   $ Techno��$��Techno��#���  $��Center=�$��Center=��� $��Origin Country��$��10,20q�$��Center=�$��Center=�#���  $��5��$��Normal"��� -   $ 
CountryBox��$��24(�$��Center=�$��Center=�$��5q�$��Normal"�$��1��$��10,20q�$��5��.@��� -   $	 USA��$��United States of America��#���  $��Center=�$��Center=��� -   $ UK��$��United Kingdom��#���  $��Center=�$��Center=��� -   $ NZ��$��New Zealand��#���  $��Center=�$��Center=��� -   $	 NOR��$��Norway��#���  $��Center=�$��Center=��� -   $	 SWE��$��Sweden��#���  $��Center=�$��Center=��� -   $	 FIN��$��Finland��#���  $��Center=�$��Center=��� -    $	 GER��$��Germany��#���  $��Center=�$��Center=��� -!   $	 MON��$��Mongolia��#���  $��Center=�$��Center=��� -"   $	 BPMLabel��$�� ��$
��Left=�$��
170,36,0,0q�$��1��$	��Top=�$��2��$	��144��

 � Tag
 �� *SelectionBoxItem+ �� ElementName$ BPMBox�� �� Mode$ OneWay=��� -#   $	 TuningLabel��$�� ��$
��Left=�$��
170,31,0,0q�$��2��$	��Top=�$��2��$	��144��
 �� *SelectionBoxItem+$ 	TuningBox��$ OneWay=��� -$   $	 TimeSigLabel��$�� ��$
��Left=�$��
170,29,0,0q�$��3��$	��Top=�$��2��$	��144��
 �� *SelectionBoxItem+$ 
TimeSigBox��$ OneWay=��� -%   $	 SongLengthLabel��$�� ��$
��Left=�$��
170,27,0,0q�$��4��$	��Top=�$��2��$	��144��
 �� *SelectionBoxItem+$ SongLengthBox��$ OneWay=��� -&   $	 InstrumentationLabel��$�� ��$
��Left=�$��
170,96,0,0q�$��4��$	��Top=�$	��144��
 �� *SelectionBoxItem+$ InstrumentBox��$ OneWay=��� $��1��$��10q� �� CornerRadius$ 5��$��5q�._��  �� $��6* ��� $��4* � �� �� .+��� -'    ��Name$ GeneratorButton��$��Click to Calculate Genre��$��10q�  MainBorderColour#���  $
��Bold"��� -(   $��Show Genre Definitions��$��10q�$��1��#���  �� -)   $��Settings��$��10q�#���  $��1��)  #ToggleSwitch.HorizontalToggleSwitch  -*   $��18(�  MainFont#���  $��1��$��1��#  ToggleSwitch.ToggleSwitchBase   
Elasticity$ 0Q�$��Stretch=�$��Stretch=�$
��Auto��$��10,20q�  MainComboBoxSelectedColour   CheckedBackground# �     CheckedForeground# �    MainButtonColour   
ThumbBrush# �     UncheckedBackground# �      UncheckedForeground# �  #���     UncheckedContent$ Basic��   CheckedContent$ Advanced��$
��Auto���� $��Genre Output��$��1��$��1��$��2��$��4��$��36(�$
��Bold"�$��10q�.��� $��10q� �� �� �� $��5* �.+��� -+   $	 SuggestedBandsLabel��$�� ��$��Center=�$��Center=�$��30(�$��10q�$��1��$��Normal"��� -,   $	 
GenreLabel��$��Genre Will Appear Here��$��Center=�$��Center=�$��30(�$��10q�$��Normal"�9� $��More Suggestions��$��5,10,5,0q�$��2��.���� $��
10,10,10,0q�#���     MoreOptionsBorder#���  $��5q�._�� #���   ��. $��0q� �� $
��219* ��� $
��370* � �� �� �� �� �� �� .+��� --   $	 SuggestedBPMLabel��$��Suggested Genres By BPM��$��10q�$��Normal"��� -.   $	 SuggestedTuningLabel��$ ��Suggested Genres By Tuning��$��10q�$��Normal"�$��1���� -/   $	 SuggestedTimeSigLabel��$(��"Suggested Genres By Time Signature��$��10q�$��Normal"�$��2���� -0    ��Name$ SuggestedByBPM��$
��Wrap=�$��5q�$��Normal"�$��16(� �� Padding$ 0q�$��1���� -1   $	 SuggestedSongLengthLabel��$%��Suggested Genres By Song Length��$��10q�$��Normal"�$��3���� -2   $ SuggestedByTuning��$
��Wrap=�$��5q�$��Normal"�$��16(�$ 0q�$��1��$��1���� -3   $ SuggestedByTimeSig��$
��Wrap=�$��5q�$��Normal"�$��16(�$ 0q�$��2��$��1���� -4   $ SuggestedBySongLength��$
��Wrap=�$��5q�$��Normal"�$��16(�$ 0q�$��3��$��1���� -5   $"	 SuggestedInstumentationLabel��$)��#Suggested Genres By Instrumentation��$��10q�$��Normal"�$��4���� -6   $  SuggestedByInstrumentation��$
��Wrap=�$��5q�$��Normal"�$��16(�$ 0q�$��4��$��1���� -7   $	 SuggestedByCountryLabel��$(��"Suggested Genres By Origin Country��$��10q�$��Normal"�$��5���� -8   $ SuggestedByCountry��$
��Wrap=�$��5q�$��Normal"�$��16(�$ 0q�$��5��$��1���� $��5q�$ 5��$��2��$��10q�._��  �� $��2* ��� $��8* ��� $��2* � �� �� .+��� -9   $
��Help��$��10q�#���  �� -:   $��Show Spotify Playlists��$��10q�$��1��#���  �� -;   $
��Exit��$��10q�$��2��#���  �� -<   $��Clear��$��10q�$��1��