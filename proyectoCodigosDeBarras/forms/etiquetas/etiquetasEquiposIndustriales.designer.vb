﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class etiquetasEquiposIndustriales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bImprimir = New System.Windows.Forms.Button()
        Me.txCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNumeroSerieInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckVolverImprimir = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txCopias = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbImpresoras = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txnumeroSerieFinal = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bSalir.Location = New System.Drawing.Point(564, 13)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(126, 70)
        Me.bSalir.TabIndex = 8
        Me.bSalir.Text = "SALIR"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bImprimir
        '
        Me.bImprimir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bImprimir.Location = New System.Drawing.Point(432, 13)
        Me.bImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(126, 70)
        Me.bImprimir.TabIndex = 6
        Me.bImprimir.Text = "IMPRIMIR"
        Me.bImprimir.UseVisualStyleBackColor = True
        '
        'txCantidad
        '
        Me.txCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txCantidad.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCantidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txCantidad.Location = New System.Drawing.Point(283, 353)
        Me.txCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txCantidad.MaxLength = 4
        Me.txCantidad.Name = "txCantidad"
        Me.txCantidad.Size = New System.Drawing.Size(75, 31)
        Me.txCantidad.TabIndex = 3
        Me.txCantidad.Text = "1"
        Me.txCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(18, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 22)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "CANTIDAD Nº SERIE"
        '
        'txNumeroSerieInicial
        '
        Me.txNumeroSerieInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txNumeroSerieInicial.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNumeroSerieInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txNumeroSerieInicial.Location = New System.Drawing.Point(199, 91)
        Me.txNumeroSerieInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txNumeroSerieInicial.MaxLength = 9
        Me.txNumeroSerieInicial.Name = "txNumeroSerieInicial"
        Me.txNumeroSerieInicial.ReadOnly = True
        Me.txNumeroSerieInicial.Size = New System.Drawing.Size(491, 31)
        Me.txNumeroSerieInicial.TabIndex = 1
        Me.txNumeroSerieInicial.Text = "0"
        Me.txNumeroSerieInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 22)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Nº SERIE INICIAL"
        '
        'ckVolverImprimir
        '
        Me.ckVolverImprimir.AutoSize = True
        Me.ckVolverImprimir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckVolverImprimir.ForeColor = System.Drawing.Color.DarkBlue
        Me.ckVolverImprimir.Location = New System.Drawing.Point(22, 280)
        Me.ckVolverImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckVolverImprimir.Name = "ckVolverImprimir"
        Me.ckVolverImprimir.Size = New System.Drawing.Size(388, 26)
        Me.ckVolverImprimir.TabIndex = 0
        Me.ckVolverImprimir.Text = "VOLVER A IMPRIMIR Nº SERIE IMPRESOS"
        Me.ckVolverImprimir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(13, 209)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(376, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 22)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Nº COPIAS POR Nº SERIE"
        '
        'txCopias
        '
        Me.txCopias.BackColor = System.Drawing.SystemColors.Window
        Me.txCopias.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCopias.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txCopias.Location = New System.Drawing.Point(625, 353)
        Me.txCopias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txCopias.MaxLength = 1
        Me.txCopias.Name = "txCopias"
        Me.txCopias.Size = New System.Drawing.Size(75, 31)
        Me.txCopias.TabIndex = 4
        Me.txCopias.Text = "1"
        Me.txCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.bImprimir)
        Me.Panel2.Controls.Add(Me.txNumeroSerieInicial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbImpresoras)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 182)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ERP_SUGAR.My.Resources.Resources.impresora
        Me.PictureBox1.Location = New System.Drawing.Point(283, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(18, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 22)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "IMPRESORA"
        '
        'cbImpresoras
        '
        Me.cbImpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpresoras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbImpresoras.FormattingEnabled = True
        Me.cbImpresoras.Location = New System.Drawing.Point(199, 129)
        Me.cbImpresoras.Name = "cbImpresoras"
        Me.cbImpresoras.Size = New System.Drawing.Size(491, 30)
        Me.cbImpresoras.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(363, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 22)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Nº SERIE FINAL"
        '
        'txnumeroSerieFinal
        '
        Me.txnumeroSerieFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txnumeroSerieFinal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnumeroSerieFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txnumeroSerieFinal.Location = New System.Drawing.Point(521, 314)
        Me.txnumeroSerieFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txnumeroSerieFinal.MaxLength = 9
        Me.txnumeroSerieFinal.Name = "txnumeroSerieFinal"
        Me.txnumeroSerieFinal.Size = New System.Drawing.Size(179, 31)
        Me.txnumeroSerieFinal.TabIndex = 2
        Me.txnumeroSerieFinal.Text = "0"
        Me.txnumeroSerieFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ERP_SUGAR.My.Resources.Resources.LOGO_SUGAR_1_200
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 166
        Me.PictureBox2.TabStop = False
        '
        'etiquetasEquiposIndustriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 179)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckVolverImprimir)
        Me.Controls.Add(Me.txnumeroSerieFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txCopias)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "etiquetasEquiposIndustriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ETIQUETAS EQUIPOS INDUSTRIALES"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents bImprimir As Button
    Friend WithEvents txCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txNumeroSerieInicial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ckVolverImprimir As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txCopias As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbImpresoras As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txnumeroSerieFinal As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
