   M S B A M L   `   `   `  ����F  BDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DataBindingDataBinding  5          DataBinding.MainWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:DataBinding     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      
�������.��5      � $��10q�6   .+�5   
   �� $	��100��5      $��20��5      $��0,0,20,0q�5      $��Right=�5      $	��Top=�5      
����  �$��➕Add Details��5      $��Times New Roman)�5      $
��Bold"�5      
���������5      �� *ShowWindowCommand+5      � 5   
   $��	0,30,0,10q�6   
������� � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5       �� $��2��5!      $	��500��5"      $��20q�5#      
���   ���5%      �� *People+ �� View 5&      �� 5'      .P�5(      ��  �� Width$	 120��5)      $
��Name��5+       �� DisplayMemberBinding 5*      ��  �� Path$
 Name�5+      �� 5,      $	 120��5-      $��Address��5/       5.      �� *	Address+5/      �� 50      $	 120��51      $��Number��53       52      �� *Number+53      �� 54      $	 100��55      $��Salary��57       56      �� *Salary+ �� StringFormat$ {0:C}��57      58      5:      5;      5<      5=      