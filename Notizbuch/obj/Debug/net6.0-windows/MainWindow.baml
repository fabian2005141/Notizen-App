   M S B A M L   `   `   `  ����D  @Notizbuch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Notizbuch	Notizbuch  5   	       Notizbuch.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Notizbuch     5   	     � Title$  
MainWindow��5   	   $	��490��6   $	��490��6)   $	��490��69   $	��932��6J   $	��932��6V   $	��932��6e   .��5      � $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ NotizBox��5      $
��Left=�6$   $	��479��6?   $��	154,0,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��762��6�   ���	#FFEFC5FF �� 
AcceptsTab$
 True��6�    �� AcceptsReturn$
 True��6�   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��407��6>   $	��Top=�6K   $	��155��6c   $��0,-1,0,0q�6�   $
{�True��6�   �� 5   
   -   5         ��Name$ Save_Button��5      $�� ��6&   $
��Left=�61   $��50��6L   $��	0,406,0,0q�6X   $	��Top=�6k   $��50��6�    � Cursor$
 Hand��6�   ��6�   Z� ��6�   Z� ��5      �� 5       �� ImageSource$ src/save.png��6   5      �� 5   
   -   5        $ 
New_Button��5      $�� ��6%   $
��Left=�60   $��50��6K   $��104,406,0,0q�6W   $	��Top=�6l   $��50��6�   	 J� RenderTransformOrigin$	 -2.32,-3.939&�6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ src/add-library.png��6   5      �� 5   
   -   5        $ Delete_Button��5      $�� ��6(   $
��Left=�63   $��50��6N   $��
53,406,0,0q�6Z   $	��Top=�6n   $��50��6�   $
 Hand��6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ src/delete (1).png��6   5      � 5!   
   -   5        $��Grid_new��5!      $
��Left=�6   $��88��6:   $��331,167,0,0q�6F   $	��Top=�6[   $	��336��6s   ���	#FF91F98D$y�Hidden=�6�   .+�5"      �� -   5        
 ��Name$
 lable��5"      $,��&Gib den Namen für die neue Notiz ein:��6#   $
��Left=�6S   $��29��6n   $��11,7,0,0q�6z   $	��Top=�6�   $	��324��6�   �� 5#      -   5        $ textBox_new��5#      $
��Left=�6+   $��23��6F   $��	14,34,0,0q�6R   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��304��6�   �� 5$      -	   5        $ 	ok_button��5$      $��OK��6(   $
��Left=�65   $��20��6P   $��	14,61,0,0q�6\   $	��Top=�6o   $��98��6�   ���	#FF0084206�   �� 5%      -
   5        $ abbruch_button��5%      $��Abbruch��6-   $
��Left=�6?   $��20��6Z   $��
220,61,0,0q�6f   $	��Top=�6z   $��98��6�   ���	#FFF1352C6�   5&      � 5'   
   -   5        $��Save_msg��5'      $
��Left=�6   $��51��6:   $��	0,354,0,0q�6F   $	��Top=�6Y   $	��154��6q   ���	#FF5AFF00$y�Hidden=�6�   .+�5(      �� -   5        $
 
save_debug��5(      $��Gespeichert��6(   $��Center=�6>   $��0,13,0,0q�6[   $	��Top=�6m   $��29��6�   $	��152��6�   $��Comic Sans MS)�6�   $
��Bold"�6�   $��Italic$�6�   $y�Visible=�6�    J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      5,      5-      51      52      