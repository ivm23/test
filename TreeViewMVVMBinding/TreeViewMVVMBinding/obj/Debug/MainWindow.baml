   M S B A M L   `   `   `  ����N  JTreeViewMVVMBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TreeViewMVVMBindingTreeViewMVVMBinding  5   	   $    TreeViewMVVMBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0vm!clr-namespace:TreeViewMVVMBinding     5   	     � Title$  
MainWindow��5   	   $��194.068��6   $��334.887��6-   .��5	      � $��	0,0,128,0q�6   .+�5
   
   R� -   5        $��TV��5
      $��0��6   ��6-   �� *
DirItems+ R� SelectedValuePath 6N   ��  �� Path$ 
IsSelected� �� Mode$ TwoWay=���5      �� 5       �� ItemsSource 6+   �� $ Items�.R�5      �� ��6    �� $
 Name�5      5      �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��45��6>   $��208,15,-107,0q�6J    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $��88��6�   ��6u   �� $ NameNode�$ TwoWay=�6�   �� 5   
   -   5         ��Name$ button��5      $��Button��6!   $
��Left=�62   $��208,93,-107,0q�6M   $	��Top=�6d   $��88��6|   ��6�   �� *ClickCommand+�� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��208,65,-107,0q�6K   $
 Wrap=�6b   $	��Top=�6�   $��88��6�   ��6v   �� $ TestText�6�   5      5      