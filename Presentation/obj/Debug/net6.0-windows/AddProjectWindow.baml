   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	   #    Presentation.AddProjectWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  AddProjectWindow��5      $	��250��6&   $	��400��63   ���#222222.��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   � $��0��6    5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    .+�5      �� $��1��6   $��Enter project name:��6!   
�������$��50, 0q�6R   $��14(�6a   $��30��6o   $
��Bold"�6{   �� 5      -   5         ��Name$ AddProjectInput��5      $��2��6/   $��50, 5q�6<   $��5q�6K   $��Center=�6W   $��Stretch=�6r   
�������
����������#333333$��14(�5      $
��Bold"�6    $��Italic$�62    J� Opacity$	 0.8Q�6E   5      �� 5   
   -   5        $��1��5      $��10q�6   $��5q�6*   $	��150��66   $��Center=�6E   $��Center=�6`   $��Add Project��5      ���#007acc
�������$��16(�6K   $
��Bold"�6Y   5      5      5      