   M S B A M L   `   `   `  ����D  @AppEnergy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AppEnergy	AppEnergy  5   	       AppEnergy.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AppEnergy     5   	     � Title$  AE - MainWindow��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6*   �� 5      $��* �6   6*   �� 5      $��* �6   6*   �� 5      $��* �6   6*   �� 5      $��* �6   6*   �� 5      $��* �6   6*    � ColumnDefinitions 5   
   �� 5      $	��15* �6   6-   �� 5      $	��75* �6   6-   �� 5      $	��15* �6   6-   .+�5   
   �� -   5         ��Name$ HomeMenuButtton��5      $��0��6*      SecondaryButton#��[  67   .��6�   Home6�   �� 5   
   -   5        $ ClientsMenuButtton��5      $��1��6-   #��[  6:   ���	#FF1A654F.��6�   	Clients6�   �� 5   
   -   5        $ MaintenanceMenuButtton��5      $��2��61   #��[  6>   .��6�   Maintenance6�   �� 5   
   -   5        $  CustomerSupportMenuButtton��5      $��3��65   #��[  6B   .��6�   Customer support6�   �� 5   
   -   5        $ PlanningsMenuButtton��5      $��4��6/   #��[  6<   .��6�   
Calendar6�   �� 5   
   -   5        $ ExitMenuButton��5      $��5��6)   #��[  66   .��6|   Exit6�   �� 5!   
   $��0��6   $��2��6!   $��Center=�61   $��Center=�6N   
Username6t    � 5#   
   -   5          �Name$
 Main��5#   l   $��0��6   $��1��6   $��2��6-   $��6��6A     � NavigationUIVisibility$ Hidden=�6z   6�   5%      5&      