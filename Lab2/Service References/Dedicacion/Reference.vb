﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace Dedicacion
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Dedicacion.DedicacionNoPresencialSoap")>  _
    Public Interface DedicacionNoPresencialSoap
        
        'CODEGEN: Generating message contract since element name asig from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Dedicacion", ReplyAction:="*")>  _
        Function Dedicacion(ByVal request As Dedicacion.DedicacionRequest) As Dedicacion.DedicacionResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Dedicacion", ReplyAction:="*")>  _
        Function DedicacionAsync(ByVal request As Dedicacion.DedicacionRequest) As System.Threading.Tasks.Task(Of Dedicacion.DedicacionResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class DedicacionRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Dedicacion", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Dedicacion.DedicacionRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Dedicacion.DedicacionRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DedicacionRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public asig As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal asig As String)
            MyBase.New
            Me.asig = asig
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class DedicacionResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="DedicacionResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Dedicacion.DedicacionResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Dedicacion.DedicacionResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DedicacionResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public DedicacionResult As Double
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal DedicacionResult As Double)
            MyBase.New
            Me.DedicacionResult = DedicacionResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface DedicacionNoPresencialSoapChannel
        Inherits Dedicacion.DedicacionNoPresencialSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class DedicacionNoPresencialSoapClient
        Inherits System.ServiceModel.ClientBase(Of Dedicacion.DedicacionNoPresencialSoap)
        Implements Dedicacion.DedicacionNoPresencialSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Dedicacion_DedicacionNoPresencialSoap_Dedicacion(ByVal request As Dedicacion.DedicacionRequest) As Dedicacion.DedicacionResponse Implements Dedicacion.DedicacionNoPresencialSoap.Dedicacion
            Return MyBase.Channel.Dedicacion(request)
        End Function
        
        Public Function Dedicacion(ByVal asig As String) As Double
            Dim inValue As Dedicacion.DedicacionRequest = New Dedicacion.DedicacionRequest()
            inValue.Body = New Dedicacion.DedicacionRequestBody()
            inValue.Body.asig = asig
            Dim retVal As Dedicacion.DedicacionResponse = CType(Me,Dedicacion.DedicacionNoPresencialSoap).Dedicacion(inValue)
            Return retVal.Body.DedicacionResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Dedicacion_DedicacionNoPresencialSoap_DedicacionAsync(ByVal request As Dedicacion.DedicacionRequest) As System.Threading.Tasks.Task(Of Dedicacion.DedicacionResponse) Implements Dedicacion.DedicacionNoPresencialSoap.DedicacionAsync
            Return MyBase.Channel.DedicacionAsync(request)
        End Function
        
        Public Function DedicacionAsync(ByVal asig As String) As System.Threading.Tasks.Task(Of Dedicacion.DedicacionResponse)
            Dim inValue As Dedicacion.DedicacionRequest = New Dedicacion.DedicacionRequest()
            inValue.Body = New Dedicacion.DedicacionRequestBody()
            inValue.Body.asig = asig
            Return CType(Me,Dedicacion.DedicacionNoPresencialSoap).DedicacionAsync(inValue)
        End Function
    End Class
End Namespace
