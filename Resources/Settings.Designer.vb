﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property Unique() As Long
        Get
            Return CType(Me("Unique"),Long)
        End Get
        Set
            Me("Unique") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property LastRun() As Long
        Get
            Return CType(Me("LastRun"),Long)
        End Get
        Set
            Me("LastRun") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property FirstRun() As Long
        Get
            Return CType(Me("FirstRun"),Long)
        End Get
        Set
            Me("FirstRun") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property NumberOfRuns() As Long
        Get
            Return CType(Me("NumberOfRuns"),Long)
        End Get
        Set
            Me("NumberOfRuns") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("free.pt")>  _
    Public Property HeaderGroup() As String
        Get
            Return CType(Me("HeaderGroup"),String)
        End Get
        Set
            Me("HeaderGroup") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("alt.binaries.ftd")>  _
    Public Property NZBGroup() As String
        Get
            Return CType(Me("NZBGroup"),String)
        End Get
        Set
            Me("NZBGroup") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("free.usenet")>  _
    Public Property ReplyGroup() As String
        Get
            Return CType(Me("ReplyGroup"),String)
        End Get
        Set
            Me("ReplyGroup") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("free.willey")>  _
    Public Property ReportGroup() As String
        Get
            Return CType(Me("ReportGroup"),String)
        End Get
        Set
            Me("ReportGroup") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property CheckSignatures() As Boolean
        Get
            Return CType(Me("CheckSignatures"),Boolean)
        End Get
        Set
            Me("CheckSignatures") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property DownloadAction() As Byte
        Get
            Return CType(Me("DownloadAction"),Byte)
        End Get
        Set
            Me("DownloadAction") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DownloadFolder() As String
        Get
            Return CType(Me("DownloadFolder"),String)
        End Get
        Set
            Me("DownloadFolder") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Nickname() As String
        Get
            Return CType(Me("Nickname"),String)
        End Get
        Set
            Me("Nickname") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Tagname() As String
        Get
            Return CType(Me("Tagname"),String)
        End Get
        Set
            Me("Tagname") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Avatar() As String
        Get
            Return CType(Me("Avatar"),String)
        End Get
        Set
            Me("Avatar") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property AutoUpdate() As Boolean
        Get
            Return CType(Me("AutoUpdate"),Boolean)
        End Get
        Set
            Me("AutoUpdate") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("14")>  _
    Public Property FontSize() As Byte
        Get
            Return CType(Me("FontSize"),Byte)
        End Get
        Set
            Me("FontSize") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("localhost")>  _
    Public Property SabHost() As String
        Get
            Return CType(Me("SabHost"),String)
        End Get
        Set
            Me("SabHost") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("8090")>  _
    Public Property SabPort() As Integer
        Get
            Return CType(Me("SabPort"),Integer)
        End Get
        Set
            Me("SabPort") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property SabAPI() As String
        Get
            Return CType(Me("SabAPI"),String)
        End Get
        Set
            Me("SabAPI") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1000")>  _
    Public Property SabRefresh() As Integer
        Get
            Return CType(Me("SabRefresh"),Integer)
        End Get
        Set
            Me("SabRefresh") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property WindowTop() As Double
        Get
            Return CType(Me("WindowTop"),Double)
        End Get
        Set
            Me("WindowTop") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property WindowLeft() As Double
        Get
            Return CType(Me("WindowLeft"),Double)
        End Get
        Set
            Me("WindowLeft") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property WindowWidth() As Double
        Get
            Return CType(Me("WindowWidth"),Double)
        End Get
        Set
            Me("WindowWidth") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property WindowHeight() As Double
        Get
            Return CType(Me("WindowHeight"),Double)
        End Get
        Set
            Me("WindowHeight") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property WindowMaximized() As Boolean
        Get
            Return CType(Me("WindowMaximized"),Boolean)
        End Get
        Set
            Me("WindowMaximized") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property SystemTray() As Boolean
        Get
            Return CType(Me("SystemTray"),Boolean)
        End Get
        Set
            Me("SystemTray") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property GoogleSuggest() As Boolean
        Get
            Return CType(Me("GoogleSuggest"),Boolean)
        End Get
        Set
            Me("GoogleSuggest") = value
        End Set
    End Property
       
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property ShowComments() As Boolean
        Get
            Return CType(Me("ShowComments"),Boolean)
        End Get
        Set
            Me("ShowComments") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property SaveTabs() As Boolean
        Get
            Return CType(Me("SaveTabs"),Boolean)
        End Get
        Set
            Me("SaveTabs") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property LastFolder() As String
        Get
            Return CType(Me("LastFolder"),String)
        End Get
        Set
            Me("LastFolder") = value
        End Set
    End Property
       
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("5000")>  _
    Public Property MaxResults() As Integer
        Get
            Return CType(Me("MaxResults"),Integer)
        End Get
        Set
            Me("MaxResults") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("rowid")>  _
    Public Property SortColumn() As String
        Get
            Return CType(Me("SortColumn"),String)
        End Get
        Set
            Me("SortColumn") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("DESC")>  _
    Public Property SortDirection() As String
        Get
            Return CType(Me("SortDirection"),String)
        End Get
        Set
            Me("SortDirection") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1234005000")>  _
    Public Property Columns() As String
        Get
            Return CType(Me("Columns"),String)
        End Get
        Set
            Me("Columns") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property AdvancedSearch() As Boolean
        Get
            Return CType(Me("AdvancedSearch"),Boolean)
        End Get
        Set
            Me("AdvancedSearch") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property RemoveDownloads() As Boolean
        Get
            Return CType(Me("RemoveDownloads"),Boolean)
        End Get
        Set
            Me("RemoveDownloads") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property ExternalBrowser() As Boolean
        Get
            Return CType(Me("ExternalBrowser"),Boolean)
        End Get
        Set
            Me("ExternalBrowser") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property DatabaseMax() As Long
        Get
            Return CType(Me("DatabaseMax"),Long)
        End Get
        Set
            Me("DatabaseMax") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property DatabaseCount() As Long
        Get
            Return CType(Me("DatabaseCount"),Long)
        End Get
        Set
            Me("DatabaseCount") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("72500")>  _
    Public Property DatabaseCache() As Integer
        Get
            Return CType(Me("DatabaseCache"),Integer)
        End Get
        Set
            Me("DatabaseCache") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property DatabaseFilter() As Long
        Get
            Return CType(Me("DatabaseFilter"),Long)
        End Get
        Set
            Me("DatabaseFilter") = value
        End Set
    End Property
      
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property KeysURL() As String
        Get
            Return CType(Me("KeysURL"),String)
        End Get
        Set
            Me("KeysURL") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property WhitelistURL() As String
        Get
            Return CType(Me("WhitelistURL"),String)
        End Get
        Set
            Me("WhitelistURL") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Configuration.SettingsProviderAttribute(GetType(PortableSettingsProvider)),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property BlacklistURL() As String
        Get
            Return CType(Me("BlacklistURL"),String)
        End Get
        Set
            Me("BlacklistURL") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Spotnet.MySettings
            Get
                Return Global.Spotnet.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
