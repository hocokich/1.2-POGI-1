   M S B A M L   `   `   `  ����C  ?TimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad1zad1  5   	       zad1.AddTimerWnd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad1     5   	     � Title$#  Добавить таймер��5   	   $	��440��6!   $	��307��6.    � 
ResizeMode$ NoResize=�6:   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $��Имя:��6   $
��Left=�6   $��38,6,0,0q�6:   $	��Top=�6L   $��1��6d   $��26��6t   $��36��6�   �� 5   
   $��Часы��6   $
��Left=�6   $��
119,37,0,0q�6:   $	��Top=�6N   $��26��6f   $��38��6r   �� 5   
   $��Минуты��6   $
��Left=�6!   $��
203,37,0,0q�6<   $	��Top=�6P   $��26��6h   $��54��6t   �� 5   
   $��Секунды��6   $
��Left=�6"   $��	13,37,0,0q�6=   $	��Top=�6P   $��2��6h   $��26��6x   $��57��6�   �� 5   
   -   5         ��Name$ HourWPF��5      $
��Left=�6#   $��
109,68,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $��59��6~   $��18��6�   �� 5   
   -   5        $ 	MinuteWPF��5      $
��Left=�6%   $��
203,68,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $��60��6�   $��18��6�   �� 5   
   -   5        $ 	SecondWPF��5      $
��Left=�6%   $��	11,68,0,0q�6@   $
 Wrap=�6S   $	��Top=�6g   $��59��6   $��2��6�   $��0��6�   $��18��6�   �� 5   
   -   5         ��Name$ AddTimer��5      $��Добавить��6#   $��Center=�66   $��
0,344,0,38q�6S   $	��248��6g   $��1��6�   $��2��6�   �� 5   
   -   5        $ TimerNameWPF��5      $
��Left=�6(   $��
100,10,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��178��6�   $��1��6�   $��18��6�   $��2��6�   $
��name��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ CalendarWPF��5      $��Center=�6(   $��	0,135,0,0q�6E   $	��Top=�6X   $	��209��6p   $	��248��6}   $��1��6�   $��2��6�   5      5      