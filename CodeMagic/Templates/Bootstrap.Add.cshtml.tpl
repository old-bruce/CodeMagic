@{
    ViewBag.Title = "{Table} Add";
}

<ol class="breadcrumb mtFixed">
    <li><a href="~/">Home</a></li>
    <li><a href="@Url.Action("Index","{Table}")">{Table}</a></li>
    <li class="active">{Table} Add</li>
</ol>

<div class="container-fluid">
    <div class="panel panel-default">
        <div class="panel-heading">
            <span class="glyphicon glyphicon-modal-window"></span>
            <span>Add {Table}</span>
        </div>
        <div class="panel-body">
            <form id="form1">
{FormItems}
				<a href="@Url.Action("Add", "{Table}")" class="btn btn-default">
                    <span class="glyphicon glyphicon-refresh"></span>
                    <span>Refresh</span>
                </a>
                <button type="button" class="btn btn-primary" onclick="SubmitFormAsync('@Url.Action("Insert", "{Table}")', 'form1')">Submit</button>
                <a href="@Url.Action("Index", "{Table}")" class="btn btn-default">
                    <span class="glyphicon glyphicon-share"></span>
                    <span>Back</span>
                </a>
            </form>
        </div>
    </div>
</div>
