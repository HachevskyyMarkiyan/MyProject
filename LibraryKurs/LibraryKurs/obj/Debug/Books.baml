   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   F BLibraryKurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LibraryKursLibraryKurs 5   	      LibraryKurs.Books   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LibraryKurs     5   	     � Title$  Books��5	   	    � 
ResizeMode$ NoResize=�6   $	��768��6-   $
��1360��6:    � WindowStartupLocation$ CenterScreen=�5
   	   ��5      �� 5   
    �� ImageSource$ Images/MainBack.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ button��5      $��
Add a book��6!   $
��Left=�66   $��	31,38,0,0q�6Q   $	��Top=�6d   $	��373��6|   $��90��6�   ���	#CCFF672C
�������$��60(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6�   6  �� 5   
   -   5        $ button_Copy��5      $��Search by name��6&   $
��Left=�6?   $��
31,152,0,0q�6Z   $	��Top=�6n   $	��373��6�   $��90��6�   ���	#CCFFC500
�������$��45(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6  6  �� 5   
   -   5        $ button_Copy1��5      $
��Back��6'   $
��Left=�66   $��
31,615,0,0q�6Q   $	��Top=�6e   $	��373��6}   $��90��6�   ���	#CCFF2C2C
�������$��60(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6�   6  �� 5   
   -   5        $ button_Copy2��5      $��Search by genre��6'   $
��Left=�6A   $��
31,266,0,0q�6\   $	��Top=�6p   $	��373��6�   $��90��6�   ���	#CCFFC500
�������$��45(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6  6  �� 5   
   -   5        $ button_Copy3��5      $��Search by author��6'   $
��Left=�6B   $��
31,380,0,0q�6]   $	��Top=�6q   $	��373��6�   $��90��6�   ���	#CCFFC500
�������$��45(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6  6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
451,38,0,0q�6@   $	��Top=�6T   $	��556��6l   $	��864��6y      AlternatingRowBackground
 ����� �� AlternationCount$ 2��6�   6�   �� 5   
   -   5        $ 
RefreshBtn��5      $��Refresh��6%   $
��Left=�67   $��942,615,0,0q�6R   $	��Top=�6g   $	��373��6   $��90��6�   ���	#CCFF2C2C
�������$��60(�6�   $��Italic$�6�   $��Sitka Display)�6�   $
��Bold"�6�   6  5      5      