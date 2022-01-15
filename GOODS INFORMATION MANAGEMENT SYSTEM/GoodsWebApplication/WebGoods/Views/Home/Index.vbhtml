@ModelType IEnumerable(Of WebGoods.product)
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
           
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.price)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.category.name)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
    <td>
       <img src="@Html.DisplayFor(Function(modelItem) item.img)" class="thumbnail"/> 
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.name)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.description)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.price)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.category.name)
    </td>
    <td>
        @Html.ActionLink("Details", "Details", New With {.id = item.id})
    </td>
</tr>
    Next

</table>
