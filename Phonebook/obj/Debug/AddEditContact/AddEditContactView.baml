   M S B A M L   `   `   `  ����D  @Phonebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Phonebook.AddEditContactPhonebook.AddEditContact  5      ;"clr-namespace:Phonebook.ConvertersPhonebook.Converters  5      1    +Phonebook.AddEditContact.AddEditContactView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Phonebook.AddEditContact     5      3conv"clr-namespace:Phonebook.Converters     5        � 	Resources  5
      @  :Phonebook.Converters.NegatableBooleanToVisibilityConverter   VisConverter  NegVisConverter   Negate �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%  &	        &	      '�� -       5   
   65     5   
    . 6M   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5!   
   �� 5"      $��* �6   �� 5#      $��2* �6   .+�5%   
   �� $��Name:��6   $��0��6!   $��0��6.   $��Right=�6>   $��5q�6Z   �� 5&   
   -   5        $��TxName��5&      $��0��6    $��1��6-   $��5q�6}   ��6=   �� *Contact.Name+" �� ValidatesOnNotifyDataErrors . 6}   �� 5(   
   $��Surname:��6   $��1��6$   $��0��61   $��Right=�6A   $��5q�6]   �� 5)   
   -   5        $��	TxSurname��5)      $��1��6#   $��1��60   $��5q�6�   ��6@   �� *Contact.Surname+ . 6�   �� 5+   
   $��City:��6   $��2��6!   $��0��6.   $��Right=�6>   $��5q�6Z   �� 5,   
   -   5        $��TxCity��5,      $��2��6    $��1��6-   $��5q�6}   ��6=   �� *Contact.City+ . 6}   �� 5.   
   $��Phone Number:��6   $��3��6)   $��0��66   $��Right=�6F   $��5q�6b   �� 5/   
   -   5        $��TxPhoneNumber��5/      $��3��6'   $��1��64   $��5q�6�   ��6D   �� *Contact.PhoneNumber+ . 6�   �� 51   
    �� Orientation$ 
Horizontal=�6   $��4��52      $��1��53      .+�54      �� $
��Save��6   ��55      �� *SaveCommand+y�56      �� *
EditMode+ �� 	Converter# [  �� 57      $	��Add��6   ��58      �� *SaveCommand+y�59      �� *
EditMode+# [ �� 5:      $��Cancel��6   ��5;      �� *CancelCommand+5<      5=      5>      