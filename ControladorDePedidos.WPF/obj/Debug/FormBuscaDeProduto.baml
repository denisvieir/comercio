   M S B A M L   `   `   `  ����E  Adn32Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layoutdn32ImageButton.Controls  5   	   S OControladorDePedidos.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF 5   	   C&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF 5
   	   1   +ControladorDePedidos.WPF.FormBuscaDeProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   MControls:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layout    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ControladorDePedidos.WPF     5   	   6app&clr-namespace:ControladorDePedidos.WPF     5
   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Buscar Produto��5   	   $��324.077��6    $��810.153��61    � Language$ pt-BR�5   	    � 	Resources 5       �� MergedDictionaries �� Source1  +ControladorDePedidos.WPF.ConversorDeEstoque   ConversorDeEstoque�� 5   
    5      �� 5      $7 1/dn32Layout;component/Themes/dn32ImageButton.xaml?�6%   6b   %   &	          5      6%   5      .��5      � .+�5   
   �� -   5         ��Name$ txtTermoDaBusca��5   2   $��23��6K   $��125,22,10,0q�6W    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	textBlock��5   *   	 �� TextAlignment$	 Right=�6   $
��Left=�6=   $��	10,24,0,0q�6X   $
��Wrap=�6k   $��Termo da busca:��6   $	��Top=�6�   $��99��6�   �� 5   
   -   5        
 ��Name$
 lstProdutos��5       �� SelectionMode$ Single=�6(   $��10,50,10,76q�6W   ��6?   ��  �� View 5      �� 5      .P�5      �� $
��Nome��6%    �� Width$	 300��63    �� DisplayMemberBinding 6?   �� *Nome+�� 5      $��Marca��6%   $	 120��64    6@   �� *
Marca.Nome+�� 5      $��Valor��6%   $ 70��64    6?   �� *ValorDeVenda+ �� StringFormat$ {0:C}���� 5       $��Valor de Compra��6%   $	 110��6>    6J   �� *ValorDeCompra+$ {0:C}���� 5!      $��Estoque��6%   $ 70��66    �� CellTemplate 5"      �� 5#      .R�5$   "   �� ��6,   �� *QuantidadeEmEstoque+��6Q   �� *.+ �� 	Converter# [  5%      5'      5(      5*      .   (dn32ImageButton.Controls.dn32ImageButton  5+   
   -   5          Name$ btnAdicionar��5+   #     dn32ButtonStyle#���  5,         Text$ 	Adicionar��5-         NormalImage$; 5/ControladorDePedidos.WPF;component/img/adicionar.png��5.      $��0,0,10,9q�6Q   $��62��6c   $��Right=�5/      $��66��6)   $��Bottom=�64      	ImageSize$ 32Q�6Q   $��12(�50      $��3q�51      6   �� 52   
   -   5        $ 
textBlock1��52      $��Right=�6(   $��
0,0,203,26q�6D   $
��Wrap=�6X   $��Quantidade:��6l   $��Bottom=�6   �� 53   
   -   5        $ txtQuantidade��53      $��Right=�6)   $��23��6E   $��	0,0,93,22q�6Q   $
 Wrap=�6d   $��1��6x   $��Bottom=�6�   $	��105��6�   54      55      