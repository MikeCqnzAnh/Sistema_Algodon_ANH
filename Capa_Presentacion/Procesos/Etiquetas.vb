Imports Capa_Operacion.Configuracion
Public Class Etiquetas
    Dim IdProduccion As Integer
    Dim IdOrdenTrabajo As Integer
    Dim IdPlantaOrigen As Integer
    Dim UltimaSecuencia As Long
    Dim LeerEtiqueta As Boolean
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Conf\"
    Dim archivo As String = "config.ini"
    Private Sub Etiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
        LeerArchivoConfiguracion()
        ConsultaUltimaSecuencia()
        Centrar(PControles)
    End Sub
    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbEtiquetaActual.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub ConsultarUltimaPaca()
        'Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        'Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        'Dim Tabla As New DataTable
        'EntidadEtiquetas.Consulta = Consulta.ConsultaPorId
        'EntidadEtiquetas.IdPlanta = CbPlanta.SelectedValue
        'NegocioEtiquetas.Consultar(EntidadEtiquetas)
        'Tabla = EntidadEtiquetas.TablaConsulta
        'TbUltimaPaca.Text = Tabla.Rows(0).Item("Secuencia")
        'If TbUltimaPaca.Text = 0 Then
        '    MsgBox("No hay pacas registradas en producciòn", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        'End If
    End Sub
    Private Sub LeerArchivoConfiguracion()
        If IO.File.Exists(Ruta & archivo) Then
            ObtenerArchivoConfiguracion()
        Else
            MessageBox.Show("No se ha configurado el puerto serial para captura automatica, Contactar al Administrador del sistema para resolverlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function ConsultaEstatusLeerEtiqueta()
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        Dim Tabla As New DataTable
        EntidadEtiquetas.Consulta = Consulta.ConsultaEstatusLeerEtiqueta
        EntidadEtiquetas.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        NegocioEtiquetas.Consultar(EntidadEtiquetas)
        Tabla = EntidadEtiquetas.TablaConsulta
        LeerEtiqueta = Tabla.Rows(0).Item("LeerEtiqueta")
        Return LeerEtiqueta
    End Function
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New IO.StreamReader(Ruta & archivo)
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, vbCrLf)
                CbPlantaOrigen.SelectedValue = ObtenerValor(ArregloCadena(41))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Private Sub LlenarCombos()
        '---Planta--
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        Dim Tabla As New DataTable
        EntidadEtiquetas.Consulta = Consulta.ConsultaExterna
        NegocioEtiquetas.Consultar(EntidadEtiquetas)
        Tabla = EntidadEtiquetas.TablaConsulta
        CbPlantaOrigen.DataSource = Tabla
        CbPlantaOrigen.ValueMember = "IdPlanta"
        CbPlantaOrigen.DisplayMember = "Descripcion"
        CbPlantaOrigen.SelectedValue = 1
    End Sub

    Private Sub Limpiar()
        'TbIdProduccion.Enabled = True
        'TbIdProduccion.Text = ""
        TbEtiquetaActual.Text = ""
        'TbEtiquetaActual.Enabled = False
        'TbIdProduccionInfo.Text = ""
        'TbOrdenTrabajoInfo.Text = ""
        CbPlantaOrigen.SelectedValue = 0
    End Sub

    Private Sub TbEtiquetaActual_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbEtiquetaActual.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                'If ConsultarPacaExistente(TbEtiquetaActual.Text, IdPlantaOrigen) = 1 Then
                '    MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                '    TbEtiquetaActual.Text = ""
                '    Exit Sub
                'Else
                If ConsultaEstatusLeerEtiqueta() = True Then
                    'ActualizarUltimaEtiqueta()
                    ActualizarEtiqueta()
                    ConsultaUltimaSecuencia()
                    'TbEtiquetaActual.Text = ""
                    TbEtiquetaActual.SelectAll()
                Else
                    MessageBox.Show("La opcion de Leer Etiqueta no esta activada en la ventana de Produccion. Activarla para continuar escaneo de etiquetas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                '    If TbEtiquetaActual.Text <> UltimaSecuencia Then
                '        Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(UltimaSecuencia) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                '        If opc = DialogResult.Yes Then
                '            TbEtiquetaActual.Text = UltimaSecuencia
                '            Dim EntidadProduccion As New Capa_Entidad.Produccion
                '            Dim NegocioProduccion As New Capa_Negocio.Produccion
                '            EntidadProduccion.IdProduccionDetalle = 0
                '            EntidadProduccion.IdProduccion = IdProduccion
                '            EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                '            EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                '            EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                '            EntidadProduccion.Tipo = ""
                '            EntidadProduccion.Kilos = 0
                '            EntidadProduccion.BandExiste = True
                '            EntidadProduccion.IdTurno = 1
                '            EntidadProduccion.IdEstatus = 1
                '            EntidadProduccion.Fecha = Now
                '            EntidadProduccion.IdBaja = 0
                '            EntidadProduccion.FechaBaja = Now
                '            EntidadProduccion.ClaveClasificacion = 0
                '            EntidadProduccion.Micros = 0
                '            EntidadProduccion.Castigo = 0
                '            EntidadProduccion.CastigoMicCpa = 0
                '            EntidadProduccion.CastigoMicVta = 0
                '            EntidadProduccion.CastigoLargoFibra = 0
                '            EntidadProduccion.CastigoLargoFibraCpa = 0
                '            EntidadProduccion.CastigoLargoFibraVta = 0
                '            EntidadProduccion.CastigoResistenciaFibra = 0
                '            EntidadProduccion.CastigoResistenciaFibraCpa = 0
                '            EntidadProduccion.CastigoResistenciaFibraVta = 0
                '            EntidadProduccion.ClaveClasificacionCpa = 0
                '            EntidadProduccion.ClaveClasificacionVta = 0
                '            EntidadProduccion.FechaClasificacion = Now
                '            EntidadProduccion.Libras = 0
                '            EntidadProduccion.ClaveCertificado = 0
                '            EntidadProduccion.ClaveContratoAlgodon = 0
                '            EntidadProduccion.ClaveContratoAlgodon2 = 0
                '            EntidadProduccion.ClavePaqueteHVI = 0
                '            EntidadProduccion.LargoFibra = 0
                '            EntidadProduccion.ResistenciaFibra = 0
                '            NegocioProduccion.GuardarDetalle(EntidadProduccion)

                '            TbEtiquetaActual.Text = ""
                '            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                '        Else
                '            Dim EntidadProduccion As New Capa_Entidad.Produccion
                '            Dim NegocioProduccion As New Capa_Negocio.Produccion
                '            EntidadProduccion.IdProduccionDetalle = 0
                '            EntidadProduccion.IdProduccion = IdProduccion
                '            EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                '            EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                '            EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                '            EntidadProduccion.Tipo = ""
                '            EntidadProduccion.Kilos = 0
                '            EntidadProduccion.BandExiste = True
                '            EntidadProduccion.IdTurno = 1
                '            EntidadProduccion.IdEstatus = 1
                '            EntidadProduccion.Fecha = Now
                '            EntidadProduccion.IdBaja = 0
                '            EntidadProduccion.FechaBaja = Now
                '            EntidadProduccion.ClaveClasificacion = 0
                '            EntidadProduccion.Micros = 0
                '            EntidadProduccion.Castigo = 0
                '            EntidadProduccion.CastigoMicCpa = 0
                '            EntidadProduccion.CastigoMicVta = 0
                '            EntidadProduccion.CastigoLargoFibra = 0
                '            EntidadProduccion.CastigoLargoFibraCpa = 0
                '            EntidadProduccion.CastigoLargoFibraVta = 0
                '            EntidadProduccion.CastigoResistenciaFibra = 0
                '            EntidadProduccion.CastigoResistenciaFibraCpa = 0
                '            EntidadProduccion.CastigoResistenciaFibraVta = 0
                '            EntidadProduccion.ClaveClasificacionCpa = 0
                '            EntidadProduccion.ClaveClasificacionVta = 0
                '            EntidadProduccion.FechaClasificacion = Now
                '            EntidadProduccion.Libras = 0
                '            EntidadProduccion.ClaveCertificado = 0
                '            EntidadProduccion.ClaveContratoAlgodon = 0
                '            EntidadProduccion.ClaveContratoAlgodon2 = 0
                '            EntidadProduccion.ClavePaqueteHVI = 0
                '            EntidadProduccion.LargoFibra = 0
                '            EntidadProduccion.ResistenciaFibra = 0
                '            NegocioProduccion.GuardarDetalle(EntidadProduccion)
                '            ActualizarUltimaEtiqueta()
                '            TbEtiquetaActual.Text = ""
                '        End If
                '    Else
                '        Dim EntidadProduccion As New Capa_Entidad.Produccion
                '        Dim NegocioProduccion As New Capa_Negocio.Produccion
                '        EntidadProduccion.IdProduccionDetalle = 0
                '        EntidadProduccion.IdProduccion = IdProduccion
                '        EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                '        EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                '        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                '        EntidadProduccion.Tipo = ""
                '        EntidadProduccion.Kilos = 0
                '        EntidadProduccion.BandExiste = True
                '        EntidadProduccion.IdTurno = 1
                '        EntidadProduccion.IdEstatus = 1
                '        EntidadProduccion.Fecha = Now
                '        EntidadProduccion.IdBaja = 0
                '        EntidadProduccion.FechaBaja = Now
                '        EntidadProduccion.ClaveClasificacion = 0
                '        EntidadProduccion.Micros = 0
                '        EntidadProduccion.Castigo = 0
                '        EntidadProduccion.CastigoMicCpa = 0
                '        EntidadProduccion.CastigoMicVta = 0
                '        EntidadProduccion.CastigoLargoFibra = 0
                '        EntidadProduccion.CastigoLargoFibraCpa = 0
                '        EntidadProduccion.CastigoLargoFibraVta = 0
                '        EntidadProduccion.CastigoResistenciaFibra = 0
                '        EntidadProduccion.CastigoResistenciaFibraCpa = 0
                '        EntidadProduccion.CastigoResistenciaFibraVta = 0
                '        EntidadProduccion.ClaveClasificacionCpa = 0
                '        EntidadProduccion.ClaveClasificacionVta = 0
                '        EntidadProduccion.FechaClasificacion = Now
                '        EntidadProduccion.Libras = 0
                '        EntidadProduccion.ClaveCertificado = 0
                '        EntidadProduccion.ClaveContratoAlgodon = 0
                '        EntidadProduccion.ClaveContratoAlgodon2 = 0
                '        EntidadProduccion.ClavePaqueteHVI = 0
                '        EntidadProduccion.LargoFibra = 0
                '        EntidadProduccion.ResistenciaFibra = 0
                '        NegocioProduccion.GuardarDetalle(EntidadProduccion)
                '        ActualizarUltimaEtiqueta()
                '        TbEtiquetaActual.Text = ""
                '    End If
                'End If
        End Select
    End Sub


    'Private Sub TbIdProduccion_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Select Case e.KeyData
    '        Case Keys.Enter
    '            Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
    '            Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
    '            Dim Tabla As New DataTable
    '            EntidadEtiquetas.Consulta = Consulta.ConsultaOrden
    '            EntidadEtiquetas.IdProduccion = CInt(TbIdProduccion.Text)
    '            NegocioEtiquetas.Consultar(EntidadEtiquetas)
    '            Tabla = EntidadEtiquetas.TablaConsulta
    '            If Tabla.Rows.Count <> 0 Then
    '                IdProduccion = Tabla.Rows(0).Item("IdProduccion")
    '                IdOrdenTrabajo = Tabla.Rows(0).Item("IdOrdenTrabajo")
    '                IdPlantaOrigen = Tabla.Rows(0).Item("IdPlantaOrigen")
    '                TbIdProduccionInfo.Text = IdProduccion
    '                TbOrdenTrabajoInfo.Text = IdOrdenTrabajo
    '                CbPlantaOrigen.SelectedValue = IdPlantaOrigen
    '                TbEtiquetaActual.Enabled = True
    '                TbEtiquetaActual.Focus()
    '                ConsultaUltimaSecuencia()
    '            Else
    '                MsgBox("No hay pacas registradas en producciòn", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
    '            End If
    '    End Select
    'End Sub
    Private Function ConsultarPacaExistente(ByVal FolioCIA As Long, ByVal IdPlantaElabora As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPacaExistente
        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows(0).Item("Resultado") = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub ConsultaUltimaSecuencia()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaSecuencia
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            UltimaSecuencia = 1
        Else
            UltimaSecuencia = Tabla.Rows(0).Item("Secuencia")
            TbEtiquetaSiguiente.Text = Tabla.Rows(0).Item("Secuencia")
        End If
    End Sub

    Private Sub ActualizarUltimaEtiqueta()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
        NegocioProduccion.GuardarEtiqueta(EntidadProduccion)
    End Sub
    Private Sub ActualizarEtiqueta()
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        Dim Tabla As New DataTable
        EntidadEtiquetas.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadEtiquetas.Etiqueta = TbEtiquetaActual.Text
        NegocioEtiquetas.Actualizar(EntidadEtiquetas)
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        ConsultaUltimaSecuencia()
    End Sub
End Class