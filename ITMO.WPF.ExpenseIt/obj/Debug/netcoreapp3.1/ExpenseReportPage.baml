   M S B A M L   `   `   `  ����  
ExpenseIt9!    ExpenseIt.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$%  ExpenseIt - View Expense Report��5      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @ExpenseAmount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       .+�5$   
   �� -   5         ��Name$ 
LiveRegion��5$      4  .System.Windows.Automation.AutomationProperties   LiveSetting$ 	Assertive=�6$   $��1��6Q     HeaderTextStyle#��[ 6a   .��6�   Expense Report For:5&      � 5'   
   $��10q�6   $��1��6   $��1��6+    5)      �� 5*      �� 5+       5-      �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      .+�54      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�55      ��   
LabelStyle#��[ 6   .��6<   Name:6C   �� 56      -   5        $ NameLiveRegion��56      $ 	Assertive=�60   #��[ 6]   ��6�   �� $ @Name��6�   57      �� 5:      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5;      �� #��[ 6   .��6<   Department:6I   �� 5<      #��[ 6   ��6<   �� $ @Department��6d   5=      � 5>      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\   .+�5A      &   System.Windows.Controls.DataGrid  	   Name$	 Expense report��6     ColumnHeaderStyle
   ColumnHeaderStyle#
 [ 6l      AutoGenerateColumns$ False��6�      RowHeaderWidth$ 0Q�6�      CanUserResizeColumns$ False��6�      CanUserResizeRows$ False��6�   ��6F   �� $ Expense�� 5B      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� BasedOn �� Property �� Value��%j   '        7 �� 5G      "  6    8   .�5H      ��  �@ Name$ DataGrid Row��6J   5I      5J         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� $ @ExpenseType��  5M      $ Amount��6-    6=   �� $ @ExpenseAmount��5O      5Q      5R      5T      5V      