   M S B A M L   `   `   `  ����R  NCSharp.Net-FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CSharp.Net_FinalProjectCSharp.Net_FinalProject  5   	   (    "CSharp.Net_FinalProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CSharp.Net_FinalProject     5   	   -   5          � Title$  PC Budget Planning��5   	   $	��380��6$   $	��600��61   .��5	      ]� $��20q�6   .+�5   
   �  � IsSharedSizeScope .  � RowDefinitions 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $��0��6   $��0��6&   $��3��66   .+�5      �� -   5        $��Add Part��5      $��80��6,   $��30��67   $��0,0,0,1q�6C    � ToolTip$( "Add a new PC Part into the system.��6T   6�   �� 5      -   5        $��Remove Part��5      $��80��6/   $��30��6:   $��0,0,0,1q�6F   $' !Remove a PC Part from the system.��6W   6�   5      �� 5       $
��5, 0q�6   $��1��6'   $��0��67   $��4��6D   .+�5"      �� .��6   CPU6   �� 5#      -   5         ��Name$ cb_CPU��5#       �� DisplayMemberPath$
 Name��6P    �� SelectedValuePath$
 Cost��6i   ��6+   ��  �� Path$ cpuList�6�   �� 5%      .��6   GPU6   �� 5&      -   5        $ cb_GPU��5&      $
 Name��6P   $
 Cost��6i   ��6+   �� $ gpuList�6�   �� 5(      .��6   Motherboard6%   �� 5)      -   5        $ cb_MB��5)      $
 Name��6N   $
 Cost��6g   ��6*   �� $ mbList�6�   �� 5+      .��6   RAM6   �� 5,      -   5        $ cb_RAM��5,      $
 Name��6P   $
 Cost��6i   ��6+   �� $ ramList�6�   �� 5.      .��6   	Storage6!   �� 5/      -   5        $ 
cb_Storage��5/      $
 Name��6X   $
 Cost��6q   ��6/   �� $ storageList�6�   ]� 51      $��0, 10q�6   .+�52      �� -	   5        $
��Left=�52      $��80��63   .��6R   Reset6Y   �� 53      -
   5        	 ��Name$	 lb_TotalCost��53      $��Right=�62   $��0��6I   6W   �� 54      $��Right=�6   $��Right=�63   $��Total Cost: $��6V   6p   56      58      5:      5<      5>      