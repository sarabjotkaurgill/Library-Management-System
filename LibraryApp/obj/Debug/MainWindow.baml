   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LibraryApp
LibraryApp  5   	       LibraryApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LibraryApp     5   	     � Title$  Library Manager��5   	   $	��700��6!   $
��1200��6.   
�������.��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5"   
   �� $��Library Management System��6   $��1��64   $��1��6A   $��6��6Q   $	��Top=�6f   $��Italic$�6~   $��Center=�6�   $	��500��6�   $��30(�6�   &   System.Windows.Controls.DataGrid  5$   
   -   5        $��	mediaGrid��5$      $��Oblique$�6$   $��2��68   $��3��6E   $��4��6U   $��5��6i      AutoGenerateColumns .  $��6q�6�   $��22(�6�      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Title+ �� Mode$ OneWay=�  5'      $
 Type��6%    63   �� *	MediaType+$ OneWay=�4  .System.Windows.Controls.DataGridCheckBoxColumn  5(      $ Availability��6)    6?   �� *IndicateStatus+$ OneWay=�  5)      $ Borrower��6%    67   �� *MemberBorrowMedia+$ OneWay=�5+        5,   
   -   5        $��
memberGrid��5,      $��4��6%   $��Oblique$�62   $��2��6F   $��3��6V    .  $��6q�6�   $��20(�6�    5-        5.      $ Member��6%    65   �� *Name+$ OneWay=�50      �� 51   
   -   5        $��
lentButton��51      $
��Lent��6#   
�������$��2��6G   $��2��6X   $��14(�6~   �� 52   
   -   5        $��returnButton��52      $��Return��6%   
�������$��2��6J   $��3��6Z   $��14(�6�   �� 53   
   -   5        $��modifyMemberButton��53      $��Modify Member��6+   
�������$��2��6X   $��7��6i   $��14(�6�   �� 54   
   -   5        $��modifyMediaButton��54      $��Modify Media��6*   
�������$��3��6U   $��7��6e   $��14(�6�   �� 55   
   -   5        $��mediaInfoButton��55      $��
Media Info��6(   
�������$��4��6Q   $��7��6a   $��14(�6�   �� 56   
   -   5        $��memberInfoButton��56      $��Member Info��6)   
�������$��5��6S   $��7��6c   $��14(�6�   58      59      