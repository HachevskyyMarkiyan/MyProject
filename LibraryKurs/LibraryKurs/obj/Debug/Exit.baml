   M S B A M L   `   `   `  ����F  BLibraryKurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LibraryKursLibraryKurs  5   	       LibraryKurs.Exit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LibraryKurs     5   	     � Title$
  Exit��5   	   $	��146��6   $��463.194��6#    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5
   	   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6%    �� CenterX$	 0.5Q�63   �� 5      	 �� CenterY$		 0.5Q�6$   
 �� CenterX$	
 0.5Q�62   �� 5       �� Angle$	 -90Q�6&    �� CenterY$	 0.5Q�62    �� CenterX$	 0.5Q�6@   T� 5      5      .��5      �  � Color$ 	#FF002C78��6   � 5      $ White��6    � Offset$ 1Q�6)   � 5      $ 	#FFADAFD4��6   $ 0.896Q�6-   � 5      $ 	#FFC3C4DF��6   $ 0.661Q�6-   5      .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5   
   �� 5      $
��379* �6   �� 5      $
��181* �6   .+�5    
   �� $��Are you sure?��6   $
��Left=�6(   $��	15,10,0,0q�6C   $	��Top=�6V   ���	#FFD8D8D8$��Arial Black)�6�   $��36(�6�    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         Color$ 	#FF4B4B4B��6#      
BlurRadius$ 15Q�65   5$      �� 5%   
   $
��Left=�6   $	��137��6+   $	��Top=�68   $	��137��6P   $��Images/ExitPic.png��6\   $��1��6x   �� 5&   
   -   5         ��Name$ myImage3��5&      $
��Left=�6"   $��78��6=   $��	19,62,0,0q�6I   $	��Top=�6\   $��39��6t   $ 0.5,0.5&�6   z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+      $ -4.409Q�6&   T� 5,      5-      5/      �� 50   
   -   5         ��Name$ button��50      $	��Yes��6!   $
��Left=�6/   $��	15,85,0,0q�6J   $	��Top=�6]   $	��117��6u   $��42��6�   $��26.667(�6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF3434346�   �� 51   
   -   5        $ button_Copy��51      $��No��6&   $
��Left=�63   $��
164,85,0,0q�6N   $	��Top=�6b   $	��117��6z   $��42��6�   $��26.667(�6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF3434346�   52      53      