   M S B A M L   `   `   `  ���� L  HchampionGG parser, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null5clr-namespace:championGG_parserchampionGG_parser  "    championGG_parser.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     1localclr-namespace:championGG_parser       � Title$  Champion.gg Parser��$	��606��$	��726�� � 
ResizeMode$ NoResize=� � Icon$- 'pack://siteoforigin:,,,/Resources/G.ico�� � DataContext %   championGG_parser.MainViewModel  .��� .+�o�  o� 
IsMainMenu . $��1q�.@�m� $
��File��.@�m� -   $��About��m� -   $��Close��m� $��Application��.@�m� -    m�Name$ dropdownUpdateData��$��Update Data�� m� Command ��  �� Path$ Command_GetData�{��� $ Enable_DropDown_GetData�m� -   $ dropdownExportFiles��$��Export Files�� �� $ Command_ExportData�{��� $! Enable_DropDown_ExportFiles�m� -   $ dropdownClearHTML��$��Clear Leftover HTML�� �� $ Command_ClearHTML�{��� $ Enable_DropDown_ClearHTML�m� -   $��Options���� -    ��Name$ listbox1��$
��Left=�$	��469��$��0,0,1,0q�$��	10,88,0,0q�$	��Top=�$	��175������ 	 �� UpdateSourceTrigger$	 PropertyChanged=�$ ChampionList.champions�
 �� SelectedIndex
 �� $ SelectedIndex����� .R��� $��3,2,0,2q�.+���  �� Orientation$ 
Horizontal=�.+��� $��20(�$	��140��$
��Bold"����� $
 name��� -   $ itemSet��$
��Left=�$	��469��$��10,10,10,10q�$��
190,88,0,0q�$	��Top=�$	��509������ $	 PropertyChanged=�$ PositionSource����� .R���  �� CornerRadius$ 5��
�������$��2q�$��	0,10,0,10q����� $ Color_Positions�._��� $ Vertical=�$��
30,5,10,10q�.+���  �� TextAlignment$ Center=�$��./Resources/#Argentina)�$��Center=�$��30(�$
��Bold"�$��0,0,0,10q����� $ 	lowerName� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q�   	Direction$	 330Q�   Color$ Black��   Opacity$	 0.5Q�   
BlurRadius$ 4Q��� $��0,5,0,10q�$��Center=�$��15(�$
��Bold"����� $ 
skillOrder��� $��Popular Items��$
��Left=�$��17(�$��150px��$
��Bold"�$��	10,10,0,0q��� $ 
Horizontal=�.+���  ��Name$ 
testing123��$��25,5,0,0q����� $ popularItemList����� .R��� $ 
Horizontal=�$��0,3,0,0q�.+��� $ 2��
�������
�������$��2q�$��0,0,10,0q�._��� -	   $
��Left=�$��35��$��35������ $	 img����� .R��� $ 
Horizontal=��� $��Highest Win Rate Items��$
��Left=�$��17(�$��200px��$
��Bold"�$��	10,10,0,0q��� $ testing1234��$��25,5,0,0q����� $ highestWinItemList����� .R��� $ 
Horizontal=�$��0,3,0,0q�.+��� $ 2��
�������
�������$��2q�$��0,0,10,0q�._��� -
   $
��Left=�$��35��$��35������ $	 img����� .R��� $ 
Horizontal=�����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R��� �� -    ��Name$ ParserButton��$��Export Data��$
��Left=�$��
300,41,0,0q�$	��Top=�$	��159��$��42������ $ Command_ExportData�{��� $ Enable_Button_Export��� -   $ buttonDeletePreviousData��$��Delete Item Sets��$
��Left=�$��
577,40,0,0q�$	��Top=�$	��122��$��43������ $ Command_DeleteItemSets�{��� $ Enable_Button_DeletePrev��� -   $ buttonGetData��$��Update Data��$
��Left=�$��	25,42,0,0q�$	��Top=�$	��123��$��41������ $ Command_GetData�{��� $ Enable_Button_GetData�r� -    r�Name$ 
loadingGif��$
��Left=�$��25��$��
200,40,0,0q�$	��Top=�$��30�� r� Source$ Resources/ajax-loader.gif?� r� LoadedBehavior$
 Play=� J� RenderTransformOrigin$ 
0.433,0.56&�y��� $ Vis_LoadingGif��� -    ��Name$ checkmarkImage��$
��Left=�$��26��$��
464,53,0,0q�$	��Top=�$��28��$��Resources/checkmark.png��$ 	0.464,0.5&�y��� $ Vis_CheckMark��� -   $ dataLoadingBarBackground��$
��Left=�$��11��$��
154,70,0,0q�$	��Top=�$	��125��$(��"Resources/LoadingBarBackground.png��y��� $" Vis_DataLoadingBarBackground��� -   $ dataLoadingBarForeground��$
��Left=�$��9��$��
155,71,0,0q�$	��Top=�$(��"Resources/LoadingBarForeground.png��$
��Fill=�y��� $" Vis_DataLoadingBarForeground����� $$ Width_DataLoadingBarForeground��� $)��#Your Data Is Invalid - Update Data!��$
��Left=�$	��Top=�$��
190,21,0,0q�$	��438��$��51��$��25(�$
��Bold"�
���  ��
�������
���  ��$��3q�y��� $ Vis_UpdateDataLabel�