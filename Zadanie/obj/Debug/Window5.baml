   M S B A M L   `   `   `  ����B  >Zadanie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ZadanieZadanie  5   	       Zadanie.Window5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Zadanie     5   	     � Title$  Window5��5   	   $	��450��6   $	��800��6&    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ NikGrid��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6?   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Title+6Q     5      $	 Наименование��6>   $	
 110 6T    6%   �� *Name+6T     5      $	 Дата��6>   $
 70 6L    6%   �� *Date+6L   5      �� 5   
   $��Center=�6   $��1��62    �� Orientation$ 
Horizontal=�6?   $��174,0,206,0q�6X   $	��412��6m   .+�5      �� -   5         ��Name$ updateButton��5      $��Добавить��6+   6>   �� 5      -   5        $ 
sortButton��5      $��Сортировать��6)   6?   �� 5       -   5        $ 	addButton��5       $��Добавить��6(   6;   5!      5"      5#      