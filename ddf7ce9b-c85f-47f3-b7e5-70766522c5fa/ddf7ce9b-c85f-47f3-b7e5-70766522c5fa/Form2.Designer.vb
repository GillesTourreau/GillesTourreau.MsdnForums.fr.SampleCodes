﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'annuler
        '
        Me.annuler.Location = New System.Drawing.Point(98, 102)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(75, 23)
        Me.annuler.TabIndex = 0
        Me.annuler.Text = "Button1"
        Me.annuler.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.annuler)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents annuler As System.Windows.Forms.Button
End Class
