@ModelType WebGoods.product
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>product</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.price)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.price)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.img)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.img)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.category.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.category.name)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
