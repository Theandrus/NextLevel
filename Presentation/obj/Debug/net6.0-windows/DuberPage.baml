   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.DuberPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	DuberPage��5	       � 	Resources 5         DuberButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers �� Value	 �� Binding
 �� 
TargetName P� Property P� Value N� EnterActions	 �� To g� Duration �� 
TargetName �� TargetProperty N� ExitActions :� RoutedEvent W� From	 W� To��%�  &	        �� 5   
   " ��6)   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 5q�6(   �� 5       � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5       5      �� 5      $
 True��6G   	 6*   �� *
IsActive+.a�5   "   �� $
 border��6)    � ��
 ��  �6S   5      P� 5       �@J�IsMouseOver$
 True��6=    5   "   �� 5   &   .��5    *   �� .��5!   .   ��  #710c996=   $ 0:0:0.4D�6J   $ border��6]   $1 +(Border.Background).(SolidColorBrush.Color)�6|   5"   +   5#   '    5%   "   �� 5&   &   .��5'   *   �� .��5(   .   �� $ 0:0:0.4D�6=   $ border��6P   $1 +(Border.Background).(SolidColorBrush.Color)�6o   5)   +   5*   '   5,      :� 5.      $ Loaded��6+   .[�5/   "   �� .��50   &   �� .��51   *   W� $ Opacity�6:    06^    16g   $ 0:0:2D�6n   52   '   53   #   54      56      58      59      5:      .��5<      �  � RowDefinitions 5=   
   �� 5>      �� 5?      $��60 �6   .+�5B   
   �� $��0��6   $��Hidden=�6$   $��Hidden=�6I   .��5C   
   �� -   5         ��Name$ DuberListView��5C   7   ��6   �� *Dubers+��5D      �� 5E      .R�5F      � .+�5G      d� $��Center=�6K   $��16(�6f   ��6'   �� *Item1.ActorName+��5H      �� 5I   "   " d�6(   .�5J   &   ��  � ��
 �����6C   �� 5K   &    � ��$	 250��6>   �� 5L   &    � ��$ 5q�6?   �� 5M   &    � ��$ 50��6@    �� Triggers 5N   &   �� 5O   *   	 66   �� *Item2+ True6P   .a�5P   .   ��  � ��
 � � �6K   5Q   +   �� 5R   *   	 66   �� *Item2+	 False6P   .a�5S   .   ��  � �� �#FC6E5B6K   5T   +   P� 5U   *    �@d�	IsChecked$
 TrueY�6G   . �5V   .   ��  � ��
 ��  �6K   5W   +   5Y   #   5[      5\      5]      5_      5`      �� 5b   
   $��1��6   .+�5c      �  � ColumnDefinitions 5d      �� 5e      �� 5f      .+�5i      �� -   5        $��Remove Actor��5i      $��0��60   #��[  6@   $��50��6j   $��1q�6�   ��6v   �� *!DataContext.ToggleActiveCommand+ �� RelativeSource ��  �� AncestorType ItemsControl��6�   �� 6  �� 5j      -   5        $��	Add Actor��5j      $��1��6-   #��[  6=   $��50��6g   $��1q�6�   ��6s   �� *!DataContext.ToggleActiveCommand+ ��  ItemsControl��6�   �� 6  5k      5l      5m      5n      