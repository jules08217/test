   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ listView��5
      $
��Left=�6%   $	��399��6@   $��	22,10,0,0q�6M   $	��Top=�6`   $	��521��6x   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $ 
Horizontal=�6%   .+�5      �� $	��100��6C   ��6(   �� *	FirstName+6Q   �� 5      $	��100��6D   ��6(   �� *
MiddleName+6R   �� 5      $	��100��6B   ��6(   �� *
LastName+6P   �� 5      $��50��6C   ��6(   �� *	DealShare+6P   5      �� 5       ��Name$ DeleteButton��6!   -   5        $��Удалить��5   7   $��70��6I   $��0,0,10,0q�6T   6�   �� 5      $ ChangeButton��6!   -   5        $��Изменить��5   7   $��70��6J   6r   5      5      5      �� 5   
   -   5         ��Name$ fNameTextBox��5      $
��Left=�6(   $��23��6C   $��
569,59,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��196��6�   �� 5   
   -   5        $ mNameTextBox��5      $
��Left=�6(   $��23��6C   $��569,104,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��196��6�   �� 5   
   -   5        $ lNameTextBox��5      $
��Left=�6(   $��23��6C   $��569,158,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��196��6�   �� 5   
   -   5        $ dShareTextBox��5      $
��Left=�6)   $��23��6D   $��569,205,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��196��6�   �� 5   
   -   5        $ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��635,265,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -	   5        $ 
SaveButton��5      $��Сохранить��6%   $
��Left=�69   $��635,308,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5!      5"      