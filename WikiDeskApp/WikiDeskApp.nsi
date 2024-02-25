;--------------------------------

!include nsDialogs.nsh
!include MUI2.nsh


!define MUI_COMPONENTSPAGE_SMALLDESC ;No value
!define MUI_UI "myUI.exe" ;Value
!define MUI_INSTFILESPAGE_COLORS "FFFFFF 000000" ;Two colors

; The name of the installer
Name "WikiDeskApp"

; The file to write
OutFile "WikiDeskAppSetup.exe"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Build Unicode installer
Unicode True

; The default installation directory
InstallDir $DESKTOP\WikiDeskApp

;--------------------------------

; Pages

Page directory
Page instfiles

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR

  createDirectory "$SMPROGRAMS\Small Newt Games"
  createShortCut "$SMPROGRAMS\Small Newt Games\Wiki Desk.lnk" "$INSTDIR\WikiDeskApp.exe" "" "$INSTDIR\logo.ico"
 
  ; Put file there
  File bin\Debug\*
  
SectionEnd
