   M S B A M L   `   `   `  ����J  FManagerPassword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManagerPasswordManagerPassword  5   	   #    ManagerPassword.AddElemWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ManagerPassword     5   	     � Title$  AddElemWindow��5   	   $	��130��6   $	��550��6,    � 
ResizeMode$ NoResize=�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��75* �6   �� 5      $	��60* �6   �� 5      $	��25* �6   �� 5      $	��78* �6   �� 5      $	��77* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��20* �6   �� 5      $	��35* �6   .+�5   
   �� -   5        $��textboxTitle��5      $��1��6&   $��1��63   $��0��6G   $��12(�6W    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6z    �� 	IsEnabled .  � Language$ en-US�6�   �� 5   
   -   5        $��textboxUsername��5      $��1��6)   $��1��66   $��1��6J   $��12(�6Z    . $
 Wrap=�6}    . $ en-US�6�   �� 5   
   -   5        $��textboxEmail��5      $��1��6&   $��1��63   $��2��6G   $��12(�6W    . $
 Wrap=�6z    . $ en-US�6�   �� 5   
   -   5        $��
textboxUrl��5      $��1��6$   $��1��61   $��3��6E   $��12(�6U    . $
 Wrap=�6x    . $ en-US�6�   �� 5    
   -   5        $��textboxPassword��5       $��1��6)   $��4��66   $��12(�6F   $ en-US�6T   $��2��6e   �� 5"   
   -   5        $��1��5"      $��5��6   .��5#      �� $��Images/image_gen_pwd.jpg��6   5$      �� 5&   
   -   5        $��textboxNote��5&      $��1��6%   $��1��62   $��6��6G   $��12(�6W    . $
 Wrap=�6z    . $ en-US�6�   �� 5'   
   -   5        $��btnAdd��5'      $	��Add��6   $��7��6-   $��1��6=   $��1��6J   6[   5(      5)      