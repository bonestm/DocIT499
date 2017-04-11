@ModelType IEnumerable(Of DocIT499.Customer)
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
            @Html.DisplayNameFor(Function(model) model.Salutation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MiddleName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Suffix)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CustomerNotesID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Salutation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MiddleName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Suffix)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerNotesID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CustomerID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CustomerID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CustomerID })
        </td>
    </tr>
Next

</table>
