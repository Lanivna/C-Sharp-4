   M S B A M L   `   `   `  ����D  @C-Sharp-4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:C_Sharp_4	C_Sharp_4  5   	       C_Sharp_4.ListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:C_Sharp_4     5   	   $	��550��5   	   $	��825��6   .��5	      � -   5        $��ListGrid��5	      .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  DataGrid��5
      $
��Left=�6%   $��10, 10, 0, 0q�6@   $	��Top=�6V   $	��710��5      $	��400��6   $
��Auto��6/      AutoGenerateColumns . ��5      �� *People+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedPerson+$ OneWayToSource=�$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	FirstName+6e     5      $ 	Last name��6%   $	 100 6U    68   �� *
LastName+6c     5      $ Email��6%   $	 100 6N    64   �� *Email+6\     5      $ Date of birth��6%   $	 100 6\    6<   �� *DateOfBirth+6j     5      $ Chinese Sign��6%   $ 90 6[    6;   �� *ChineseSign+6i     5      $ Sun Sign��6%   $ 90 6S    67   �� *	SunSign+6`     5      $ Adult��6%   $ 50 6P    64   �� *	IsAdult+6]     5      $ Birthday��6%   $ 80 6W    67   �� *
IsBirthday+6d   	 � 	Resources	 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value��%�   '        �� 5      "
  6   .�5      ��  � �� �#E5AFA463   �� 5       � ��$ Georgia, serif)�63   �� 5       � ��$ 0,0,1,2q�68   �� 5       � ��
 �����64   �� 5        � ��$ 15(�61   5"      5%      @�5'         C_Sharp_4.App  5(      6   5*      �� 5,   
   -   5         ��Name$ AddNewPerson��5,      $��Add new Person��6O   $��Center=�6h   $��SemiBold"�6�   $��11(�5-      $��720, 10, 0, 480q�6   
���\\��$��95��6O   ��5,   '   �� *AddNewPersonCommand+5-   O   �� 5.   
   -   5        $ DeletePerson��5.      $��Delete Person��6O   $��Center=�6g   $��SemiBold"�6�   $��11(�5/      $��720, 50, 0, 440q�6   
���\\��$��95��6O   ��5.   '   �� *DeletePersonCommand+50      �� 51   
   -   5        $ 
EditPerson��51      $��Edit Person��6K   $��Center=�6a   $��SemiBold"�6~   $��11(�52      $��720, 90, 0, 400q�6   
���\\��$��95��6O   ��51   %   �� *EditPersonCommand+53      �� 55   
   -   5        $ SaveCurrentData��55      $��Save current data��6P   $��Center=�6l   $��SemiBold"�6�   $��11(�56      $��720, 130, 0, 360q�6   
���/kU�$��95��6U   ��55   *   �� *SavePersonCommand+57      �� 59   
   
����d�$��11(�6,   $��720, 170, 0, 320q�6:   $
��Left=�6T   $��SemiBold"�5:      .��6&   
Sort by:5<      �� 5=   
   $��95��6   
����d�$��16(�6:   $��720, 210, 0, 280q�6H   $
��Left=�5>      $��SemiBold"�6.   .@�5?      �� .��6   
First name6'   �� 5@      .��6   	Last name6&   �� 5A      .��6   Email6"   �� 5B      .��6   Date of birth6*   �� 5C      .��6   Chinese sign6)   �� 5D      .��6   
Sun sign6%   5E      �� 5F   
    d� IsThreeState .  $��Adult��6~   $��Center=�6�   $��SemiBold"�6�   $��11(�6�   $��720, 250, 0, 240q�5G      $��95��6-   $��15��68    d� 	IsChecked 5F      �� *IsAdultFilter+$ TwoWay=�$ PropertyChanged=�5H      �� 5I   
    .  $��Birthday��6�   $��Center=�6�   $��SemiBold"�6�   $��11(�5J      $��720, 250, 0, 210q�6!   $��95��6;   $��15��6F    5I      �� *IsBirthdayFilter+$ TwoWay=�$ PropertyChanged=�5K      5L      5M      