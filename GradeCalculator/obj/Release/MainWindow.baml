   M S B A M L   `   `   `  ����   GradeCalculator     GradeCalculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Grade Calculator��$��559.2��$��313.447��$��Segoe UI Semibold)� � 	Resources  �� 
TargetType �� 	Resources �� Property �� Value��%�   '��       '�� L     �� " �� ���� '��       " ��.���  �@��CornerRadius$ 5���� " �� ���� '��       " ��.���  �@��CornerRadius$ 5��.����   �� 
TargetType �� CornerRadius �� Padding	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName��%^  '��       �� " ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�$ 4q�._��� $	 ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q�
 P�  �@��
IsSelected . . ��� $ Border�� � ��
 ��·�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� $
��SGPA��.���� $ 10q�._�� -    �Name$ gridSGPA�� � ColumnDefinitions �� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $
��Auto �.+��� -    ��Name$ toggleBtnSGPA��$��0��$��Center=�$��Segoe UI Semibold)�.��Toggle�� -   $ subCheckBox1��$��1��$��Center=�$��Segoe UI Semibold)�.��	Subject 1�� -   $ subCheckBox2��$��2��$��Center=�$��Segoe UI Semibold)�.��	Subject 2�� -   $ subCheckBox3��$��3��$��Center=�$��Segoe UI Semibold)�.��	Subject 3�� -   $ subCheckBox4��$��4��$��Center=�$��Segoe UI Semibold)�.��	Subject 4�� -   $ subCheckBox5��$��5��$��Center=�$��Segoe UI Semibold)�.��	Subject 5�� -   $ subCheckBox6��$��6��$��Center=�$��Segoe UI Semibold)�.��	Subject 6�� -	   $ subCheckBox7��$��7��$��Center=�$��Segoe UI Semibold)�.��	Subject 7�� $��Center=�$��Center=�$��0��$��1��$��Segoe UI Semibold)�	Credits�� -
    ��Name$ Credit1��$��10q�$��1��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit2��$��10q�$��2��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit3��$��10q�$��3��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit4��$��10q�$��4��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit5��$��10q�$��5��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit6��$��10q�$��6��$��1��$��3q�$��Segoe UI Semibold)��� -   $ Credit7��$��10q�$��7��$��1��$��3q�$��Segoe UI Semibold)��� $��0��$��Center=�$��Center=�$
��10 0q�$��2��$��Segoe UI Semibold)�Grade�� -   $ Grade1��$��1��$��10q�$��2��$��3q�$��Segoe UI Semibold)� �� CharacterCasing$ Upper=��� -   $ Grade2��$��2��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� -   $ Grade3��$��3��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� -   $ Grade4��$��4��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� -   $ Grade5��$��5��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� -   $ Grade6��$��6��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� -   $ Grade7��$��7��$��10q�$��2��$��3q�$��Segoe UI Semibold)�$ Upper=��� $��8��$��Right=�$��0 0 10 0q�$��Center=�$��Segoe UI Semibold)�SGPA:�� -   $ 
displayBox��$��8��$��1��$��2��$��10q�$��3q�$��Segoe UI Semibold)� �� 
IsReadOnly . �� -    ��Name$ 
changeSubs��$��9��$��1��$��3q�$��10q�$��Segoe UI Semibold)����	#FFEEEEEE.��Change�� -   $ resetBtn��$��9��$��2��$��3q�$��10q�$��Segoe UI Semibold)�$��Reset�����	#FFEEEEEE�� $��Center=�$��10��$��1��$��2��$��Right=�$��Segoe UI Semibold)�Developed by Makesh Vineeth�� $
��CGPA��.���� $ 10q�._�� -   $ gridCGPA�� �� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $ ToggleBtnCGPA��$��Center=�$��0��$��Segoe UI Semibold)�.��Toggle�� -   $ SemChechBox1��$��Center=�$��1��$��Segoe UI Semibold)�.��
Semester 1�� -   $ SemChechBox2��$��Center=�$��2��$��Segoe UI Semibold)�.��
Semester 2�� -   $ SemChechBox3��$��Center=�$��3��$��Segoe UI Semibold)�.��
Semester 3�� -    $ SemChechBox4��$��Center=�$��4��$��Segoe UI Semibold)�.��
Semester 4�� -!   $ SemChechBox5��$��Center=�$��5��$��Segoe UI Semibold)�.��
Semester 5�� -"   $ SemChechBox6��$��Center=�$��6��$��Segoe UI Semibold)�.��
Semester 6�� -#   $ SemChechBox7��$��Center=�$��7��$��Segoe UI Semibold)�.��
Semester 7�� -$   $ SemChechBox8��$��Center=�$��8��$��Segoe UI Semibold)�.��
Semester 8�� $��0��$��1��$��Center=�$��Center=�$��Segoe UI Semibold)�Total Credits�� -%   $
 Cre1��$��10q�$��1��$��1��$��3q�$��Segoe UI Semibold)��� -&   $
 Cre2��$��10q�$��2��$��1��$��3q�$��Segoe UI Semibold)��� -'   $
 Cre3��$��10q�$��3��$��1��$��3q�$��Segoe UI Semibold)��� -(   $
 Cre4��$��10q�$��4��$��1��$��3q�$��Segoe UI Semibold)��� -)   $
 Cre5��$��10q�$��5��$��1��$��3q�$��Segoe UI Semibold)��� -*   $
 Cre6��$��10q�$��6��$��1��$��3q�$��Segoe UI Semibold)��� -+   $
 Cre7��$��10q�$��7��$��1��$��3q�$��Segoe UI Semibold)��� -,   $
 Cre8��$��10q�$��8��$��1��$��3q�$��Segoe UI Semibold)��� $��0��$��2��$��Center=�$��Center=�$��Segoe UI Semibold)�SGPA�� --   $ 
sgpaGrade1��$��10q�$��1��$��2��$��3q�$��Segoe UI Semibold)��� -.   $ 
sgpaGrade2��$��10q�$��2��$��2��$��3q�$��Segoe UI Semibold)��� -/   $ 
sgpaGrade3��$��10q�$��3��$��2��$��3q�$��Segoe UI Semibold)��� -0   $ 
sgpaGrade4��$��10q�$��4��$��2��$��3q�$��Segoe UI Semibold)��� -1   $ 
sgpaGrade5��$��10q�$��5��$��2��$��3q�$��Segoe UI Semibold)��� -2   $ 
sgpaGrade6��$��10q�$��6��$��2��$��3q�$��Segoe UI Semibold)��� -3   $ 
sgpaGrade7��$��10q�$��7��$��2��$��3q�$��Segoe UI Semibold)��� -4   $ 
sgpaGrade8��$��10q�$��8��$��2��$��3q�$��Segoe UI Semibold)��� $��9��$��Center=�$��Right=�$��0 0 10 0q�$��Segoe UI Semibold)�	Result:�� -5   $ 
resultCGPA��$��9��$��3q�$��1��$��2��$��Segoe UI Semibold)�$��10q��� -6   $ resetBtnCGPA��$��10��$��2��$��1��$��3q�$��Segoe UI Semibold)�$��Reset�����	#FFEEEEEE$��10q�