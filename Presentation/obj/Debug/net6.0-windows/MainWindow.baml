   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��500��6)   ���#222222 � 	Resources 5
         MainWindowButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers �� Value	 �� Binding
 �� 
TargetName P� Property P� Value N� EnterActions	 �� To g� Duration �� 
TargetName �� TargetProperty N� ExitActions��%�  &	        �� 5   
   " ��6.   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 5q�6(   �� 5       � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5       5      �� 5      $
 True��6G   	 6*   �� *
IsActive+.a�5   "   �� $
 border��6)    � ��
 ��  �6S   5      P� 5       �@J�IsMouseOver$
 True��6=    5   "   �� 5    &   .��5!   *   �� .��5"   .   ��  #710c996=   $ 0:0:0.4D�6J   $ border��6]   $1 +(Border.Background).(SolidColorBrush.Color)�6|   5#   +   5$   '    5&   "   �� 5'   &   .��5(   *   �� .��5)   .   �� $ 0:0:0.4D�6=   $ border��6P   $1 +(Border.Background).(SolidColorBrush.Color)�6o   5*   +   5+   '   5-      5/      51      52      55      .��58      � .+�59   
   ��  �� Orientation$ 
Horizontal=�6   $��40��6.   $	��Top=�6:   $��50, 5q�6R   .+�5:      �  � ColumnDefinitions 5;      �� 5<      $��2* �6'   �� 5=      $��2* �6'   .+�5?      �� -   5         ��Name$ PageSelector��5?      $��0��61   $	��120��6A   $��25��6M   $��50, 0q�6Y   ���#222222$��Center=�6}   5B      �� 5C      -   5        $��Actors +��5C      $��1��6,   $��80��6=   $��25��6K   $��50, 0q�6W   #��[  6f   $��Center=�6�   6�   5D      5F       � 5G   
   -   5          �Name$
 Main��5G      $��50,50,50,100q�6     � NavigationUIVisibility$ Hidden=�64   6V   � 5I   
   $
��0, 5q�6   $��60��6   $��Bottom=�6*    5J      �� 5K      �� 5L      .+�5N      �� -   5        $��Remove Project��5N      $��0��6.   #��[  6>   $��50��6m   $��1q�6�   ��6y   �� *!DataContext.ToggleActiveCommand+ �� RelativeSource ��  �� AncestorType ItemsControl��6�   �� 6  �� 5O      -   5        $��Add Project��5O      $��1��6+   #��[  6;   $��50��6j   $��1q�6�   ��6v   �� *!DataContext.ToggleActiveCommand+ ��  ItemsControl��6�   �� 6  5P      5Q      5R      