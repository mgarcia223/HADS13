﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
'
Namespace DediAlum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="HorasAlumnosSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HorasAlumnos
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private HestiOperationCompleted As System.Threading.SendOrPostCallback
        
        Private HrealOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DiferenciaOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Lab2.My.MySettings.Default.Lab2_DediAlum_HorasAlumnos
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event HestiCompleted As HestiCompletedEventHandler
        
        '''<remarks/>
        Public Event HrealCompleted As HrealCompletedEventHandler
        
        '''<remarks/>
        Public Event DiferenciaCompleted As DiferenciaCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Hesti", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Hesti(ByVal asig As String, ByVal email As String) As Integer
            Dim results() As Object = Me.Invoke("Hesti", New Object() {asig, email})
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HestiAsync(ByVal asig As String, ByVal email As String)
            Me.HestiAsync(asig, email, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HestiAsync(ByVal asig As String, ByVal email As String, ByVal userState As Object)
            If (Me.HestiOperationCompleted Is Nothing) Then
                Me.HestiOperationCompleted = AddressOf Me.OnHestiOperationCompleted
            End If
            Me.InvokeAsync("Hesti", New Object() {asig, email}, Me.HestiOperationCompleted, userState)
        End Sub
        
        Private Sub OnHestiOperationCompleted(ByVal arg As Object)
            If (Not (Me.HestiCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HestiCompleted(Me, New HestiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Hreal", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Hreal(ByVal asig As String, ByVal email As String) As Integer
            Dim results() As Object = Me.Invoke("Hreal", New Object() {asig, email})
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HrealAsync(ByVal asig As String, ByVal email As String)
            Me.HrealAsync(asig, email, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HrealAsync(ByVal asig As String, ByVal email As String, ByVal userState As Object)
            If (Me.HrealOperationCompleted Is Nothing) Then
                Me.HrealOperationCompleted = AddressOf Me.OnHrealOperationCompleted
            End If
            Me.InvokeAsync("Hreal", New Object() {asig, email}, Me.HrealOperationCompleted, userState)
        End Sub
        
        Private Sub OnHrealOperationCompleted(ByVal arg As Object)
            If (Not (Me.HrealCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HrealCompleted(Me, New HrealCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Diferencia", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Diferencia(ByVal hesti As Integer, ByVal hreal As Integer) As Integer
            Dim results() As Object = Me.Invoke("Diferencia", New Object() {hesti, hreal})
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub DiferenciaAsync(ByVal hesti As Integer, ByVal hreal As Integer)
            Me.DiferenciaAsync(hesti, hreal, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DiferenciaAsync(ByVal hesti As Integer, ByVal hreal As Integer, ByVal userState As Object)
            If (Me.DiferenciaOperationCompleted Is Nothing) Then
                Me.DiferenciaOperationCompleted = AddressOf Me.OnDiferenciaOperationCompleted
            End If
            Me.InvokeAsync("Diferencia", New Object() {hesti, hreal}, Me.DiferenciaOperationCompleted, userState)
        End Sub
        
        Private Sub OnDiferenciaOperationCompleted(ByVal arg As Object)
            If (Not (Me.DiferenciaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DiferenciaCompleted(Me, New DiferenciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub HestiCompletedEventHandler(ByVal sender As Object, ByVal e As HestiCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HestiCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub HrealCompletedEventHandler(ByVal sender As Object, ByVal e As HrealCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HrealCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub DiferenciaCompletedEventHandler(ByVal sender As Object, ByVal e As DiferenciaCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class DiferenciaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
End Namespace
