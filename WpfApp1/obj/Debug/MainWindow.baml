   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   
������   � Topmost  .  � Title$ 
MainWindow��5
   	   $��30��6   $��83.783��6(    � AllowsTransparency .  � WindowStyle$
 None=�6Q   .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��	-4,-2,0,7q�6+   $
��Left=�6>   $��85��6Y    � ColumnDefinitions 5   
   �� 5      $	��46* �6   �� 5      $��5* �6   �� 5      $	��34* �6   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.458Q�6"   T� 5      5      .+�5   
   �� $
��CPU:��6   $
��Left=�6   $	��Top=�6:   $��23��6R   ���	#FF52DC12$
��Bold"�6u   $��0,-6,0,0q�6�   �� 5   
   -   5         ��Name$ cpuTempFull��5      $��Label��6%   $
��Left=�65   $��	34,-6,0,0q�6P   $	��Top=�6c   $��30��6{   $��23��6�   ���	#FF52DC12$
��Bold"�6�   $��3��6�   �� 5   
   -   5        $ cpuTempMaxFull��5      $��Label��6(   $
��Left=�68   $��4.722,-6,-1,0q�6S   $	��Top=�6j   $��30��6�   $��23��6�   ���	#FF52DC12$
��Bold"�6�   $��2��6�   �� 5   
   $
��GPU:��6   $
��Left=�6   $��0,6,0,-4q�6:   $	��Top=�6L   $��23��6d   ���	#FF56FF07$
��Bold"�6�   �� 5   
   -   5        $ gpuTemp��5      $��Label��6!   $
��Left=�61   $��	34,6,0,-4q�6L   $	��Top=�6_   $��30��6w   $��23��6�   ���	#FF52DC12$
��Bold"�6�   $��3��6�   �� 5   
   -   5        $ 
gpuTempMax��5      $��Label��6$   $
��Left=�64   $��4.722,6,-1,-4q�6O   $	��Top=�6f   $��30��6~   $��23��6�   ���	#FF52DC12$
��Bold"�6�   $��2��6�   5       5!      