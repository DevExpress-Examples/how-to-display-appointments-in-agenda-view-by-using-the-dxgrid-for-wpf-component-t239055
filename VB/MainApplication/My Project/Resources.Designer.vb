﻿' Developer Express Code Central Example:
' How to display appointments in Agenda View by using the DXGrid for WPF component
' 
' The Agenda view is a list of upcoming events grouped by the appointment's date.
' This list can be displayed in the GridControl component
' (https://documentation.devexpress.com/#WPF/CustomDocument6294).
' 
' This example
' demonstrates how to implement this behavior.
' 
' 
' Please see "Implementation
' Details" (click the corresponding link below this text) to learn more about
' technical aspects of this approach implementation.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T239055

Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property AppointmentImages() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("AppointmentImages", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property DayView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DayView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Delete() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Delete", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property GanttView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("GanttView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property MaxFowlerPhoto() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MaxFowlerPhoto", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property MonthView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MonthView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property NancyDrewmorePhoto() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NancyDrewmorePhoto", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property NextArrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NextArrow", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property no_photo_icon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("no_photo_icon", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property PrevArrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("PrevArrow", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Report() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Report", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property TimelineView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TimelineView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property WeekView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WeekView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property WorkWeekView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WorkWeekView", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property
    End Module
End Namespace