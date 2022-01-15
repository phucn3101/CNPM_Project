@ModelType IEnumerable(Of WebGoods.customerbill)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.datecreate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.customer.fullname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.product.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.quantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.datecreate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.customer.fullname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.product.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
