   M S B A M L   `   `   `  ����U  QparallelProgrammingProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:parallelProgrammingProjectparallelProgrammingProject  5   	   +    %parallelProgrammingProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:parallelProgrammingProject     5   	     � Title$;  5Parallel Programming Project - Guillem Arrojo Sanchez��5   	   $	��450��6G   $	��800��6T    � 	Resources 5	         TextBoxStyle �� 
TargetType �� Property �� Value��%W   &	        �� 5
   
   " ��6%   .�5      ��  � ��$ 0,0,0,1q�60   5      5      .��5      � $��60, 15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $
��Dni:��6   $��0��6   $��0��6,   $��Center=�6<   $��Right=�6W   $��0,0,15,0q�6s   6�   �� 5    
   $��Nombre:��6   $��1��6"   $��0��6/   $��Center=�6?   $��Right=�6Z   $��0,0,15,0q�6v   6�   �� 5!   
   $��Mail:��6   $��2��6    $��0��6-   $��Center=�6=   $��Right=�6X   $��0,0,15,0q�6t   6�   �� 5$   
   -   5         ��Name$ 
TextBoxDni��5$   8   #��[  6   $��0��6L   $��1��6Y   $��Center=�6i   6�   �� 5%   
   -   5        $ TextBoxNombre��5%   8   #��[  6   $��1��6O   $��1��6\   $��Center=�6l   6�   �� 5&   
   -   5        $ TextBoxMail��5&   8   #��[  6   $��2��6M   $��1��6Z   $��Center=�6j   6�   �� 5)   
   -   5         ��Name$ ButtonValidarDni��5)      $��3��6+   $��2��68   $��Center=�6L   $��0,0,0,0q�6g   ��5*      �� 5+      $��Comprobar DNI��6   62   5-      �� 50   
   -   5        	 ��Name$	 LabelValido��50      $��4��6%   $��2��62   $��Center=�6F   
��� ��$��EL DNI ES VALIDO��51   (   $��Center=�6C   $y�Hidden=�6g   6}   �� 54   
   -   5        $	 LabelNoValido��54      $��4��6'   $��2��64   $��Center=�6H   
���  ��$��EL DNI NO ES VALIDO��55   !   $��Center=�6?   $y�Hidden=�6c   6y   � 58   
   $��5��6   $��2��6    59      �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   .+�5?      �� $��0��6   .+�5@      �� $��Time CODE 1��6   �� 5A      -   5        $	 TimingCode1��5A      6/   5B      �� 5D      $��1��6   .+�5E      �� $��Time CODE 2��6   �� 5F      -   5        $	 TimingCode2��5F      6/   5G      �� 5I      $��2��6   .+�5J      �� $��Time CODE 3��6   �� 5K      -	   5        $	 TimingCode3��5K      6/   5L      5M      5N      5O      