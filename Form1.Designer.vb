<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt1 = New TextBox()
        txt2 = New TextBox()
        C1 = New ComboBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(225, 153)
        txt1.Name = "txt1"
        txt1.Size = New Size(100, 23)
        txt1.TabIndex = 0
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(225, 198)
        txt2.Name = "txt2"
        txt2.Size = New Size(100, 23)
        txt2.TabIndex = 1
        ' 
        ' C1
        ' 
        C1.FormattingEnabled = True
        C1.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicar", "Dividir"})
        C1.Location = New Point(225, 250)
        C1.Name = "C1"
        C1.Size = New Size(121, 23)
        C1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(225, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 23)
        Button1.TabIndex = 3
        Button1.Text = "Total"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 4
        Label1.Text = "Ingrese un numero:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 15)
        Label2.TabIndex = 5
        Label2.Text = "Ingrese un segundo numero:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(C1)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents C1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
