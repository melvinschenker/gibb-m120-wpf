   M S B A M L   `   `   `  ����F  BM120Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:M120ProjektM120Projekt  5          M120Projekt.Liste   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:M120Projekt     5      -   5          � UseLayoutRounding  .  .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $	��20* �6   6+   .+�5   
   ]� $��0��6   
�������.+�5      �� -   5         ��Name$ 	searchbox��5      $	��300��6*   $
��20px��66   $��10,0,0,0q�6f   �� 5      $��
search.png��6   $��58��6)   $��	0,0,200,0q�64   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridGame��5      $��1��6)      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 67      
IsReadOnly .  � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ menuItemDetails��5      $��Details anzeigen��68    m� Icon 5      �� 5      $��help.png��6$   68   5      m� 5      -   5        $ menuItemLöschen��5      $��Löschen��68    5      �� 5      $��
delete.png��6$   6:   5      5       5"      5#      5$      