   M S B A M L   `   `   `  ����E  Adn32Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layoutdn32ImageButton.Controls  5   	   S OControladorDePedidos.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ControladorDePedidos.WPFControladorDePedidos.WPF 5   	   4   .ControladorDePedidos.WPF.FormCadastroDeProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   MControls:clr-namespace:dn32ImageButton.Controls;assembly=dn32Layout    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ControladorDePedidos.WPF     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cadastro de Produto��5
   	   $��357.928��6%   $��371.731��66    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� Source�� 5   
   $7 1/dn32Layout;component/Themes/dn32ImageButton.xaml?�6   %    6Z   .��5      � .+�5   
   �� -   5         ��Name$ txtNome��5   (   $
��Left=�69   $��23��6T   $��
156,41,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��176��6�   $��2��6�   ��6   �� *Nome+6�   �� 5   
   -   5         ��Name$ textBlock_Copy��5   *    �� TextAlignment$ Right=�6   $
��Left=�6B   $��
102,45,0,0q�6]   $
��Wrap=�6q   $��Nome:��6�   $	��Top=�6�   $��49��6�   .   (dn32ImageButton.Controls.dn32ImageButton  5   
   -   5        	  Name$	 	btnSalvar��5   #      dn32ButtonStyle#���   5      
   Text$
 Salvar��5         NormalImage$* $/dn32Layout;component/img/salvar.png��5      $��	0,0,35,10q�6R   $��51��5      $��Right=�5      $��66��5   #   $��Bottom=�6.      	ImageSize$ 24Q�5   #   $��12(�5   #   $��0 2 0 0q�5   #   $��1��6M   �� 5   
   -   5        $ textBlock_Copy1��5   *   $ Right=�6   $
��Left=�6C   $��
102,72,0,0q�6^   $
��Wrap=�6r   $��Marca:��6�   $	��Top=�6�   $��49��6�   �� 5    
   -   5        $ txtValorDeCompra��5    1   $
��Left=�6K   $��23��6f   $��156,126,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ��6   �� *ValorDeCompra+6�   �� 5!   
   -   5        $ textBlock_Copy2��5!   *   $ Right=�6   $
��Left=�6C   $��
10,130,0,0q�6^   $
��Wrap=�6r   $��Valor de Compra:��6�   $	��Top=�6�   $	��141��6�   �� 5"   
   -   5        $ txtValorDeVenda��5"   0   $
��Left=�6I   $��23��6d   $��156,154,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ��6   �� *ValorDeVenda+6�   �� 5#   
   -	   5        $ textBlock_Copy3��5#   *   $ Right=�6   $
��Left=�6C   $��
10,158,0,0q�6^   $
��Wrap=�6r   $��Valor de Venda:��6�   $	��Top=�6�   $	��141��6�    J� RenderTransformOrigin$ 0.714,0.442&�6�   �� 5$   
   -
   5        $ txtQuantidadeEmEstoque��5$   7   $
��Left=�6W   $��23��6r   $��156,182,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ��6   �� *QuantidadeEmEstoque+6�   �� 5%   
   -   5        $ textBlock_Copy4��5%   *   $ Right=�6   $
��Left=�6C   $��
10,186,0,0q�6^   $
��Wrap=�6r   $	��Top=�6�   $	��141��6�   �� 6�   $	�Qua��6�   �� 6�   $�n��6�   �� 6�   $�tidade em estoque��6�   �� 6�   $�:��6�   6�   �� 5&   
   -   5        $ txtEstoqueDesejavel��5&   @   $
��Left=�6]   $��23��6x   $��156,210,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ��6   �� *QuantidadeDesejavelEmEstoque+6�   �� 5'   
   -   5        $ textBlock_Copy5��5'   *   $ Right=�6   $
��Left=�6C   $��
10,214,0,0q�6^   $
��Wrap=�6r   $	��Top=�6�   $	��141��6�   �� 6�   $�Estoque ��6�   �� 6�   $�	desejavel��6�   �� 6�   $�:��6�   6�   �� 5(   
   -   5        $ txtEstoqueMinimo��5(   =   $
��Left=�6W   $��23��6r   $��156,238,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $	��176��6�   ��6   �� *QuantidadeMinimaEmEstoque+6�   �� 5)   
   -   5        $ textBlock_Copy6��5)   *   $ Right=�6   $
��Left=�6C   $��
10,242,0,0q�6^   $
��Wrap=�6r   $	��Top=�6�   $	��141��6�   �� 6�   $�Estoque mínimo��6�   �� 6�   $�:��6�   6�   �� 5*   
   -   5         ��Name$ 	cmbMarcas��5*      $
��Left=�6&   $��
156,69,0,0q�6A   $	��Top=�6U   $	��175��6m    �� SelectedValuePath$ Codigo��6�    �� DisplayMemberPath$
 Nome��6�   $��2��6�   ��6y   �� 6�   �� 5+   
   -   5        $ textBlock_Copy7��5+   *   $ Right=�6   $
��Left=�6C   $��	59,99,0,0q�6^   $
��Wrap=�6q   $��Fornecedor:��6�   $	��Top=�6�   $��92��6�   �� 5,   
   -   5        $ cmbFornecedores��5,      $
��Left=�6,   $��
156,96,0,0q�6G   $	��Top=�6[   $	��175��6s   $ Codigo��6�   $
 Nome��6�   ��6   �� 6�   5-      5.      