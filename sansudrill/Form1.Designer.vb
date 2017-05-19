<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'InBox
        '
        Me.InBox.Location = New System.Drawing.Point(63, 255)
        Me.InBox.Name = "InBox"
        Me.InBox.Size = New System.Drawing.Size(80, 19)
        Me.InBox.TabIndex = 0
        Me.InBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "答え"
        '
        'OutBox
        '
        Me.OutBox.Location = New System.Drawing.Point(169, 89)
        Me.OutBox.Multiline = True
        Me.OutBox.Name = "OutBox"
        Me.OutBox.ReadOnly = True
        Me.OutBox.Size = New System.Drawing.Size(130, 185)
        Me.OutBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 307)
        Me.Controls.Add(Me.OutBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InBox)
        Me.Name = "Form1"
        Me.Text = "算数ドリル"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutBox As TextBox
End Class
