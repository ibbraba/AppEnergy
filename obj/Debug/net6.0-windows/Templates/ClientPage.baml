   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AppEnergy.TemplatesAppEnergy.Templates  5      $    AppEnergy.Templates.ClientPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AppEnergy.Templates     5        N� 
Background
  ����� N� Title$ 
ClientPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $	��30* �6   6-   �� 5      $	��20* �6   6-   �� 5      $	��30* �6   6-   �� 5      $��5* �6   6,    � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��30* �6   6+   �� 5      $	��10* �6   6+   .+�5"   
   �� $��1��6   $��2��6!   $��Center=�61   Client6W   �� 5#   
   -   5         ��Name$ FullNameTextBox��5#      $��3��6-   $��1��6:   	Full Name6V   �� 5$   
   -   5        $ AdressTextBox��5$      $��4��6+   $��1��68   Adress6R   �� 5%   
   -   5        $ PhoneNumberTextBox��5%      $��5��60   $��1��6=   Phone Number6]   �� 5&   
   -   5        $ MailTextBox��5&      $��6��6)   $��1��66   Mail6N   �� 5'   
   -   5        $ CreatedAtTextBox��5'      $��7��6.   $��1��6;   
Created At6X   �� 5*   
   $��2��6   $��Center=�6!   $��3��6>   	Equipment6Z   �� 5+   
   -   5         ��Name$ ClientEquipmentListBox��5+      $��3��62   $��3��6B   $��4��6O   6�   �� 5.   
   -   5         ��Name$ EditClientButton��5.      $��1��6+   $��8��6;      PrimaryButton#��[  6H   $��Bottom=�6o   .��6�   Edit Client6�   �� 5/   
   -   5        $ AddEquipmentClientButton��5/      $��3��63   $��8��6C   #��[  6P   $��Bottom=�6w   .��6�   Add Equipment6�   51      52      