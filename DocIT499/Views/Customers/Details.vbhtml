﻿@ModelType DocIT499.Customer
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CustomerID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
