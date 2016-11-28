Imports Microsoft.VisualBasic
Imports System
Imports Microsoft.AspNet.SignalR
Imports Microsoft.AspNet.SignalR.Hubs
Imports Microsoft.AspNet.SignalR.Transports
Imports Microsoft.AspNet.SignalR.Infrastructure
Imports System.Threading.Tasks
Imports System.Data
Imports System.Linq
Imports JSON.Namespace
Imports System.Text
Imports System.Web
Imports System.Web.Script.Serialization
Imports System.Globalization

Namespace signalr
    Public Class ChatHub
        Inherits Hub

        Public Sub hub_send_message(name As String, message As String)
            Clients.All.broadcastMessage(name, message)
        End Sub

    End Class

End Namespace
