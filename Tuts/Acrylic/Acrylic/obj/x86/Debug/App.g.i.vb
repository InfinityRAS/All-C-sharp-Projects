﻿#ExternalChecksum("C:\Users\AryanSisodiya\source\repos\Tuts\Acrylic\Acrylic\App.xaml", "{8829d00f-11b8-4213-878b-770e8597ac16}", "A5EC795D94E6CE4BAC9EA497B57D427600A9DABA3D7B8339C1EA72A229E5504F")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.Acrylic

#If Not DISABLE_XAML_GENERATED_MAIN Then
Public Class Program

    <MTAThread()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Shared Sub Main(ByVal args() As String)
        Global.Windows.UI.Xaml.Application.Start(Function(p) New Global.Acrylic.App())
    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Sub Program
    End Sub

End Class
#End If


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Class App
    Inherits Global.Windows.UI.Xaml.Application

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")>  _
    Private _contentLoaded As Boolean
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true

#If Debug AndAlso Not DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT Then
        AddHandler Me.DebugSettings.BindingFailed,
            Sub(Sender As Global.System.Object, bindingFailedArgs As Global.Windows.UI.Xaml.BindingFailedEventArgs)
                Global.System.Diagnostics.Debug.WriteLine(bindingFailedArgs.Message)
            End Sub
#End If

#If Debug AndAlso Not DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION Then
        AddHandler Me.UnhandledException,
            Sub(sender As Global.System.Object, unhandledExceptionArgs As Global.Windows.UI.Xaml.UnhandledExceptionEventArgs)
                If Global.System.Diagnostics.Debugger.IsAttached Then
                    Global.System.Diagnostics.Debugger.Break()
                End If
            End Sub
#End If
    End Sub

End Class

End Namespace

