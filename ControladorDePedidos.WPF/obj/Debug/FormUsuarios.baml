   M S B A M L   `   `   `  ����S  OControladorDePedidos.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF  5   	   E Adn32Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layoutdn32ImageButton.Controls 5
   	   +    %ControladorDePedidos.WPF.FormUsuarios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ControladorDePedidos.WPF     5   	   OControls:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layout     5
   	   -   5          � Title$  Marcas��5   	   $��445.746��6   $��800.769��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5       �� Source�� 5   
   $7 1/dn32Layout;component/Themes/dn32ImageButton.xaml?�6   %    6Z   .��5      � .+�5   
   .  (dn32ImageButton.Controls.dn32ImageButton  -   5          Name$ btnNovo��5   #      dn32ButtonStyle#���   5         Text$
 Novo��5         NormalImage$6 0/ControladorDePedidos.WPF;component/img/novo.png��5      $��	10,10,0,0q�6^   $��62��5   #   $
��Left=�5      $��66��5   #   $	��Top=�6.      	ImageSize$ 32Q�5   #   $��12(�5   #   $��3q�5   #   6/     5   
   -   5        $ 	btnEditar��5   #   #���   5      $ Editar��5      $8 2/ControladorDePedidos.WPF;component/img/editar.png��5      $��	81,10,0,0q�6N   $��62��6a   $
��Left=�5       $��66��6(   $	��Top=�63   $ 32Q�6M   $��12(�5!   #   $��3q�5"   #   6/     5#   
   -   5        $ 
btnExcluir��5#   #   #���   5$      $ Excluir��5%      $+ %/dn32Layout;component/img/excluir.png��5&      $��
152,10,0,0q�6A   $��62��6U   $
��Left=�5'      $��66��6(   $	��Top=�63   $ 32Q�6M   $��12(�5(   #   $��3q�5)   #   6/     5*   
   -   5        $ btnAtualizar��5*   #   #���   5+      $ 	Atualizar��5,      $- '/dn32Layout;component/img/atualizar.png��5-      $��
223,10,0,0q�6C   $��62��6W   $
��Left=�5.      $��66��6(   $	��Top=�63   $ 32Q�6M   $��12(�5/      $��3q�50      51      �� 52   
   -   5         ��Name$ lstUsuarios��52      	 �� SelectionMode$	 Single=�6(   $��10,77,10,10q�6W   ��6?   �� 
 �� View
 53      �� 54      .P�55      �� $
��Nome��6%    �� Width$	 600��63    �� DisplayMemberBinding 6?   �� *Nome+56      58      59      5:      