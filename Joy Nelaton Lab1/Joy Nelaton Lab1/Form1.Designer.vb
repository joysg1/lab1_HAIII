﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbEnunT = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.tbLado1 = New System.Windows.Forms.TextBox()
        Me.tbLado2 = New System.Windows.Forms.TextBox()
        Me.tbLado3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam Libre", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DISCRIMINANTE DE TRIÁNGULO RECTÁNGULOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lado 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lado 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lado 3"
        '
        'lbEnunT
        '
        Me.lbEnunT.AutoSize = True
        Me.lbEnunT.Location = New System.Drawing.Point(334, 121)
        Me.lbEnunT.Name = "lbEnunT"
        Me.lbEnunT.Size = New System.Drawing.Size(72, 17)
        Me.lbEnunT.TabIndex = 4
        Me.lbEnunT.Text = "Resultado"
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Location = New System.Drawing.Point(424, 121)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(0, 17)
        Me.lbResult.TabIndex = 5
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(274, 267)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(150, 47)
        Me.btnVerificar.TabIndex = 6
        Me.btnVerificar.Text = "DETERMINAR"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'tbLado1
        '
        Me.tbLado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLado1.Location = New System.Drawing.Point(131, 111)
        Me.tbLado1.Name = "tbLado1"
        Me.tbLado1.Size = New System.Drawing.Size(42, 30)
        Me.tbLado1.TabIndex = 7
        Me.tbLado1.Text = "0"
        '
        'tbLado2
        '
        Me.tbLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLado2.Location = New System.Drawing.Point(131, 167)
        Me.tbLado2.Name = "tbLado2"
        Me.tbLado2.Size = New System.Drawing.Size(42, 30)
        Me.tbLado2.TabIndex = 8
        Me.tbLado2.Text = "0"
        '
        'tbLado3
        '
        Me.tbLado3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLado3.Location = New System.Drawing.Point(131, 225)
        Me.tbLado3.Name = "tbLado3"
        Me.tbLado3.Size = New System.Drawing.Size(42, 30)
        Me.tbLado3.TabIndex = 9
        Me.tbLado3.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 340)
        Me.Controls.Add(Me.tbLado3)
        Me.Controls.Add(Me.tbLado2)
        Me.Controls.Add(Me.tbLado1)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lbEnunT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "JOY NELATON 8-902-1282"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbEnunT As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents tbLado1 As TextBox
    Friend WithEvents tbLado2 As TextBox
    Friend WithEvents tbLado3 As TextBox
End Class
