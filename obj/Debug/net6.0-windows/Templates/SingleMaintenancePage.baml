   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AppEnergy.TemplatesAppEnergy.Templates  5      /    )AppEnergy.Templates.SingleMaintenancePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AppEnergy.Templates     5        N� 
Background
  ����� N� Title$ SingleMaintenancePgaexaml��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $	��90* �6   6-   �� 5      $��5* �6   6,    � RowDefinitions 5   
   �� 5      $��20 �6   6*   �� 5      $��5* �6   6*   �� 5      $��5* �6   6*   �� 5      $��5* �6   6*   �� 5      $��5* �6   6*   �� 5      $��5* �6   6*   �� 5      $��5* �6   6*   �� 5      $	��15* �6   6+   .+�5    
   �� $��1��6   $��1��6$   Maintenance6?   �� 5!   
   -   5         ��Name$ FullnameTextBlock��5!      $��1��6/   $��2��6?   
FullName6W   �� 5"   
   -   5        $ DateTextBlock��5"      $��1��6+   $��3��6;   Date6O   �� 5#   
   -   5        $ AdressTextBlock��5#      $��1��6-   $��4��6=   Adress6S   �� 5$   
   -   5        $ EquipmentTextBlock��5$      $��1��60   $��5��6@   	Equipment6Y   �� 5%   
   -   5        $ DescriptionTextBlock��5%      $��1��62   $��6��6B   Description6]   �� 5'   
   -   5         ��Name$ EditEquipmentButton��5'      $��1��6.   $��7��6>      PrimaryButton#��[  6K   .��6�   Edit6�   5)      5*      