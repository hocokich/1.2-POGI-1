   M S B A M L   `   `   `  ����F  BSoundPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SoundPlayerSoundPlayer  5   	       SoundPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SoundPlayer     5   	     � Title$  Spotify by Sanya��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;   .��5	      � .+�5
   
   �� -   5         ��Name$ OpenFile��5
      $��Открыть��6#   $
��Left=�65   $��	78,10,0,0q�6P   $	��Top=�6c   6{   �� 5   
   -   5         ��Name$ ListOfTracks��5      $��13,35,607,58q�6(   6>   �� 5   
   -   5         ��Name$ timeLine��5      $
��Left=�6&   $��195,359,0,0q�6A   $	��Top=�6V    �� Orientation$ 
Horizontal=�6n   $	��468��6�    � Maximum$	 100Q�6�   6�   �� 5   
   -   5        $ SBvoluem��5      $��668,244,0,0q�6&   $	��132��6;   $��17��6H    � SmallChange$
 0.05Q�6S   $	��Top=�6�   $
��Left=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   	 � Value$		 0.2Q�6�   z�5      V� 5      .~�5      �� 
 �� ScaleY$
 -1Q�6%   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        $ StopBtn��5      $��⏹️��6"   $
��Left=�6/   $��450,381,0,0q�6J   $	��Top=�6_   $��32��6w   {�.  6�   �� 5   
   -   5         ��Name$ 	TrackName��5      $�� ��6#   $
��Left=�6.   $��230,206,0,0q�6I   $	��Top=�6^   $	��398��6v   $��24(�6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ lbCurrentTime��5      $��00:00��6'   $
��Left=�67   $��198,378,0,0q�6R   $��40��6g   $��25��6r   $	��Top=�6~   �� 5   
   -   5        $ 	lbMaxTime��5      $��00:00��6#   $
��Left=�63   $��623,379,0,0q�6N   $	��Top=�6c   $��40��6{   $��25��6�   �� 5   
   -	   5        $ Shuffle��5      $
��🔀��6"   {�. $
��Left=�6@   $��
161,0,0,33q�6[   $��32��6o   $��20��6z   $��Bottom=�6�   6�   �� 5   
   -
   5        $ Repeat��5      $
��🔁��6!   {�.  $
��Left=�6@   $��
124,0,0,33q�6[   $��32��6o   $��20��6z   $��Bottom=�6�   6�   �� 5   
   -   5        $ PlayOrPauseBtn��5      $��▶️��6)   $
��Left=�66   $��413,381,0,0q�6Q   $	��Top=�6f   $��32��6~   6�   5      5      