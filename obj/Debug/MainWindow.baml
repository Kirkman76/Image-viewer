   M S B A M L   `   `   `  ����G  CImageGallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ImageGalleryImageGallery  5   	       ImageGallery.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ImageGallery     5   	   -   5          � Title$  
GalleryWin��5   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   $��Goudy Old Style)�6k   $��14(�6�   $��Medium"�6�   .��5	      ]� $
��auto��6   $
��auto��6   .+�5
   
   �� $
��auto��6   $
��Left=�6   $	��180��65   
�������.+�5      �� -   5         ��Name$ foldersList��5      $	��297��6+    �� Left$ 24��68   
 �� Top$ 75��6I   $	��134��6Y   $��Goudy Old Style)�6�   $��14(�6�   $��Normal"�6�   �� 5      -   5        $��Открыть��5      $ 52��6'   $ 42��68   $��75��6H   $��Normal"�6S   $��Goudy Old Style)�6g   $��12(�6�   6�   �� 5      $#��Открыть галерею��6   $ 33��6.   $ 10��6?   5      �� 5   
   $
��auto��6   $��Right=�6   $	��180��66   
������� K� ZIndex$ 1��6_   .+�5      9� -   5        $��propertiesExp��5      $'��!Свойства картинки��6,   $	��159��6G   $ 10��6T   $ 46��6e   $	��151��6u   $��Goudy Old Style)�6�   $��14(�6�   $��Normal"�6�   .��5      � ���	#FFE5E5E56   5      5      � 5   
   $	��150��6   $��Bottom=�6   $
��auto��64   
�������$ 1��6U    � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6#   �� 5      .+�5      �� -   5         ��Name$ 	imgSlider��5      $
��Left=�6(   $	��350��6C   $��1��6O   $��0, 50, 0, 0q�6_   6t   �� 5      -   5         ��Name$ imgNumTxtBox��5      $��1��6,   $
��Left=�6<   $��23��6W   $��157,93,0,34q�6c    �� TextWrapping$
 Wrap=�6x   $��1��6�   $��32��6�   	 J� RenderTransformOrigin$	 1.037,0.514&�6�   $��Goudy Old Style)�6�   $
��Bold"�6�   $��14(�6�   6  �� 5      -   5        
 ��Name$
 prevBtn��5      $
��Prev��6&   $��1��65   $��17,112,278,16q�6E   $��55��6\   $��21��6g   $
��Bold"�6�   $��Goudy Old Style)�6�   $��14(�6�   �� 5      -   5        $��nextBtn��5      $
��Next��6$   $��1��63   $��277,112,18,16q�6C   $��55��6[   $��21��6f   $
��Bold"�6�   $��Goudy Old Style)�6�   $��14(�6�   5      �� 5   
   -	   5         ��Name$ imgContainer��5      $
��auto��6-   $
��auto��6;   .��5       �� -
   5         ��Name$ imageBig��5       $
��auto��6&   $ 0��64   $ 0��6D   $
��auto��6S   $ 0��6`   5!      5#      5$      