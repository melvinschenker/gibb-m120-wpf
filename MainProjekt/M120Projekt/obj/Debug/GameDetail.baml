   M S B A M L   `   `   `  ����F  BM120Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:M120ProjektM120Projekt  5          M120Projekt.GameDetail   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:M120Projekt     5        � 	Resources  5	         textBoxStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6'   .�5      ��  � ��
 �����6-   �� 5       � ��$ 8q�6)   �� 5       �@��TextAlignment$ Center=�60   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��0.85* �6   6-   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��3* �6   6*   �� 5      $��1* �6   6*   .+�5   
   � $��0��6    � ToolTip$
 Name��6   .+�5      �� 
�������$	��2pxq�6(   
�������6S   �� 5      -   5         ��Name$ GameDetailsGameName��5      #��[  63   $
��15px(�6[    �� TextWrapping$
 Wrap=�6k   
�������$��0q�6�   5      �� 5    
   -   5        $ GameDetailJahr��5       $ Erscheinungsjahr��6*   $��1��6E   #��[  6R   6}   �� 5"   
   -   5        $ GameDetailGenre��5"      $ Genre��6+   $��2��6;   #��[  6H   6r   �� 5$   
   -   5        $ GameDetailKonsole��5$      $ Konsole��6-   $��3��6?   #��[  6L   6v   � 5&   
   -   5         �Name$ GameDetailVerfügbarkeit��5&      $��4��60   .+�5'      	� -   5        	 	�Name$	 VerfügbarRadioButton��5'      $��	10,6,0,10q�68   ��5(      �� 5)      
������
Verfügbar6C   5+      	� 5,      -   5        $ 	 NichtVerfügbarRadioButton��5,      $��
10,24,0,10q�6=   ��5-      �� 5.      
����p��Nicht Verfügbar6L   50      51      � 53   
   $��5��6   
 J� RenderTransformOrigin$
 0.503,0.458&�6   $��	0,0,0,183q�6@   $��2��6S   .+�54      �� -   5         ��Name$ GameDetailZustand��54      $
��20px��62   $��62,12,10,36q�6@   .@�55      �� -	   5         ��Name$	 Neu��55      .��6,   Neu61   �� 56      -
   5        $ Einwandfrei��56      .��64   Einwandfrei6A   �� 57      -   5        $ leichteGebrauchsspuren��57      .��6?   leichte Gebrauchsspuren6X   �� 58      -   5        $ starkeGebrauchsspuren��58      .��6>   starke Gebrauchsspuren6V   �� 59      -   5        $ beschädigt��59      .��63   beschädigt6?   5:      �� 5;      $��8,12,138,41q�6   �� 6.   $�Zustand��62   �� 6C   $�:��6G   6S   5<      � 5=   
   $��6��6   $��0,10,0,0q�6   .+�5>      �� $	��8,0q�6   $��
Kommentar:��6&   6:   �� 5?      -   5        $ GameDetailKommentar��5?      $�� ��63   $��10,20q�6;   6L   5@      �� 5A   
   -   5        $��7��5A      
������ $��	71,0,69,0q�67   $	��0pxq�6J   .��5B      �� .+�5C      �� $#��Save_icon-icons.com_73702.png��6   $��37��6?   5D      5E      5F      5G      