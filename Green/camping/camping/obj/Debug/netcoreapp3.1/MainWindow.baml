   M S B A M L   `   `   `  ����B  >camping, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:campingcamping  5   	       camping.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:camping     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Vul de begin datum in:��6   $
��Left=�61   $��	50,43,0,0q�6L   $	��Top=�6_   �� 5   
   $��Vul de eind datum in:��6   $
��Left=�60   $��	50,95,0,0q�6K   $	��Top=�6^   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ lastDateText��5      $
��Left=�6+   $��189,101,0,0q�6F   $	��Top=�6[      FirstDayOfWeek$ Monday=�6s      IsTodayHighlighted$
 True��6�      SelectedDateFormat$ Short=�6�   6�   �� 5   
   -   5         ��Name$ 
outputText��5      $
��Left=�6&   $��170,355,0,0q�6A   $��0 Euro��6V    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�     5   
   -   5        $ firstDateText��5      $
��Left=�6,   $��
189,45,0,0q�6G   $	��Top=�6[   $ Monday=�6s   $
 True��6�   $ Short=�6�   6�   �� 5   
   -   5         ��Name$ calculateButton��5      $��Bereken��6*   $
��Left=�6<   $��239,319,0,0q�6W   $	��Top=�6l   6�   �� 5   
   $��Te betalen prijs:��6   $
��Left=�6,   $��
49,351,0,0q�6G   $	��Top=�6[    J� RenderTransformOrigin$ -0.068,-0.75&�6s   $	��103��6�   �� 5   
   -   5        $ amountOfMeters��5      $
��Left=�6*   $��189,159,0,0q�6E   $��10��6Z   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $��Hoeveel meter grond?��6   $
��Left=�6/   $��
50,155,0,0q�6J   $	��Top=�6^   �� 5   
   $D��>Elke meter extra kost 3 euro en elke meter korter kost 2 euro.��6   $
��Left=�6Y   $��
66,181,0,0q�6t   $	��Top=�6�   $��9(�6�   �� 5   
   -   5        $ amountOfPersons��5      $
��Left=�6+   $��189,217,0,0q�6F   $��1��6[   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $��Hoeveel personen?��6   $
��Left=�6,   $��
50,213,0,0q�6G   $	��Top=�6[   �� 5   
   $��Hoeveel honden?��6   $
��Left=�6*   $��
50,253,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ amountOfDogs��5      $
��Left=�6(   $��189,257,0,0q�6C   $��0��6X   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $��Auto bij de tent?��6   $
��Left=�6,   $��
50,284,0,0q�6G   $	��Top=�6[   �� 5   
   -   5        $ amountOfCars��5      $
��Left=�6(   $��189,288,0,0q�6C   $��0��6X   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $
��Left=�6   $��492,103,0,0q�6/   $��Prijslijst:��6D   $
��Wrap=�6W   $	��Top=�6k   $��15(�6�   $��22��6�   $��56��6�   �� 5   
   $
��Left=�6   $��482,188,0,0q�6/   $��Per Persoon: 5 Euro��6D   $
��Wrap=�6_   $	��Top=�6s   $��14(�6�   $��21��6�   $	��127��6�   �� 5   
   $
��Left=�6   $��482,216,0,0q�6/   $��Per Hond: 4 Euro��6D   $
��Wrap=�6\   $	��Top=�6p   $��14(�6�   $��20��6�   $	��111��6�   �� 5   
   $
��Left=�6   $��482,245,0,0q�6/   $��Auto bij tent: 6 Euro��6D   $
��Wrap=�6a   $	��Top=�6u   $��14(�6�   $ 0.721,3.558&�6�   $��21��6�   $	��132��6�   �� 5   
   $
��Left=�6   $��482,159,0,0q�6/   $7��1Plaatsverhuur buiten seizoen: 25 Euro  (10 meter)��6D   $
��Wrap=�6}   $	��Top=�6�   $��13(�6�   $��19��6�   $	��299��6�   �� 5   
   $
��Left=�6   $��482,132,0,0q�6/   $7��1Plaatsverhuur binnen seizoen: 30 Euro  (10 meter)��6D   $
��Wrap=�6}   $	��Top=�6�   $��13(�6�   $	��318��6�   $��19��6�   �� 5    
   $3��-Het seizoen is 11 juli tot en met 15 augustus��6   $
��Left=�6H   $��563,101,0,0q�6c   $	��Top=�6x   $��10(�6�   $��26��6�   $	��218��6�   5!      5"      