Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebGoods

Namespace Controllers
    Public Class customerbillsController
        Inherits System.Web.Mvc.Controller

        Private db As New DBSEntities

        ' GET: customerbills
        Function Index() As ActionResult
            Dim customerbills = db.customerbills.Include(Function(c) c.customer).Include(Function(c) c.product)
            Return View(customerbills.ToList())
        End Function

        ' GET: customerbills/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim customerbill As customerbill = db.customerbills.Find(id)
            If IsNothing(customerbill) Then
                Return HttpNotFound()
            End If
            Return View(customerbill)
        End Function

        ' GET: customerbills/Create
        Function Create() As ActionResult
            ViewBag.customerid = New SelectList(db.customers, "id", "fullname")
            ViewBag.productid = New SelectList(db.products, "id", "name")
            Return View()
        End Function

        ' POST: customerbills/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,productid,customerid,quantity,status,datecreate")> ByVal customerbill As customerbill) As ActionResult
            If ModelState.IsValid Then
                db.customerbills.Add(customerbill)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.customerid = New SelectList(db.customers, "id", "fullname", customerbill.customerid)
            ViewBag.productid = New SelectList(db.products, "id", "name", customerbill.productid)
            Return View(customerbill)
        End Function

        ' GET: customerbills/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim customerbill As customerbill = db.customerbills.Find(id)
            If IsNothing(customerbill) Then
                Return HttpNotFound()
            End If
            ViewBag.customerid = New SelectList(db.customers, "id", "fullname", customerbill.customerid)
            ViewBag.productid = New SelectList(db.products, "id", "name", customerbill.productid)
            Return View(customerbill)
        End Function

        ' POST: customerbills/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,productid,customerid,quantity,status,datecreate")> ByVal customerbill As customerbill) As ActionResult
            If ModelState.IsValid Then
                db.Entry(customerbill).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.customerid = New SelectList(db.customers, "id", "fullname", customerbill.customerid)
            ViewBag.productid = New SelectList(db.products, "id", "name", customerbill.productid)
            Return View(customerbill)
        End Function

        ' GET: customerbills/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim customerbill As customerbill = db.customerbills.Find(id)
            If IsNothing(customerbill) Then
                Return HttpNotFound()
            End If
            Return View(customerbill)
        End Function

        ' POST: customerbills/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim customerbill As customerbill = db.customerbills.Find(id)
            db.customerbills.Remove(customerbill)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
