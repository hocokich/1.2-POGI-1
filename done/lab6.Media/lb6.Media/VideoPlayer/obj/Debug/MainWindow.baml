   M S B A M L   `   `   `  ����F  BVideoPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:VideoPlayerVideoPlayer  5   	       VideoPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:VideoPlayer     5   	     � Title$  VLC by Sanyok��5   	   $	��464��6   $	��800��6,   .��5	      � .+�5
   
   r� -   5         r�Name$ meVideo��5
      $��10,20,14,103q�6(    r� Stretch$
 Fill=�6>    r� LoadedBehavior$ Manual=�6M   �� 5   
   -   5         ��Name$ OpenFile��5      $��Открыть��6#   $	��Top=�6V   $
��Left=�6q   6�   �� 5   
   -   5        $ PlayBtn��5      $��▶️��6#   $��0,0,50,8q�61   $��Bottom=�6W   $��Center=�6r   $��18��6�   �� 5   
   -   5        $ PauseBtn��5      $��⏸︎��6#   $��0,0,0,8q�60   $��Bottom=�6V   $��Center=�6q   �� 5   
   -   5        $ StopBtn��5      $��⏹️��6#   $��	0,0,-50,8q�60   $��Bottom=�6V   $��Center=�6q   �� 5   
   -   5         ��Name$ timeLine��5      $��0,0,0,33q�60    � Maximum$	 100Q�6D   $��Bottom=�6V   $��Center=�6q   $��18��6�   $	��424��6�   6�   �� 5   
   -   5        $ 
SldrVolume��5      $��
0,0,-440,8q�60   $ 1Q�6D   $��Bottom=�6V   $��Center=�6q   $��96��6�   $��20��6�    �� Orientation$ Vertical=�6�    � SmallChange$
 0.05Q�6�   �� 5   
   -   5        	 ��Name$	 	lbMaxTime��5      $��00:00:00��6'   $��0,0,-370,10q�6:   $��Bottom=�6V   $��Center=�6q   $��54��6�   $��25��6�   �� 5   
   -	   5        $	 lbCurrentTime��5      $��00:00:00��6'   $��
0,0,370,10q�6:   $��Bottom=�6V   $��Center=�6q   $��54��6�   $��25��6�   5      5      