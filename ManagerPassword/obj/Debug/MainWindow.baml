   M S B A M L   `   `   `  ����J  FManagerPassword, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManagerPasswordManagerPassword  5   	        ManagerPassword.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ManagerPassword     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � 	Resources 5	      +   %ManagerPassword.DateConverterPassword   dataConvPassword��%   &	          5
   
   6&   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��433* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��140* �6    � RowDefinitions 5   
   �� 5      $	��23* �6   �� 5      $��22.844 �6   �� 5      $	��24* �6   �� 5      $
��364* �6   .+�5   
   ]� $��4��6   .+�5      o� $	��Top=�6   .@�5      m� -   5        $��Add password��5      61   m� 5      -   5        $��Edit element��5      61   m� 5       -   5        $��Search��5       6+   m� 5!      $��Hidden password��6   .@�5"      m� -   5         m�Name$ MenuItemShowHiddenPwd��5"      $
��Show��6>    m� IsCheckable .  m� 	IsChecked .  6q   5#      m� 5$      -   5        $��Setting��5$      6,   m� 5%      -   5        $
��Help��5%      5&      5'      5(      �� 53   
   -   5         ��Name$ searchTextBox��53      $��0��6)   $��1��69   �� 54   
   -   5        	 ��Name$	 
whatSearch��54      $��1��6'   $��1��67   �� 55   
   -	   5        $��2��55   &   $��1��66   .��6C   Search6K   �� 56   
   -
   5        $��3��56   +   $��1��6;   .��6H   Show all elements6[   &   System.Windows.Controls.DataGrid  57   
   -   5        
  Name$
 userData��57         
IsReadOnly .    AutoGenerateColumns .  $��2��6�   $��2��6�     UserData#���  6�   $��4��6;   �� SelectedItem 6�   ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ title��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� $ title�  5:      $ username��6%    67   �� $ username�  5;      $ email��6%    64   �� $ email�  5<      $	 url��6%    62   �� $	 url�  5>      -   5        
textBoxPwd��$ password��5>   9      
Visibility$ 	Collapsed=�6�    6K   �� $ password� �� UpdateSourceTrigger$ PropertyChanged=�6�     5?      -   5        VisiblePassword��$ password��5?   >    6P   �� $ TwoWay=� �� ElementName$ 
textBoxPwd��$ password�$ PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5N      -   5        TemplateColumn��   CellTemplate 5O      �� 5P      .R�5Q      ��  ��Name$ btnShowHiddenPwd��6%   -   5         �� 	ClickMode$ Press=�5Q   ?   $y�Visible=�6Q   $��20��6f   $��20��6r   ��5R   "   �� 5S   &    ��Name$ ImageShowHiddenPwd��6,   $��Images/closed_eye.png��6H   5U      5V      5X        5Y      $
 note��6%    63   �� $
 note� � ContextMenu 5\      �� 5]      .@�5^      m� $
��Copy��6    m� Command$
 Copy��6-   m� 5_      -   5        $��Copy username��5_      66   m� 5`      -   5        $��
Copy email��5`      63   m� 5a      -   5        $��Copy password��5a      66   m� 5b      -   5        $��Copy url��5b      61   m� 5c      -   5        $��Folow a url��5c      64   m� 5d      -   5        $
��Edit��5d      6-   m� 5e      -   5        $��Delete��5e      6/   5f      5h      5k      5l      