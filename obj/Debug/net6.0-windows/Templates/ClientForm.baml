   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AppEnergy.TemplatesAppEnergy.Templates  5      $    AppEnergy.Templates.ClientForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AppEnergy.Templates     5        N� 
Background
  ����� N� Title$ 
ClientForm��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��20* �6   6+   �� 5      $��5* �6   6*    � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $	��30* �6   6-   �� 5      $	��40* �6   6-   �� 5       $	��15* �6   6-   .+�5#   
   �� $��1��6   $��1��6!   $��2��61   $��Center=�6E   Add a client6q   �� 5$   
   $��2��6   $��1��6!   
First name6=   �� 5%   
   $��3��6   $��1��6!   	Last name6<   �� 5&   
   $��4��6   $��1��6!   Adress69   �� 5'   
   $��5��6   $��1��6!   	ZipCode6:   �� 5(   
   $��6��6   $��1��6!   City67   �� 5)   
   $��7��6   $��1��6!   Phone Number6?   �� 5*   
   $��8��6   $��1��6!   Mail67   �� 5,   
   -   5         ��Name$ FirstNameTextBox��5,      $��2��6,   $��2��69   6K   �� 5-   
   -   5        $ LastNameTextBox��5-      $��3��6+   $��2��68   6J   �� 5.   
   -   5        $ AdressextBox��5.      $��4��6(   $��2��65   6G   �� 5/   
   -   5        $ ZipCodeTextBox��5/      $��5��6*   $��2��67   6I   �� 50   
   -   5        $ CityTextBox��50      $��6��6'   $��2��64   6F   �� 51   
   -   5        $ PhoneNumberTextBox��51      $��7��6.   $��2��6;   6M   �� 52   
   -   5        $ MailTextBox��52      $��8��6'   $��2��64   6F   �� 54   
   -   5         ��Name$ AddCLientButton��54      $��1��6*   $��2��6:   $��9��6N      PrimaryButton#��[  6[   .��6�   
Add Client6�   �� 55   
   -	   5        $ EditCLientButton��55      $��1��6+   $��2��6<   $��9��6Q   $y�Hidden=�6^   #��[  6r   .��6�   Edit Client6�   �� 56   
   -
   5        $ DeleteClientButton��56      $��2��6-   $��10,0,0,0q�6=   $��9��6O   $y�Hidden=�6\   #��[  6q   .��6�   Delete Client6�   58      59      