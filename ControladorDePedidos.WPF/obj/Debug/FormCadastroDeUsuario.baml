   M S B A M L   `   `   `  ����E  Adn32Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layoutdn32ImageButton.Controls  5   	   S OControladorDePedidos.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF 5   	   4   .ControladorDePedidos.WPF.FormCadastroDeUsuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   MControls:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layout    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ControladorDePedidos.WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cadastro de Marca��5
   	   $��440.538��6#   $��440.846��64    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� Source�� 5   
   $7 1/dn32Layout;component/Themes/dn32ImageButton.xaml?�6   %    6Z   .��5      � .+�5   
   �� -   5         ��Name$ txtNome��5   (   $
��Left=�69   $��23��6T   $��	80,51,0,0q�6`    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��236��6�   ��6   �� *Nome+6�   �� 5   
   -   5         ��Name$ textBlock_Copy��5   *    �� TextAlignment$ Right=�6   $
��Left=�6B   $��	10,54,0,0q�6]   $
��Wrap=�6p   $��Nome:��6�   $	��Top=�6�   $��57��6�   .   (dn32ImageButton.Controls.dn32ImageButton  5   
   -   5        	  Name$	 	btnSalvar��5   #      dn32ButtonStyle#���   5      
   Text$
 Salvar��5         NormalImage$* $/dn32Layout;component/img/salvar.png��5      $��330,329,0,0q�6R   $��62��5      $
��Left=�5      $��66��5   #   $	��Top=�6.      	ImageSize$ 32Q�5   #   $��12(�5   #   $��3q�5   #   5      �� 5   
   -   5         ��Name$ 	groupBox1��5      $��Permissões��6&   $
��Left=�6:   $��	68,97,0,0q�6U   $	��Top=�6h   $	��200��6�   $	��270��6�   .��5       � .+�5!      �� -   5         ��Name$ 	checkBox1��5!   ?   $��Administador��6R   $
��Left=�6i   $��	10,20,0,0q�6�   $	��Top=�6�    d� 	IsChecked 6   �� *Administrador+6�   �� 5"      -   5        $ checkBox1_Copy��5"   :   $��Clientes��6R   $
��Left=�6e   $��	10,40,0,0q�6�   $	��Top=�6�    6   �� *
Clientes+6�   �� 5#      -   5        $ checkBox1_Copy1��5#   :   $��Produtos��6S   $
��Left=�6f   $��	10,60,0,0q�6�   $	��Top=�6�    6   �� *
Produtos+6�   �� 5$      -   5        $ checkBox1_Copy2��5$   8   $��Vendas��6Q   $
��Left=�6b   $��	10,80,0,0q�6}   $	��Top=�6�    6   �� *Vendas+6�   �� 5%      -	   5        $ checkBox1_Copy3��5%   >   $��Fornecedores��6W   $
��Left=�6n   $��
10,100,0,0q�6�   $	��Top=�6�    6   �� *Fornecedores+6�   �� 5&      -
   5        $ checkBox1_Copy4��5&   9   $��Compra��6R   $
��Left=�6c   $��
10,120,0,0q�6~   $	��Top=�6�    6   �� *	Compras+6�   5(      5)      G� 5*   
   -   5         G�Name$ senha��5*      $
��Left=�6%   $��116,311,0,0q�6@   $	��Top=�6U   $	��178��6m   �� 5+   
   -   5        $ 
textBlock1��5+      $
��Left=�6(   $��
68,313,0,0q�6C   $
��Wrap=�6W   $��Senha:��6k   $	��Top=�6y   �� 5,   
   -   5        $ 
textBlock2��5,      $
��Left=�6(   $��90,477,0,-81q�6C   $
��Wrap=�6Y   $��	TextBlock��6m   $	��Top=�6~   G� 5-   
   -   5        $ confirmarSenha��5-      $
��Left=�6.   $��116,342,0,0q�6I   $	��Top=�6^   $	��178��6v   �� 5.   
   -   5        $ textBlock1_Copy��5.      $
��Left=�6-   $��
12,342,0,0q�6H   $
��Wrap=�6\   $��Confirmar Senha:��6p   $	��Top=�6�   5/      50      