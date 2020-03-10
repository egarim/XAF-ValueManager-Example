;#DropDB ValueManagerExampleEasyTest

#Application ValueManagerExampleWin
#Application ValueManagerExampleWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef ValueManagerExampleWin

*Action About...
 
*Action OK

#EndIf

#IfDef ValueManagerExampleWeb
*Action Navigation(My Details)
#EndIf
