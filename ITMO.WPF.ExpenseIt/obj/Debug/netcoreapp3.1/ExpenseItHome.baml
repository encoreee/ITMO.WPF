   M S B A M L   `   `   `  ����  
ExpenseIt9    ExpenseIt.ExpenseItHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  ExpenseIt - Home��5      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath  nameItemTemplate �� XPath �� Path �� RelativeSource �� AncestorType��%<  &	        &	 �    � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                            <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                            <Expense ExpenseType="Gift" ExpenseAmount="125" />
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                            <Expense ExpenseType="New machine" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                    </Expenses>        5%      �� 5'      .R�5.      �� ��6   �� $ @Name����5/      �� $ 
Foreground� �� " ��50      51      ��52   
   �� 53       �� ImageSource$ watermark.png��6    � ColumnDefinitions 55   
   �� 56      $	��230 �6   �� 57      	 � RowDefinitions	 59   
   �� 5:      �� 5;      $
��Auto �6   �� 5<      �� 5=      $
��Auto �6   .+�5B   
   �� -   5        
 ��Name$
 
LiveRegion��5B      4  .System.Windows.Automation.AutomationProperties   LiveSetting$ 	Assertive=�6$   $��1��6Q     HeaderTextStyle#��[ 6a   .��6�   View Expense Report5D      �� 5F   
   $��1��6   $��1��6!     ListHeaderStyle#��[ 6.   ._�5G      ��   ListHeaderTextStyle#��[ 6   .��6A   Names6H   5H      �� 5J   
   -   5        $��peopleListBox��5J         Name$ Names��5K      $��1��5L      $��2��6"   #��[ 5N      ��5M      ��  �� Source# [  $ Person�� 5O       �� 
TargetType �� BasedOn �� Property �� Value��%l   '��       7���� 5T      " ��6   8   .�5U      ��  �@ Name 6B   �� $ @Name��5V      5W      5X      �� 5[   
   -   5        $��1��5[      $��3��6!     ButtonStyle#��[ 6C   .��6h   View6n   5]      5_      