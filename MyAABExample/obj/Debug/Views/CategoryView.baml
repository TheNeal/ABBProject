   M S B A M L   `   `   `  ����  MyAABExample%    MyAABExample.Views.CategoryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5          �Name$  
layoutRoot��5       � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � 	Resources 5   
      	CatSource �� Source �� Mode��%C   &	        �� 5       65   �� *
Categories+$ OneTime=�5      .+�5   
   ��  �� Padding$ 5q�6   $��4q�5       �� CornerRadius$ 5��5        
HoverBrush#��[ 5      ._�5      �� $��Category Maintance��6   
�������$
��Bold"�5      $��12(�5      5      � 5   
   $��1��6    5       �� 5!      $
��Auto �6#   �� 5"      $��6 �6#   �� 5#      $��* �6#    5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    .+�5,      �� $��Category��6   �� 5-      $��2��6    �� DisplayMemberPath$ CategoryName��5/      ��5.      �� *
Categories+	 �� SelectedValue	 50      �� *SelectedCategory+�� 52      $��1��6   $��3��53      $ 5q�54      $��4q�55      $ 5��56      #��[ 57      ._�58      �� $��Category Add/Update��59      
�������$
��Bold"�5;      $��12(�5<      5=      �� 5>      $��2��6   $��Category Name��5?      �� 5@      $��2��6   $��2��5A      ��5B      �� *SelectedCategory.CategoryName+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5C      -   5         ��Name$ btnAddUpdateCat��5C      $��3��6.   $��2��5D      $��30��5G      $��8,0,8,0q�5H      $��2,5,2,2q�5I      $
��Auto��5J      $��Right=�6"   ��5E      �� *btnAddUpdateCat+��5F      �� *AddCategoryButton+��5L      �� 5M       �� EndPoint$ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;    �� 
StartPoint$ 0.5,0&�6_   .��5N      �  � Color$ Black��6'    � Offset$ 1Q�65   � 5O      $
 Gray��6'   5P      5R      5T      �� 5U   
   $ 5q�6   $��4q�5V      $ 5��5W      #��[ 5X      $��1��5Y      ._�5Z      �� $��Item Maintance��6   
�������$
��Bold"�5\      $��12(�5]      5^      � 5_   
   $��2��6   $��2��5`       5a      �� 5b      $
��Auto �6#   �� 5c      $��6 �6#   �� 5d      $��* �6#    5f      �� 5g      $
��Auto �6    �� 5h      $
��Auto �6    �� 5i      $
��Auto �6    �� 5j      $
��Auto �6    5n      � 5o   
   $��1��6   $��2��6    5p      �� 5q      $��* �6    �� 5r      $
��Auto �6    .+�5v   
   &   System.Windows.Controls.DataGrid  -   5          Name$ itemGrid��5v      $��1��6%   $��8q�5x      $	��Top=�5y         AutoGenerateColumns .  4  .System.Windows.Automation.AutomationProperties   AutomationId$ 	ItemsList��5{         CanUserAddRows . ��5}      �� *Items+ �� IsAsync .  �� SelectedItem 5~      �� *SelectedItem+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
IsReadOnly .     Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ItemId+$ TwoWay=�$
 	LostFocus=�6�     5�      $
 Name��6%    .  $ * 6�    63   �� *
ItemName+$ TwoWay=�$
 	LostFocus=�6�   4  .System.Windows.Controls.DataGridComboBoxColumn  5�      $ Category��6)      SelectedValuePath$ 
CategoryId��5�   )      DisplayMemberPath$ CategoryName��5�   U      ItemsSource 5�   )   ��  �� Source# [      SelectedValueBinding  5�   )   �� *
CategoryId+6U   5�      �� 5�   
   -   5        $ btnAddUpdateItem��5�      $��2��6+   $��1��5�      $��30��5�      $��8,0,8,0q�5�      $��2,5,2,2q�5�      $
��Auto��5�      $	��Top=�6"   $��Right=�6:   ��5�      �� *btnAddUpdateItem+��5�      �� *AddItemButton+��5�      �� 5�      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5�      � $ Black��6#   $ 1Q�61   � 5�      $
 Gray��6#   5�      5�      5�      5�      5�      