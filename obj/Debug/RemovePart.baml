   M S B A M L   `   `   `  ����R  NCSharp.Net-FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CSharp.Net_FinalProjectCSharp.Net_FinalProject  5   	   (    "CSharp.Net_FinalProject.RemovePart   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CSharp.Net_FinalProject     5   	     � Title$  Remove Part��5   	   $	��280��6   $	��300��6*   .��5	      �� $��10q�6   .+�5   
   �� $
��Type��6   6!   �� 5   
   -   5         ��Name$ cb_Type��5      $	��120��6$   $
��Left=�60   .@�5      �� .��6   CPU6    �� 5      .��6   GPU6    �� 5      .��6   MB6   �� 5      .��6   RAM6    �� 5      .��6   	Storage6$   5      �� 5   
   -   5         ��Name$ lb_part��5      $
��Part��6!   $y�	Collapsed=�60   6I   �� 5   
   -   5        $ cb_CPU��5       �� DisplayMemberPath$
 Name��6J    �� SelectedValuePath$
 Name��6c   $	��120��6|   $
��Left=�6�   $y�	Collapsed=�6�   ��6#   ��  �� Path$ cpuList�6�   �� 5   
   -   5        $ cb_GPU��5      $
 Name��6J   $
 Name��6c   $	��120��6|   $
��Left=�6�   $y�	Collapsed=�6�   ��6#   �� $ gpuList�6�   �� 5   
   -   5        $ cb_MB��5      $
 Name��6H   $
 Name��6a   $	��120��6z   $
��Left=�6�   $y�	Collapsed=�6�   ��6"   �� $ mbList�6�   �� 5   
   -   5        $ cb_RAM��5      $
 Name��6J   $
 Name��6c   $	��120��6|   $
��Left=�6�   $y�	Collapsed=�6�   ��6#   �� $ ramList�6�   �� 5   
   -   5        $ 
cb_Storage��5      $
 Name��6R   $
 Name��6k   $	��120��6�   $
��Left=�6�   $y�	Collapsed=�6�   ��6'   �� $ storageList�6�   ]� 5   
   .+�5      �� -   5        $��0, 15q�5      $��60��6$   $
��Left=�6/   .��6[   OK6_   �� 5      -	   5        $��0, 15q�5      $��60��6$   $
��Left=�6/   .��6_   Cancel6g   5      5      5       