   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AppEnergy.TemplatesAppEnergy.Templates  5      *    $AppEnergy.Templates.AddEquipmentForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AppEnergy.Templates     5        N� 
Background
  ����� N� Title$ AddEquipmentForm��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��20* �6   6+   �� 5      $��5* �6   6*    � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $	��30* �6   6-   �� 5      $	��40* �6   6-   �� 5      $	��15* �6   6-   .+�5"   
   �� $��1��6   $��1��6!   Add an Equipment6D   �� 5$   
   $��2��6   $��1��6!   Client6;   �� 5%   
   $��3��6   $��1��6!   	Equipment6=   �� 5&   
   $��4��6   $��1��6!   Color6:   �� 5(   
   -   5         ��Name$ ClientNameTextBlock��5(      $��2��61   $��2��6A   6P   �� 5)   
   -   5         ��Name$ EquipmentComboBox��5)      $��2��6.   $��3��6>   6�   �� 5*   
   -   5        $ EquipmentColorComboBox��5*      ${�false��63   $��2��6E   $��4��6U   6d   �� 5-   
   -   5         ��Name$ AddEquipmentButton��5-      $��1��6-   $��9��6=   $��2��6J      PrimaryButton#��[  6^   $��Center=�6�   .��6�   Add Equipment6�   5.      5/      