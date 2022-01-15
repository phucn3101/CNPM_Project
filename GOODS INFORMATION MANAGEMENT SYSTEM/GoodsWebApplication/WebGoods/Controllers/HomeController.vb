Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebGoods

Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Private db As New DBSEntities

    ' GET: products
    Function Index() As ActionResult
        Dim products = db.products.Include(Function(p) p.category)
        Return View(products.ToList())
    End Function


    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
