   M S B A M L   `   `   `  ����A  =Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ServerServer  5   	       Server.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Server     5   	   -   5          � Title$  Server��5   	   $	��450��6   $	��650��6%    � 
ResizeMode$ NoResize=�63   .��5	      � .+�5
   
   �� -   5         ��Name$ Start��5
      $��
Старт��6    $��
70,324,0,0q�60   $	��Top=�6D   $��66��6\   $
��Left=�6h   $	��153��6�   6�   �� 5   
   -   5        $
 Stop��5      {�.  $��Стоп��61   $��229,324,0,0q�6@   $	��Top=�6U   $��66��6m   $
��Left=�6y   $	��152��6�   6�   �� 5   
   -   5         ��Name$ 	ServerLog��5      $��	70,41,0,0q�6P   $	��278��6c   $	��Top=�6p   $
��Left=�6�   $	��310��6�   �� 5   
   $��Server log:��6   $
��Left=�6&   $��	71,10,0,0q�6A   $	��Top=�6T   �� 5   
   $��Online clients:��6   $
��Left=�6*   $��
409,10,0,0q�6E   $	��Top=�6Y   $��87��6q   �� 5   
   -   5         ��Name$ OnlineClients��5      $��0��6'   $
��Left=�63   $��
496,10,0,0q�6N   $	��Top=�6b   $��64��6z   �� 5   
   -   5        $ ClearLog��5      $��Очистить лог��6#   $��
409,41,0,0q�6:   $	��Top=�6N   $��33��6f   $
��Left=�6r   $	��153��6�   6�   �� 5   
   -   5        $ DownloadLog��5      $��Скачать лог��6&   $��
409,79,0,0q�6<   $	��Top=�6P   $��33��6h   $
��Left=�6t   $	��153��6�   6�   �� 5   
   -   5         ��Name$ ClearLogSign��5      $
��Left=�6)   $��
567,49,0,0q�6D   $	��Top=�6X   $��16��6p   $��16��6|   5      5      