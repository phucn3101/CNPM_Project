@ModelType WebGoods.customerbill
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
