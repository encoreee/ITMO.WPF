   M S B A M L   `   `   `  ����L  HITMO.WPF.NCommand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ITMO.WPF.NCommandITMO.WPF.NCommand  5   	   "    ITMO.WPF.NCommand.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ITMO.WPF.NCommand     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   o� $
��Left=�6   $	��20 ��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��774��6b   .@�5      m� $��Правка��6   $��20��6(   .@�5      m� $��Копировать��6    m� Command$
 Copy��6`    m� CommandTarget 6/   ��  �� ElementName$ 
MainWindow��6`   m� 5      $��Вырезать��6   $	 Cut��6^    6-   �� $ 
MainWindow��6^   m� 5      $��Вставить��6   $ Paste��6^    6-   �� $ 
MainWindow��6^   �� 5      -   5         ��Name$ textBox��5      $��23��6+    �� TextWrapping$
 Wrap=�67   $��TextBox��6K   $	��120��6Z   �� 5      -   5         ��Name$ richTextBox��5      $	��100��63   $	��100��6@   . �5      /� .T�5      J� .*�6$   .*�5      �� $�RichTextBox��6"   5      5      5      m� 5      $��MenuItem��6   $
��Left=�6-   $��20��6H   $��30��6T   5      m� 5      $��	Menu Item��6   $��20��6*   .@�5      m� $��Launch��6   $
��Left=�6+   $��20��6F   5      5      �� 5   
   $!��local:CustomCommands.Launch��6   $��Launch��67   $
��Left=�6H   $��	55,61,0,0q�6c   $	��Top=�6v   $��75��6�   $��15��6�   �� 5"   
   -   5         ��Name$ checkBox��5"      $��Enable Launch Command��6%   $
��Left=�6E   $��
160,61,0,0q�6`   $	��Top=�6t   5#      5$      