@ModelType WebGoods.customer
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>customer</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.fullname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fullname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.phonenumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.phonenumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.password)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
