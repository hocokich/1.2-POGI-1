   M S B A M L   `   `   `  ����F  BMinesweeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:lb8.Minesweeperlb8.Minesweeper  5   	        lb8.Minesweeper.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:lb8.Minesweeper     5   	     � Title$  Minesweeper by Sanyok��5   	   $	��800��6'   $	��900��64   $	��800��6@   $	��900��6P   .��5
      � -   5        $��MainGrid��5
      .+�5   
   �� -   5         ��Name$ Confirm��5      $��Подтвердить��6"   $��
401,10,0,0q�68   $	��Top=�6L   $��Center=�6d   $��44��6�   $	��116��6�   6�   �� 5   
   -   5        $ Restart��5      $	��⟳��6"   $��
550,19,0,0q�67   $	��Top=�6K   $��Center=�6c   $��20��6�   $��20��6�   {�.  6�   �� 5   
   -   5         ��Name$
 time��5      $��00:00:00��6"   $��
718,19,0,0q�68   $	��Top=�6L   $��Center=�6d   $��60��6�   $��Center=�6�   �� 5   
   -   5        $ 
countMines��5      $��-550,19,0,0q�68   $	��Top=�6M   $��Center=�6e   $��60��6�   �� 5   
   -   5         ��Name$ uName��5      $��-750,23,0,0q�68   $	��Top=�6M   $��Center=�6e   $	��120��6�    �� TextWrapping$
 Wrap=�6�   A� 5   
   -   5         A�Name$ GameGrid��5      $��Center=�6(   $��Center=�6E   $	��404��6`   $	��880��6m   $��0,0,0,10q�6y   �� 5   
   -   5        $	��lvl��5      $��
-64,21,0,0q�6   $��22��6P   $	��Top=�6\   $��Center=�6t   $	��326��6�    � SmallChange$ 1Q�6�    � Minimum$ 3Q�6�    � Maximum$ 20Q�6�   5      5      