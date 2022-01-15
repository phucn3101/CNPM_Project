@ModelType WebGoods.product
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
