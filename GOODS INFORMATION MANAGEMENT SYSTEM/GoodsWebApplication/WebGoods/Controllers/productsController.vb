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
    Public Class productsController
        Inherits System.Web.Mvc.Controller

        Private db As New DBSEntities

        ' GET: products
        Function Index() As ActionResult
            Dim products = db.products.Include(Function(p) p.category)
            Return View(products.ToList())
        End Function

        ' GET: products/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' GET: products/Create
        Function Create() As ActionResult
            ViewBag.categoryid = New SelectList(db.categories, "id", "name")
            Return View()
        End Function

        ' POST: products/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,name,description,price,categoryid,quantity,img")> ByVal product As product) As ActionResult
            If ModelState.IsValid Then
                db.products.Add(product)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.categoryid = New SelectList(db.categories, "id", "name", product.categoryid)
            Return View(product)
        End Function

        ' GET: products/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            ViewBag.categoryid = New SelectList(db.categories, "id", "name", product.categoryid)
            Return View(product)
        End Function

        ' POST: products/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,name,description,price,categoryid,quantity,img")> ByVal product As product) As ActionResult
            If ModelState.IsValid Then
                db.Entry(product).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.categoryid = New SelectList(db.categories, "id", "name", product.categoryid)
            Return View(product)
        End Function

        ' GET: products/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As product = db.products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: products/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim product As product = db.products.Find(id)
            db.products.Remove(product)
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
