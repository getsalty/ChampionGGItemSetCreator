   M S B A M L   `   `   `  ����L  HchampionGG parser, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null5clr-namespace:championGG_parserchampionGG_parser  5   	   "    championGG_parser.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:championGG_parser     5   	     � Title$  Champion.gg Parser��5   	   $	��606��6$   $	��726��61    � 
ResizeMode$ NoResize=�6=    � Icon$- 'pack://siteoforigin:,,,/Resources/G.ico��6S    � DataContext 5      %   championGG_parser.MainViewModel  5   
   .��5      � .+�5   
   o�  o� 
IsMainMenu . $��1q�6!   .@�5      m� $
��File��6   .@�5      m� -   5        $��About��5      6*   m� 5      -   5        $��Close��5      6*   5      m� 5      $��Application��6   .@�5      m� -   5         m�Name$ dropdownUpdateData��5      $��Update Data��67    m� Command 6L   ��  �� Path$ Command_GetData�{�6u   �� $ Enable_DropDown_GetData�m� 5      -   5        $ dropdownExportFiles��5      $��Export Files��68    6N   �� $ Command_ExportData�{�6z   �� $! Enable_DropDown_ExportFiles�m� 5      -   5        $ dropdownClearHTML��5      $��Clear Leftover HTML��66    6S   �� $ Command_ClearHTML�{�6~   �� $ Enable_DropDown_ClearHTML�m� 5      -   5        $��Options��5      6,   5      5      �� 5   
   -   5         ��Name$ listbox1��5      $
��Left=�6�   $	��469��6�   $��0,0,1,0q�6�   $��	10,88,0,0q�6�   $	��Top=�6�   $	��175��6  ��6$   �� 	 �� UpdateSourceTrigger$	 PropertyChanged=�$ ChampionList.champions�
 �� SelectedIndex
 6}   �� $ SelectedIndex���5      �� 5      .R�5      �� $��3,2,0,2q�6!   .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��20(�6C   $	��140��6Q   $
��Bold"�6^   ��6(   �� $
 name�6^   5      5       5!      5#      �� 5$   
   -   5        $ itemSet��5$      $
��Left=�6#   $	��469��6>   $��10,10,10,10q�6K   $��
190,88,0,0q�5%      $	��Top=�6&   $	��509��6>   ��6J   �� $	 PropertyChanged=�$ PositionSource���5&      �� 5'      .R�5)      ��  �� CornerRadius$ 5��6   
�������$��2q�6m   $��	0,10,0,10q�6�   ��6A   �� $ Color_Positions�._�5*      �� $ Vertical=�6%   $��
30,5,10,10q�6<   .+�5+      ��  �� TextAlignment$ Center=�6H   $��./Resources/#Argentina)�6`   $��Center=�6�   $��30(�6�   $
��Bold"�6�   $��0,0,0,10q�6�   ��6(   �� $ 	lowerName� J� Effect 5,   "   3  -System.Windows.Media.Effects.DropShadowEffect  5-   &      ShadowDepth$ 2Q�67      	Direction$	 330Q�6G      Color$ Black��6W      Opacity$	 0.5Q�6e      
BlurRadius$ 4Q�6s   5/      �� 50      $��0,5,0,10q�6I   $��Center=�6[   $��15(�6x   $
��Bold"�6�   ��6(   �� $ 
skillOrder�6�   �� 51      $��Popular Items��6(   $
��Left=�6=   $��17(�6X   $��150px��6f   $
��Bold"�6t   $��	10,10,0,0q�6�   �� 52      $ 
Horizontal=�6)   .+�53   "   ��  ��Name$ 
testing123��6/   $��25,5,0,0q�6p   ��6C   �� $ popularItemList���54   &   �� 55   *   .R�56   .   �� $ 
Horizontal=�69   $��0,3,0,0q�6R   .+�57   2   �� $ 2��69   
�������
�������$��2q�6t   $��0,0,10,0q�6�   ._�58   6   �� -	   5        $
��Left=�58   <   $��35��6W   $��35��6c   ��6n   �� $	 img�6�   5:   3   5;   /   5<   +   ��5>   &   �� 5?   *   .R�5@   .   �� $ 
Horizontal=�69   5A   +   5C   #   5D      �� 5E      $��Highest Win Rate Items��6(   $
��Left=�6F   $��17(�6a   $��200px��6o   $
��Bold"�6}   $��	10,10,0,0q�6�   �� 5F      $ testing1234��6,   $��25,5,0,0q�6q   ��6A   �� $ highestWinItemList���5G   "   �� 5H   &   .R�5I   *   �� $ 
Horizontal=�65   $��0,3,0,0q�6N   .+�5J   .   �� $ 2��65   
�������
�������$��2q�6p   $��0,0,10,0q�6�   ._�5K   2   �� -
   5        $
��Left=�5K   8   $��35��6S   $��35��6_   ��6j   �� $	 img�6�   5L   /   5N   +   5O   '   ��5Q   "   �� 5R   &   .R�5S   *   �� $ 
Horizontal=�65   5T   '   5V      5W      5X      5Y      ��5[      �� 5\       �� 
TargetType" ��6   .�5]      ��  �� Property � �� �� Value 5^      �� 5_       �� 
TargetType" ��6.   .R�5`   "   �� 5a      5c      5d      5f      �� 5i   
   -   5         ��Name$ ParserButton��5i      $��Export Data��6'   $
��Left=�6=   $��
300,41,0,0q�6X   $	��Top=�6l   $	��159��6�   $��42��6�   ��6�   �� $ Command_ExportData�{�6�   �� $ Enable_Button_Export��� 5j   
   -   5        $ buttonDeletePreviousData��5j      $��Delete Item Sets��63   $
��Left=�6N   $��
577,40,0,0q�6i   $	��Top=�6}   $	��122��6�   $��43��6�   ��6�   �� $ Command_DeleteItemSets�{�6�   �� $ Enable_Button_DeletePrev��� 5k   
   -   5        $ buttonGetData��5k      $��Update Data��6(   $
��Left=�6>   $��	25,42,0,0q�6Y   $	��Top=�6l   $	��123��6�   $��41��6�   ��6�   �� $ Command_GetData�{�6�   �� $ Enable_Button_GetData�r� 5l   
   -   5         r�Name$ 
loadingGif��5l      $
��Left=�6V   $��25��6q   $��
200,40,0,0q�6}   $	��Top=�6�   $��30��6�    r� Source$ Resources/ajax-loader.gif?�6�    r� LoadedBehavior$
 Play=�6�    J� RenderTransformOrigin$ 
0.433,0.56&�6�   y�6+   �� $ Vis_LoadingGif�6  �� 5m   
   -   5         ��Name$ checkmarkImage��5m      $
��Left=�6R   $��26��6m   $��
464,53,0,0q�6y   $	��Top=�6�   $��28��6�   $��Resources/checkmark.png��6�   $ 	0.464,0.5&�6�   y�6(   �� $ Vis_CheckMark�6�   �� 5n   
   -   5        $ dataLoadingBarBackground��5n      $
��Left=�6k   $��11��6�   $��
154,70,0,0q�6�   $	��Top=�6�   $	��125��6�   $(��"Resources/LoadingBarBackground.png��6�   y�62   �� $" Vis_DataLoadingBarBackground�6�   �� 5o   
   -   5        $ dataLoadingBarForeground��5o      $
��Left=�6�   $��9��6�   $��
155,71,0,0q�6�   $	��Top=�6�   $(��"Resources/LoadingBarForeground.png��6�   $
��Fill=�6   y�62   �� $" Vis_DataLoadingBarForeground���6k   �� $$ Width_DataLoadingBarForeground�6   �� 5p   
   $)��#Your Data Is Invalid - Update Data!��6@   $
��Left=�6n   $	��Top=�6�   $��
190,21,0,0q�6�   $	��438��6�   $��51��6�   $��25(�6�   $
��Bold"�6�   
���  ��
�������
���  ��$��3q�6)  y�6   �� $ Vis_UpdateDataLabel�6)  5q      5r      