   M S B A M L   `   `   `  ����K  GEventCommandDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EventCommandDemoEventCommandDemo  5   
   r nManMonthMyth.Practices.Composite.Presentation.Behaviors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null��clr-namespace:ManMonthMyth.Practices.Composite.Presentation.Behaviors;assembly=ManMonthMyth.Practices.Composite.Presentation.Behaviors7ManMonthMyth.Practices.Composite.Presentation.Behaviors 5   
   !    EventCommandDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0localclr-namespace:EventCommandDemo     5   
   �	Behaviors�clr-namespace:ManMonthMyth.Practices.Composite.Presentation.Behaviors;assembly=ManMonthMyth.Practices.Composite.Presentation.Behaviors     5   
     � Title$  
MainWindow��5   	   $	��400��6   $	��300��6)    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I   
������� � WindowStartupLocation$ CenterScreen=�6v    � Triggers 5      :� 5   
    :� 
SourceName$ chkRememberPwd��6    :� RoutedEvent$ CheckBox.Unchecked��63   .[�5	      �� .��5
      �� .��5      ��  �� 
TargetName$ 
chkLanding��66    �� TargetProperty$ 	IsChecked�6Y   .p�5      s� 	 �� KeyTime$	 0:0:0.01��62   
 �� Value
 .  6E   5      5      5      5      :� 5   
   $ 
chkLanding��6   $ CheckBox.Checked��6/   .[�5      �� .��5      �� .��5      �� $ chkRememberPwd��65   $ 	IsChecked�6\   .p�5      s� $	 0:0:0.01��62   
 . 6E   5      5      5      5      .��5      (� .��5      � $	��400��6   $	��300��6    � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��40 �6   �� 5       $��40 �6   �� 5!      $��30 �6   �� 5"      .+�5$   
   �� $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5%      �� -   5         ��Name$ cboBox��5%      $��
115,0,10,0q�6+    �� 
IsEditable . $��15(�6�   $��25��6�   $
��Left=�6�   $��Center=�6�   $	��179��6  ��6Q   �� *ListCollection+ �� Text 6x   �� *
UserName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�D  >ManMonthMyth.Practices.Composite.Presentation.Behaviors.Events   Commands 5'      T  NManMonthMyth.Practices.Composite.Presentation.Behaviors.EventCommandCollection  J  DManMonthMyth.Practices.Composite.Presentation.Behaviors.EventCommand  5)         CommandName$" cboTextBoxBaseChangedCommand��66      	EventName$ TextBoxBase.TextChanged��6a     5*      $  cboSelectionChangedCommand��65   $ SelectionChanged��6^   5+      5-      �� 5.      $
��Left=�6   $��Center=�63   $��注册账号��6N    50          51      $ TxTMouseEnterCommand��61   $ 
MouseEnter��6T   52      54      55      �� 56   
   $��2��6   $ 
Horizontal=�6"   .+�57      G� $��
115,0,10,0q�6   /   )EventCommandDemo.PasswordBoxBindingHelper   IsPasswordBindingEnabled . $��15(�6�   $��25��6�   $
��Left=�6  $��Center=�6#  $	��179��6>     BindedPassword 6r   ��  �� Path$ UserPassword�$ TwoWay=�$ PropertyChanged=� 59          5:      $ pwdGotFocusCommand��65   $ GotFocus��6V   5;      5=      �� 5>      -   5        $��
textBlock2��5>   S   $
��Left=�6   $��Center=�67   $��忘记密码��6e   ��6q   ��  �� ElementName$ 
textBlock1��$ Style�5?      �� 5@   
   $��3��6   $ 
Horizontal=�6"   .+�5A      �� -   5         ��Name$ chkRememberPwd��5A      $��记住密码��64    d� IsThreeState .  $
��Left=�6X   $��	115,0,0,0q�6s   $	��Top=�6�    5C          5D      $ chkUncheckedCommand��65   $ 	Unchecked��6W     5E      $ chkCheckedCommand��65   $ Checked��6U   5F      5H      �� 5I      -   5        $ 
chkLanding��5I      $��自动登陆��6/    .  $
��Left=�6T   $��15,0,0,0q�6o   $	��Top=�6�   5J      �� 5K      $��4��6   $ 
Horizontal=�6&   .+�5L      �� -   5        $��btnLogin��5L   D   $��	120,0,0,0q�6   $��33��6,   $	��181��68   $	��Top=�6T   .��5M      �� $��18(�6    $��Consolas;Microsoft YaHei)�6.   
����  �$��
登    录��6f    5O          5Q      $ btnClickCommand��65   $ Click��6S   5R      5T      5U      5V      5W      5X      