   M S B A M L   `   `   `  ����>  :PR6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PR6PR6  5   	       PR6.TcpServerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:PR6     5   	   -   5          � Title$  TcpServerWindow��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��129* �6   �� 5      $	��38* �6   �� 5      $
��168* �6   �� 5      $
��115* �6    � RowDefinitions 5   
   �� 5      $	��12* �6   �� 5      $
��119* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ userlist��5      $��1��6%   �� 5   
   -   5        $ MSGlist��5      $��2��6#   $��1��6^   $��2��6k   �� 5   
   $
��Wrap=�6   $��Пользователи:��6)    �� TextAlignment$ Center=�6>   �� 5   
   -   5         ��Name$ sendBTN��5      $��3��6"   $��12(�62   $��Отправить��6@   $��2��6T   $��2,2,2,2q�6a   6r   �� 5   
   -   5        $ ExitBtn��5      $��3��6"   $��
Выйти��62   $��Center=�6B   $��Center=�6_   6z   �� 5   
   -   5         ��Name$ 
messegeTBX��5      $��2��6&   $��Stretch=�66   $��2��6T    �� TextWrapping$
 Wrap=�6a   $(��"Введите сообщение:��6u   $��Stretch=�6�   $��2,2,2,2q�6�   6�   �� 5   
   -   5        $ 
LogsButton��5      $#��Посмотреть логи��6%   $��Center=�6?   $��2��6\   $��Center=�6i   6�   �� 5   
   -   5         ��Name$ serverIP��5      $��2��6&   $��Center=�66   $
��Wrap=�6S   $��Ваш айпи: ��6g   $��Center=�6y    � 5   
   -	   5        	  �Name$	 	LogsFrame��5      
�������$y�Hidden=�66   $��2��6J   5      5      