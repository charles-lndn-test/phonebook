   M S B A M L   `   `   `  ����D  @Phonebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Phonebook.ContactListPhonebook.ContactList  5   	   C&clr-namespace:Phonebook.AddEditContactPhonebook.AddEditContact  5   	   %clr-namespace:Phonebook	Phonebook  5   	       Phonebook.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8contacts#clr-namespace:Phonebook.ContactList     5   	   :addedit&clr-namespace:Phonebook.AddEditContact     5   	   )localclr-namespace:Phonebook     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)    � DataContext 5      #   Phonebook.MainWindowViewModel  5   
    � 	Resources 5       �� DataType0  *Phonebook.ContactList.ContactListViewModel+   %Phonebook.ContactList.ContactListView6  0Phonebook.AddEditContact.AddEditContactViewModel1   +Phonebook.AddEditContact.AddEditContactView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Add New Contact��6   $��
addContact��6N   $��5q�6l   $��5q�6w   ��6/   �� *
NavCommand+6w   �� 5      $��All Contacts��6   $��allContacts��6K   $��5q�6j   $��5q�6u   ��6,   �� *
NavCommand+6u   5      � 5   
   -   5         �Name$ MainContent��5      $��1��6$   .+�5       �� ��6   �� *CurrentViewModel+5!      5"      5#      