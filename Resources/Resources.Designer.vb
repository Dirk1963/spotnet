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

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Spotnet.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''&lt;DIV style=&quot;margin-bottom: 20px&quot;&gt;  
        '''   &lt;DIV style=&quot;TEXT-ALIGN: right; FLOAT: right; margin-top: -15px; VERTICAL-ALIGN: top;&quot;&gt;
        '''	&lt;TABLE&gt;
        '''	&lt;TR&gt;       
        '''	    &lt;TD&gt;&lt;A CLASS=&quot;[SN:CLASS]&quot; HREF=&quot;menu:[SN:MODULUS]_[SN:FROM]&quot; title=&quot;[SN:TOOLTIP]&quot; onfocus=&apos;this.blur()&apos;&gt;&lt;B&gt;[SN:FROM]&lt;/B&gt;&lt;/A&gt;&lt;BR&gt;&lt;SPAN CLASS=&quot;date&quot;&gt;[SN:DATE]&lt;/SPAN&gt;&lt;/TD&gt;
        '''	    &lt;TD&gt;&lt;IMG HEIGHT=32 WIDTH=32 ALT=&quot;[SN:TOOLTIP]&quot; STYLE=&quot;margin-left: 5px;&quot; SRC=&quot;http://www.gravatar.com/avatar/[SN:MD5]?s=32&amp;d=identicon&quot;&gt;&lt;/TD&gt;
        '''	&lt;/TR&gt;
        '''	&lt;/TABLE&gt;
        '''   &lt;/DIV&gt;
        '''   [S [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property comment() As String
            Get
                Return ResourceManager.GetString("comment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to __version__ = 18
        '''</summary>
        Friend ReadOnly Property sabnzbd() As String
            Get
                Return ResourceManager.GetString("sabnzbd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.01 Transitional//EN&quot; &quot;http://www.w3.org/TR/html4/loose.dtd&quot;&gt;
           '''  &lt;META HTTP-EQUIV=&quot; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property spot() As String
            Get
                Return ResourceManager.GetString("spot", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
