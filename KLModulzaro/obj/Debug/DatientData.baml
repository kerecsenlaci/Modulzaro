   M S B A M L   `   `   `  ����F  BKLModulzaro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KLModulzaroKLModulzaro  5   	       KLModulzaro.DatientData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KLModulzaro     5   	     � Title$  Betek adatai��5   	   $	��400��6   $	��500��6+   .��5	      � .+�5
   
   �� $��Beteg neve:��6   $
��Left=�6&   $��	52,56,0,0q�6A   $	��Top=�6T   �� 5   
   $
��Left=�6   $��23��6-   $��
146,60,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6   $	��272��6�   ��6a   �� *Patient.Name+6�   �� 5   
   $��Születési hely:��6   $
��Left=�6*   $��	52,84,0,0q�6E   $	��Top=�6X   �� 5   
   $
��Left=�6   $��23��6-   $��
146,88,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��272��6�   ��6a   �� *Patient.Birthplace+6�   �� 5   
   $��Születési dátum:��6   $
��Left=�6,   $��
52,112,0,0q�6G   $	��Top=�6[   �� 5   
   $��
TAJ szám:��6   $
��Left=�6$   $��
52,140,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $
��Left=�5      $��23��6-   $��146,144,0,0q�69   $
 Wrap=�6N   $	��Top=�6   $	��272��6�    �� 	MaxLength$ 9��6�   ��6b   �� *Patient.TAJ+6�   �� 5   
   -   5        $��OK��5      $
��Left=�6   $��177,265,0,0q�69   $	��Top=�6N   $	��113��6f   6r   �� 5   
   $��	Életkor:��6   $
��Left=�6#   $��300,112,0,0q�6>   $	��Top=�6S   �� 5   
   $
��Left=�60   $��354,112,0,0q�6K   $	��Top=�6`   $��64��6x   ��6   �� *Patient.Age+6x   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��146,116,0,0q�6Z   $	��Top=�6o   $	��137��6�      SelectedDate 60   �� *Patient.Birthday+6�   5      5      