   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OtherPages
OtherPages  5      +clr-namespace:PresentationPresentation  5          OtherPages.ExportDataPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:OtherPages     5      )rsclr-namespace:Presentation     5        N� Title$  ExportDataPage��5
      .��5      �    Back#���   6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��20q�6.   .+�5      �� -   5        $��btnBack��5      $
��Back��6$   $	��Top=�6I   $
��Left=�6a   ���#D9D9D9$��0q�6�   ��5      �� 5      .R�5      �� #���   6$      Presentation.Resources   Btn_back#��Z 6H     Text#���  6p   $
��Bold"�6�   $��18(�6�    �� TextAlignment$
 Left=�6�   $	��Top=�6�   5      5      5      �� 5      $��40q�6   $��Center=�6%   $��Center=�6B   .+�5      �� $ 
Horizontal=�6   .+�5      ��    SelectPeriodLabel#��Z 6   #���  6M   $
��Bold"�6q   $��25 0 0 0q�6�   $ Center=�6�   $��Center=�6�   �� 5      $ Vertical=�6!   $��50 0 0 0q�68   .+�5      �� $ 
Horizontal=�6%   $��5q�6>   $��Right=�6I   .+�5      ��    StartDateLabel#��Z 6$   #���  6R   $��Center=�6v   $��0,0,10,0q�6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��StartDatePicker��5   )   5      �� 5       $ 
Horizontal=�6%   $��5q�6>   $��Right=�6I   .+�5!      ��    EndDataLabel#��Z 6$   #���  6P   $��Center=�6t   $��0,0,10,0q�6�     5"      -   5        $��EndDatePicker��5"   %   5#      5$      5%      �� 5&      $ 
Horizontal=�6   $�� 0 20 q�66   .+�5'      ��    SelectCategoryLabel#��Z 6   #���  6O   $
��Bold"�6s   $��20 0 0 0q�6�   �� 5)      -   5        $��CategoryComboBox��5)      $	��160��64   $��60 0 0 0q�6@   5*      5+      �� 5,      $ 
Horizontal=�6   $�� 0 20 q�66   .+�5-      ��    SelectTypeDataLabel#��Z 6   #���  6O   $
��Bold"�6s   $��20 0 0 0q�6�   �� 5/      -   5        $��DataTypeComboBox��5/      $	��160��67   $��50 0 0 0q�6C   .@�50      �� $��CSV Files (*.csv)|*.csv��6'   51      52      �� 53      -   5        	   
Btn_export#��Z	 53      $	��100��6B   $��30��6N   $��0 20 0 0q�6Z    
 Button#���  6�   #���  6�   54      56      58      