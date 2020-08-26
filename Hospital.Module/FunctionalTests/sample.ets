;#DropDB HospitalEasyTest

#Application HospitalWin
#Application HospitalWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef HospitalWin

*Action About...
 
*Action OK

#EndIf

#IfDef HospitalWeb
*Action Navigation(My Details)
#EndIf
