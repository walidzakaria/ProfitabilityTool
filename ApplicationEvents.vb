﻿Imports System.Collections.ObjectModel

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' This is to change min time for displaying the splash screen
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 4000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
    End Class
End Namespace
