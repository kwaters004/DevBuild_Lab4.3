   M S B A M L   `   `   `  ����D  @Interface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Interface	Interface  5   	       Interface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Interface     5   	     � Title$  Prime Numbers��5   	   $	��400��6   $	��800��6/   $	��400��6>   $	��800��6N   ���	#FFB4ACAC.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $
��auto �6   �� 5      $��35 �6   �� 5      $
��auto �6   �� 5      $��35 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��20��61   $��50��6@   $��Let's locate some primes!��6N   $��Brush Script MT)�6o   $��50(�6�   $��2��6�   �� 5   
   $��1��6   $��3��6$   $&�� Which prime are you looking for?��61   $��20(�6Y   $��5q�6g   �� 5   
   -   5         ��Name$ inputBox��5      $��2��6$   $��3��64   $	��100��6A   $��5q�6P   $��Center=�6[   $��Center=�6   �� 5   
   -   5        $��3��5      $��3��6!   $��5q�6/   $��Submit��6:    �� 	IsDefault$
 True��6`   �� 5   
   -   5         ��Name$ errorBox��5      $��2��6&   $��4��66   
���  ��$��Center=�6U   $	��Top=�6r   �� 5   
   -   5        $ 	outputBox��5      $��1��6'   $��5��67   $��3��6D   $��Center=�6X   $��Center=�6u   $��50(�6�   �� 5    
   $��1��6   $��3��6!   $U��OThis application will find you any prime, in order, from first prime number on.��5!      $
��Wrap=�5"      $��	90,0,10,0q�6(    �� TextAlignment$ Right=�5#      $��Center=�6*   $��14(�5$      � 5%   
   -   5         �Name$ progressBar��5%      $��1��6+   $��5��6;   $��10, 80q�6H   $��3��6X   5(      5)      