   M S B A M L   `   `   `  ����G  CMyAABExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MyAABExample.HelperMyAABExample.Helper  5      !    MyAABExample.Views.CustList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5helpers!clr-namespace:MyAABExample.Helper     5      -   5          >�Name$  conCustList��5       � 	Resources 5      ��%    5      .��5      � $��0,0,-0.226,9.774q�6      WindowBackgroundBrush#���   6&    � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Padding$ 5q�6   $��4q�5       �� CornerRadius$ 5��5        
HoverBrush#��[ 5      ._�5   
   �� $��0��6   $��0��6$   $��Customer List View��61   $
��Wrap=�5      $��1��6(   $
��Auto��5      $��12(�5      ���	#FFEFF0E8$��8,8,8,8q�5      $
��Bold"�6%   5!      �� 5"   
   -   5         ��Name$ AddCustomer��5"      $��3��6&   $��8,8,8,8q�64   $��90��5#      ��6   �� *Add_Customer+.��6>   Add Customer6L   &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ CustomerGrid��5&      $
��Left=�5'      $��1��5(      $��0��5*      $��2��6#   $��8q�5+      $	��Top=�5,      /   )MyAABExample.Helper.RowDoubleClickHandler   
MethodName$
 Edit��5/      $��12(�50      	   AutoGenerateColumns	 .  4  .System.Windows.Automation.AutomationProperties
   AutomationId$
 EmployeesListGrid��52         
IsReadOnly .   HoverShineBrush#���  54        DisabledBackgroundBrush#���  55      ��5-      �� *	Customers+ �� Mode$ TwoWay=� �� SelectedItem 5.      �� *SelectedCustomer+   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
CustomerID+$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=�6�     59      $ 
First Name��6%    . $ * 6�    69   �� *CustomerFirstName+$ TwoWay=�$ 	LostFocus=�6�     5:      $ 	Last Name��6%    . $ * 6�    68   �� *CustomerLastName+$ TwoWay=�$ 	LostFocus=�6�     5;      $ Address��6%    . $ * 6�    66   �� *	Address+$ TwoWay=�$ 	LostFocus=�6�     5<      $
 City��6%    . $ * 6�    63   �� *City+$ TwoWay=�$ 	LostFocus=�6�     5=      $ St��6%    . $ * 6�    61   �� *St+$ TwoWay=�$ 	LostFocus=�6�     5>      $	 Zip��6%    . $ * 6�    62   �� *Zip+$ TwoWay=�$ 	LostFocus=�6�     5?      $ Country��6%    . $ * 6�    66   �� *	Country+$ TwoWay=�$ 	LostFocus=�6�     5@      $ Phone��6%    . $ * 6�    64   �� *PhoneNumber+$ TwoWay=�$ 	LostFocus=�6�   5C      5E      5F      