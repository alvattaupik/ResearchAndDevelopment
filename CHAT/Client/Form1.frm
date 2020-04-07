VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "Mswinsck.ocx"
Begin VB.Form Form1 
   BackColor       =   &H00800000&
   Caption         =   "Client"
   ClientHeight    =   4440
   ClientLeft      =   225
   ClientTop       =   855
   ClientWidth     =   5010
   LinkTopic       =   "Form1"
   ScaleHeight     =   4440
   ScaleWidth      =   5010
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtMsg 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   3720
      Width           =   3735
   End
   Begin VB.TextBox txtData 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1935
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   4
      Text            =   "Form1.frx":0000
      Top             =   1440
      Width           =   4575
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Kirim"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      TabIndex        =   3
      Top             =   3720
      Width           =   735
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Sambungkan"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
   Begin VB.TextBox txtPort 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2280
      TabIndex        =   1
      Top             =   120
      Width           =   855
   End
   Begin VB.TextBox txtHost 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2055
   End
   Begin MSWinsockLib.Winsock Winsock1 
      Left            =   2760
      Top             =   960
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin VB.Label lblConnection 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   1080
      Width           =   4575
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "IP Address"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   120
      TabIndex        =   7
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Port"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   2280
      TabIndex        =   6
      Top             =   720
      Width           =   1575
   End
   Begin VB.Menu mnuSetting 
      Caption         =   "Pengaturan"
      Begin VB.Menu mnuName 
         Caption         =   "Ganti Nama"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Alias As String
Private Sub Command1_Click()
On Error GoTo suspect
    Winsock1.RemoteHost = txtHost.Text
    Winsock1.RemotePort = txtPort.Text
    Winsock1.Connect
    Me.lblConnection.Caption = "Status: Connected"
    Exit Sub
suspect:
Me.lblConnection.Caption = "Status: Unable to connect!"
End Sub
Private Sub Command2_Click()
Dim mensahe As String
If Alias = "" Then
    mensahe = Winsock1.LocalHostName & ": " & txtMsg.Text
Else
    mensahe = Alias & ": " & txtMsg.Text
End If
Winsock1.SendData txtData.Text & mensahe
txtData.Text = txtData.Text & mensahe & vbCrLf
txtMsg.Text = ""
txtMsg.SetFocus
End Sub

Private Sub Form_Load()
txtData.Text = ""
txtData.Locked = True
End Sub

Private Sub mnuName_Click()
Alias = InputBox("Enter Name:")
End Sub

Private Sub txtMsg_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Command2_Click
End Sub

Private Sub Winsock1_DataArrival(ByVal bytesTotal As Long)
Dim strData As String
txtData.Text = ""
Winsock1.GetData strData, vbString
txtData.Text = txtData.Text & strData & vbCrLf
End Sub


