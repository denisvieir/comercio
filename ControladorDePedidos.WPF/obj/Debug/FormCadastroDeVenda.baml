   M S B A M L   `   `   `  ����E  Adn32Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layoutdn32ImageButton.Controls  5   	   S OControladorDePedidos.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF 5   	   2   ,ControladorDePedidos.WPF.FormCadastroDeVenda   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   MControls:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layout    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ControladorDePedidos.WPF     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cadastro de Venda��5
   	   $��430.23��6#   $��968.269��63    � Language$ pt-BR�5   	    � 	Resources 5       �� Source�� 5   
   $7 1/dn32Layout;component/Themes/dn32ImageButton.xaml?�6   %    .��5      � .+�5   
   �� -   5         ��Name$ lstProdutos��5       �� SelectionMode$ Single=�6(   $��10,73,10,10q�6W   ��6?   ��  �� View 5      �� 5      .P�5      �� $
��Nome��6%    �� Width$	 200��63   	 �� DisplayMemberBinding	 6?   �� *Produto.Nome+�� 5      $��Marca��6%   $	 100��64   	 6@   �� *Produto.Marca.Nome+�� 5      $��Valor total��6%   $	 110��6:   	 6F   �� *
ValorTotal+
 �� StringFormat$
 {0:C}���� 5      $��
Quantidade��6%   $	 110��69   	 6E   �� *
Quantidade+5      5      .   (dn32ImageButton.Controls.dn32ImageButton  5   
   -   5          Name$ 
btnExcluir��5   #      dn32ButtonStyle#���   5         Text$ Excluir��5         NormalImage$+ %/dn32Layout;component/img/excluir.png��5       $��81,6,0,0q�6A   $��62��6S   $
��Left=�5!      $��66��6(   $	��Top=�63      	ImageSize$ 32Q�6M   $��12(�5"      $��3q�5#      6     5%   
   -   5        $ btnAdicionar��5%   #   #���   5&      $ 	Adicionar��5'      $; 5/ControladorDePedidos.WPF;component/img/adicionar.png��5(      $��10,6,0,0q�6Q   $��62��6c   $
��Left=�5)      $��66��6(   $	��Top=�63   $ 32Q�6M   $��12(�5*      $��3q�5+      6     5,   
   -   5        $ 
btnCliente��5,   #   #���   5-      $ Cliente��5.      $ 32Q�5/      $��12(�50      $��3q�51      $, &/dn32Layout;component/img/clientes.png��52      $��0,6,10,0q�6B   $��62��6T   $��Right=�53      $��66��6)   $	��Top=�64   6L   �� 54   
   -   5         ��Name$ 	textBlock��54      $
��Left=�6'   $��
161,45,0,0q�6B   $
��Wrap=�6V   $��Cliente:��6j   $	��Top=�6z   �� 55   
   -   5        $ 
txtCliente��55      $
��Left=�6(   $��
205,45,0,0q�6C   $
��Wrap=�6W   $�� ��6k   $	��Top=�6s   56      57      