   M S B A M L   `   `   `  ���� G  CSlackControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SlackControlSlackControl      SlackControl.Slack   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:SlackControl     
�������$��728.277��$��570.129��#��� ��$��0q�.��� -     �Name$  	slackGrid��$��
0,19,10,10q�.+��� -    ��Name$ label2��$�� ��$
��Left=�$��	145,1,0,0q�$	��Top=�$	��351��$��29��$��14(��� -    ��Name$ btn_signout��$y�Visible=�$��Sign out of Slack��$
��Left=�$��
383,43,0,0q�$	��Top=�$	��162��$��40��$��Lucida Sans)�$��16(� J� RenderTransformOrigin$ 0.637,-0.17&����	#FFF97171$
��Bold"��� -   $ 	btn_slack��$�� ��$
��Left=�$��	384,1,0,0q�$	��Top=�$	��161��$��42������  �� ImageSource$ Images/slack.png���� -    ��Name$ image��$
��Left=�$��91��$��23,1,0,0q�$	��Top=�$	��117������ *profileImage+�� -   $ lbl_id��$
��Left=�$��
146,73,0,0q�$	��Top=�$	��213��$��26��$��14(����� *userID+�� -   $ lbl_name��$
��Left=�$��
146,35,0,0q�$	��Top=�$	��213��$��33��$��14(����� *
userName+�� -    ��Name$ combo1_channel��$
��Left=�$��29��$��
24,132,0,0q�$	��Top=�$	��187��$��0,1,1,1q�$��16(�$ 0.5,0.5&����� *	channel+z�V� .~��� �� ��  �� Angle$ 0.069Q�T� �� -	   $ label��$��DIRECT MESSAGES��$
��Left=�$��
22,427,0,0q�$	��Top=�$	��207��$
��Bold"�$��26��$��Lucida Sans)�$��14(��� -
    ��Name$ textBox��{�.  $
��Left=�$��34��$��234,390,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��237��$��16(��� -   $ btn_send��$
��SEND��{�.  $
��Left=�$��34��$��476,390,0,0q�$	��Top=�$��65��$
��Bold"�$��16(��� -   $ combo_send1��$
��Left=�$��34��$��
22,390,0,0q�$	��Top=�$	��208��$��0,1,1,1q�$��16(����� *channelsend+
 �� Mode$
 TwoWay=��� -   $ combo_send2��$
��Left=�$��32��$��
22,664,0,0q�$	��Top=�$	��207��$��0,1,1,1q�$��16(����� *	channeldm+$
 TwoWay=��� -    ��Name$ slider�� �� TickPlacement$ BottomRight=� �� IsSnapToTickEnabled .  � Maximum$	 100Q� � Minimum$ 10Q� �� TickFrequency$ 10Q�$
��Left=�$��28��$��427,132,0,0q�$	��Top=�$	��114��$��24(�$��2q��� -   $ ticker��{�.  $
��Left=�$��28��$��384,132,0,0q�$
	 Wrap=�$	��Top=�$��38��$��14(�$��2q����� *Value+ �� ElementName$ slider�� �� UpdateSourceTrigger$ PropertyChanged=��� -    ��Name$ listView_channel����. $��Stretch=�$	��220��$��22,165,19,0q�$	��Top=�$��Segoe UI Semibold)�$��14(�
���   �$
��Bold"�
�������$	��519��$��2q� �� View �� -   	gridslist��.P��� -   gridcolumn1�� �� Width$	 519��$��CHANNELS������  �� 
TargetType" ���� -   $ listView_DM��$	��206��$��22,455,19,0q�$	��Top=�$��Lucida Sans)�$��14(�
���   �$
��Bold"�
�������$	��519��$��2q� �� -   xp��.P��� -   col��$	 519��$��DIRECT MESSAGES������ " ���� -   $ button��$��CLEAR��$
��Left=�$��
384,88,0,0q�$	��Top=�$	��161��$��33��$
��Bold"��� -   $ combo_groups��$
��Left=�$��217,132,0,0q�$	��Top=�$	��162��$��28��$��16(����� *groups+�� -   $ 	textBoxDM��{�.  $
��Left=�$��32��$��234,664,0,0q�$
	 Wrap=�$	��Top=�$	��233��$��14(��� -   $ 
btn_sendDM��{�.  $
��SEND��$
��Left=�$��32��$��472,664,0,0q�$	��Top=�$��69��$
��Bold"�$��14(�$ 0.696,6.657&��� -   $ label1��$��Public Channels��$
��Left=�$��
23,104,0,0q�$	��Top=�$	��138���� -   $ label3��$��Private Channels��$
��Left=�$��213,104,0,0q�$	��Top=�$	��146��