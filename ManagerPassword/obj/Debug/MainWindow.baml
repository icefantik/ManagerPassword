   M S B A M L   `   `   `  ����J  FManagerPassword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManagerPasswordManagerPassword  5   	        ManagerPassword.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ManagerPassword     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $
��103* �6    � RowDefinitions 5   
   �� 5      $	��18* �6   �� 5      $	��79* �6   �� 5      $
��306* �6   �� 5      $	��19* �6   .+�5   
   ]� $��2��6   .+�5      o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $
��Open��6   m� 5      $��Close��6   m� 5      $
��Save��6   5      m� 5      $
��Edit��6   .@�5      m� $
��Edit��6   m� 5      -   5        $	��Add��5      6,   5      m� 5       -   5        $��Setting��5       6,   m� 5!      $
��Help��6   5"      5#      5$      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ userData��5%         
IsReadOnly .    AutoGenerateColumns . $��1��6�   $��1��6�   $��2��6�      UserData#���   6�    � ContextMenu 5&      �� 5'      .@�5(      m� $
��Copy��6    m� Command$
 Copy��6-   m� 5)      -   5        $��Copy username��5)      66   m� 5*      -   5        $��
Copy email��5*      63   m� 5+      -   5        $��Copy password��5+      66   m� 5,      -   5        $��Copy url��5,      61   m� 5-      -   5        $
��Edit��5-      6-   m� 5.      -	   5        $��Delete��5.      6/   5/      51      52      53      