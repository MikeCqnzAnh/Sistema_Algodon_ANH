' Capa_Datos/Interfaces/IUsuarioRepositorio.vb
Imports System
Imports System.Threading.Tasks
Imports Capa_Entidad

Public Interface IUsuarioRepositorio
    Function ObtenerPorUsuarioAsync(usuario As String) As Task(Of Usuario) ' ← cambiado
    Function GuardarTokenRecuperacionAsync(id As Integer, token As String, expiracion As DateTime) As Task(Of Boolean)
    Function ActualizarPasswordAsync(id As Integer, hash As String, salt As String) As Task(Of Boolean)
    Function ObtenerPorTokenAsync(token As String) As Task(Of Usuario)
End Interface