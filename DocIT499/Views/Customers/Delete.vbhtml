@ModelType DocIT499.Customer
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Customer</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Salutation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Salutation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MiddleName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MiddleName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Suffix)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Suffix)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerNotesID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerNotesID)
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
