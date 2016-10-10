'@author    Cozy Vision Technologies Pvt. Ltd.
'@copyright 2010-2016 cozyvision Technology Pvt Ltd.

Imports Microsoft.VisualBasic

Public Class MissDial
    Private number As String  'Declare number of caller
    Private Datetime As String 'Declare datetime of caller
    Private Circle As String 'Declare the area from where caller called
    Private Mob_Operator As String 'shows the caller operator
    Private Dnd As String 'Define that number is dnd or not
    Private Prefix As String 'Define the country code

    'constructor  gives value of variable
    Sub New(ByVal num As String, Optional ByVal dtTime As String = "", Optional ByVal circles As String = "", Optional ByVal mobOperator As String = "", Optional ByVal Dnds As String = "", Optional ByVal prefixs As String = "")
        number = num
        Datetime = dtTime
        Circle = circles
        Mob_Operator = mobOperator
        Dnd = Dnds
        Prefix = prefixs
    End Sub

    Property getNumber() As String
        Get
            Return number
        End Get
        Set(ByVal value As String)
            number = value
        End Set
    End Property

    Property getDateTime() As String
        Get
            Return Datetime
        End Get
        Set(ByVal value As String)
            Datetime = value
        End Set
    End Property

    Property getCircle() As String
        Get
            Return Circle
        End Get
        Set(ByVal value As String)
            Circle = value
        End Set
    End Property

    Property getMobOperator() As String
        Get
            Return Mob_Operator
        End Get
        Set(ByVal value As String)
            Mob_Operator = value
        End Set
    End Property

    Property getDnd() As String
        Get
            Return Dnd
        End Get
        Set(ByVal value As String)
            Dnd = value
        End Set
    End Property

    Property getPrefix() As String
        Get
            Return Prefix
        End Get
        Set(ByVal value As String)
            Prefix = value
        End Set
    End Property

End Class
