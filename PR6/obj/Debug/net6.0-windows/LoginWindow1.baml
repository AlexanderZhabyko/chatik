   M S B A M L   `   `   `  ����>  :PR6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PR6PR6  5   	       PR6.LoginWindow1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PR6     5   	     � Title$  LoginWindow1��5   	   $	��300��6   $	��450��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Stretch=�6   $
��Wrap=�64   $��Создать чат��6H   $��22(�6[    �� TextAlignment$ Center=�6i   $��Bottom=�6�   �� 5   
   $��Stretch=�6   $��1��64   $(��"Подкючиться к чату��6D   $��22(�6^   $ Center=�6l   $��Bottom=�6�   $
��Wrap=�6�   �� 5   
   $��Right=�6   $��4��62   $��0��6C   
���   �$��Stretch=�6_   $��2��6{   �� 5   
   -   5         ��Name$ 
ClientNick��5      $��1��6&   $��Stretch=�66   $��1��6T    �� TextWrapping$
 Wrap=�6a   $��Введите ник:��6u   $��Center=�6�   $��0,30,0,0q�6�   $	��120��6�   6�   �� 5   
   -   5        $ IPbox��5      $��1��6!   $��Stretch=�61   $��0,30,0,0q�6O   $��2��6a   $
 Wrap=�6n   $��введите айпи:��6�   $��Center=�6�   $	��120��6�   6�   �� 5   
   -   5         ��Name$ Toclient��5      $��1��6#   $��Подключиться��63   $��Stretch=�6J   $��3��6h   $��Center=�6u   $��
10,30,10,0q�6�   6�   �� 5   
   -   5        $ 
ServerNick��5      $��Stretch=�6&   $��1��6D   $
 Wrap=�6Q   $��Введите ник:��6e   $��Center=�6y   $	��120��6�   $��0,30,0,0q�6�   6�   �� 5   
   -   5        $ Toserver��5      $��Создать��6#   $��Stretch=�65   $��3��6S   $��Center=�6`   $��
10,30,10,0q�6{   6�   5      5      