   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.RolesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	RolesPage��5	       � 	Resources 5         RolesButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers �� Value	 �� Binding
 �� 
TargetName P� Property P� Value N� EnterActions	 �� To g� Duration �� 
TargetName �� TargetProperty N� ExitActions��%�  &	        �� 5   
   " ��6)   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 5q�6(   �� 5       � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5       5      �� 5      $
 True��6G   	 6*   �� *
IsActive+.a�5   "   �� $
 border��6)    � ��
 ��  �6S   5      P� 5       �@J�IsMouseOver$
 True��6=    5   "   �� 5   &   .��5    *   �� .��5!   .   ��  #710c996=   $ 0:0:0.4D�6J   $ border��6]   $1 +(Border.Background).(SolidColorBrush.Color)�6|   5"   +   5#   '    5%   "   �� 5&   &   .��5'   *   �� .��5(   .   �� $ 0:0:0.4D�6=   $ border��6P   $1 +(Border.Background).(SolidColorBrush.Color)�6o   5)   +   5*   '   5,      5.      50      51      52      .��54      �� $��Hidden=�6   $��Hidden=�68   .��55   
   �  � RowDefinitions 56      �� 57      �� 58      $��60 �6    .+�5;      �� -   5         ��Name$ RolesListView��5;   F   $��0��6   ��6(   �� *Roles+��5<      �� 5=      .R�5>      �  � ColumnDefinitions 5?      �� 5@   "   $��1* �63   �� 5A   "   $��4* �63   �� 5B   "   $��4* �63   .+�5E      �� $��
volume.png��6$   $��0��68   $��Uniform=�6H   $��20��6Z   $��20��6e   �� 5F      $��1��6H   $��Center=�6X   $��16(�6s   
�������$
��0,10q�6�   ��6(   �� *Item1.RoleName+5G      �� 5H      $��2��6I   $��Center=�6Y   $��16(�6t   
�������$
��0,10q�6�   ��6(   �� *Item2.ActorName+5I      5J      5K      5M      � 5O      $��1��6    5P      �� 5Q      �� 5R      .+�5T      �� -   5        $��Remove Role��5T      $��0��6/   #��[  6?   $��50��6i   $��1q�6�   $	��5,5q�6/  $��Bottom=�6<  ��6u   �� *!DataContext.ToggleActiveCommand+ �� RelativeSource ��  �� AncestorType ItemsControl��6�   �� 6<  �� 5U      -   5        $��Add Role��5U      $��1��6,   #��[  6<   $��50��6f   $��1q�6�   $	��5,5q�6)  $��Bottom=�66  ��6r   �� *!DataContext.ToggleActiveCommand+ ��  ItemsControl��6�   �� 66  5V      5W      5X      5Y      