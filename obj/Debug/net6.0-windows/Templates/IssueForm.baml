   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AppEnergy.TemplatesAppEnergy.Templates  5      #    AppEnergy.Templates.IssueForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AppEnergy.Templates     5        N� 
Background
  ����� N� Title$ 	IssueForm��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��10* �6   6+   �� 5      $	��20* �6   6+   �� 5      $��5* �6   6*    � ColumnDefinitions 5   
   �� 5      $��5* �6   6,   �� 5      $	��30* �6   6-   �� 5      $	��40* �6   6-   �� 5      $	��15* �6   6-   .+�5"   
   �� -   5         ��Name$ TitleTextBlock��5"      $��1��6,   $��1��69   $��2��6I   $��Center=�6]   Add an issue6�   �� 5$   
   $��2��6   $��1��6!   	Contact6:   �� 5%   
   $��3��6   $��1��6!   	Equipment6<   �� 5&   
   $��4��6   $��1��6!   Description6>   �� 5'   
   $��5��6   $��1��6!   Status69   �� 5)   
   -   5         ��Name$ ClientComboBox��5)      $��2��6+   $��2��68   6~   �� 5*   
   -   5        $ EquipmentComboBox��5*      ${�False��6.   $��3��6@   $��2��6M   6`   �� 5+   
   -   5         ��Name$ DescriptionTextBox��5+      $��4��6.   $��2��6;   .��6K   6N   �� 5,   
   -   5        $ StatusComboBox��5,      $��5��6+   $��2��68   6K   �� 50   
   -   5         ��Name$ AddIssueButton��50      $��1��6)   $��9��69   $��2��6F      PrimaryButton#��[  6[   .��6�   	Add issue6�   �� 51   
   -   5        $ EditIssueButton��51      $��1��6*   $��9��6:   $��Right=�6G   $y�Hidden=�6c   $��0,0,20,0q�6w   #��[  6�   .��6�   
Edit issue6�   �� 52   
   -   5        $ DeleteIssueButton��52      $��2��6,   $��9��6<   $y�Hidden=�6I   #��[  6]   .��6�   Delete issue6�   53      54      