   M S B A M L   `   `   `  ����H  DResturauntPOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RestaurantPOS.ViewModelsRestaurantPOS.ViewModels  5   	   !    RestaurantPOS.Views.POSMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5vm&clr-namespace:RestaurantPOS.ViewModels     5   	     � Title$  POS Main��5   	   $	��600��6   $	��900��6'    � DataContext 5      /   )RestaurantPOS.ViewModels.POSMainViewModel  5   
   .��5      ]� .+�5   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   
���OO/�$��50��6^   .+�5      �� $��Takeaway��6   $��10q�5      $
��10,5q�6!   
�������
������ ��5   (   �� *NavigateTakeawayCommand+5   C   �� 5      $��Dine-In��6   $��10q�5      $
��10,5q�6!   
�������
������ ��5   '   �� *NavigateDineInCommand+5   C   �� 5      $��Delivery��6   $��10q�5      $
��10,5q�6!   
�������
������ ��5   (   �� *NavigateDeliveryCommand+5   C   5      �� 5   
   ��6   �� *CurrentView+5      5      