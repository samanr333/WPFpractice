   M S B A M L   `   `   `  ����F  BDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DataBinding.ViewsDataBinding.Views  5      !    DataBinding.Views.AddPerson   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:DataBinding.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  	AddPerson��5      $	��800��5	      $	��450��5
       � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  TextBoxStyle��%�  &	        &	 �     �� 5   
   " ��6#   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 15(�6)   5      �� 5   
   " ��6%   .�5      ��  � ��$	 150��6&   �� 5       � ��$ 20��6'   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��
 �   �6,   5      5      .��5      � .+�5   
   � $��250,100,250,100q�6    � RowDefinitions 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5%      �� $��Center=�5&      $��30(�5'      $
��Bold"�5(      
����+��$��Details��5*      �� 5+      $��1��5,      $
��Name��5-      #��[  5.      �� 5/      $��1��51      #��[ 52      ��50      �� *Name+52      �� 53      $��2��54      $��Address��55      #��[  56      �� 57      $��2��59      #��[ 5:      ��58      �� *	Address+5:      �� 5;      $��3��5<      $��Phone��5=      #��[  5>      �� 5?      $��3��5A      #��[ 5B      ��5@      �� *Number+5B      �� 5C      $��4��5D      $��Salary��5E      #��[  5F      �� 5G      $��4��5I      #��[ 5J      ��5H      �� *Salary+5J      �� 5K      $��5��5L      $��60��5M      $��20��5N      
����  �$��ADD ➕��5P      $
��Bold"�5R      
���������5Q      �� *AddPersonCommand+5S      5T      5U      5V      