   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   6,   �� 5      $��5* �6   6,   .+�5   
   � -   5         �Name$ ButtonContainer��5      $��0��6(   
�������.+�5      �� .+�5      �� -   5         ��Name$ 
HomeButton��5      $��20q�6-   $
��Home��69   6H   �� 5      -   5        $ 
NewsButton��5      $��20q�6-   $
��News��69   6H   �� 5      -   5        $ MusicButton��5      $��20q�6.   $��Music��6:   6J   �� 5      -   5        $ GamesButton��5      $��20q�6.   $��Games��6:   6J   5      5      � 5   
   -   5        $ GridContainer��5      $��1��6&   
�������.+�5         WpfApp1.Home  -   5          Name$ homeUC��5      $��15q�6)   67      WpfApp1.News  5      -   5          Name$ newsUC��5      $��15q�6)   $y�	Collapsed=�65   6N      WpfApp1.Music  5      -	   5          Name$ musicUC��5      $��15q�6+   $y�	Collapsed=�67   6P      WpfApp1.Games  5      -
   5          Name$ gamesUC��5      $��15q�6+   $y�	Collapsed=�67   6P   5      5      5      