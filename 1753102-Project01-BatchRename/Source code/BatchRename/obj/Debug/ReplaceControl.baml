   M S B A M L   `   `   `  ����F  BBatchRename, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BatchRenameBatchRename  5      )clr-namespace:BatchRenameBatchRename  5           BatchRename.ReplaceControl   5   (   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:BatchRename     5      ,myTypeclr-namespace:BatchRename     5      
�������.��5      � -   5        $��MainGrid��5      .+�5   
   �� $��Replace��6   $
��Bold"�5      $��10,6,10,135q�5      6+   �� 5   
   $��Apply to��6   $��150,35,10,106q�6$   �� 5   
   -   5        $��AreaComboBox��5      $��150,54,10,83q�6(   .@�5      ��   �� 
IsSelected  . ��6   ��  �� Path$$ (local:ReplaceAction.NameArea)�6g   �� 5      ��6   �� $) #(local:ReplaceAction.ExtensionArea)�6Z   5      �� 5   
   $
��From��6   $��10,35,148,106q�6    69   �� 5   
   -   5        $��NeedleTextBox��5      $�� ��6'   $��10,54,148,83q�6/   �� 5   
   $��To��6   $��10,82,148,59q�6   66   �� 5   
   -   5        $��HammerTextBox��5      $�� ��6'   $��10,102,148,35q�6/   �� 5   
   -   5        $��20��5      $��80��6   $��Right=�6(   $��0,130,10,10q�5   !   $��Add to List��5   !   5   A   5"      5#      