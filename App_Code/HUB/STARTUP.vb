Imports Microsoft.Owin
Imports Owin
Imports Microsoft.AspNet.SignalR
<Assembly: OwinStartup(GetType(signalr.Startup))>

Namespace signalr
    Public Class Startup
        Public Sub Configuration(app As IAppBuilder)
            ' Any connection or hub wire up and configuration should go here
            Dim hubConfiguration = New HubConfiguration
            hubConfiguration.EnableDetailedErrors = True
            app.MapSignalR(hubConfiguration)
        End Sub
    End Class
End Namespace