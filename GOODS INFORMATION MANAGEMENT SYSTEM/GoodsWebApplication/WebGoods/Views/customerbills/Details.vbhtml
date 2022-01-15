@ModelType WebGoods.customerbill
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>customerbill</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.datecreate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.datecreate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.customer.fullname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.customer.fullname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.product.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.product.name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
