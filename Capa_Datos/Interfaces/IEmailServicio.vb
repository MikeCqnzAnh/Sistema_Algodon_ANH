' Capa_Negocio/Interfaces/IEmailServicio.vb
Imports System.Threading.Tasks

Public Interface IEmailServicio
    Function EnviarRecuperacionAsync(emailDestino As String, token As String) As Task(Of Boolean)
    Function EnviarBienvenidaAsync(emailDestino As String, nombre As String) As Task(Of Boolean)
    Function EnviarAvisoLicenciaAsync(emailDestino As String, diasRestantes As Integer) As Task(Of Boolean)
End Interface