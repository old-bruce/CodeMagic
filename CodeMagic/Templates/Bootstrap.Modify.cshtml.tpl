@{
    ViewBag.Title = "Modify {Table}";

    {NameSpace}.Model.{Model} item = ViewBag.{Table}Model;
}

<ol class="breadcrumb mtFixed">
    <li><a href="~/">Home</a></li>
    <li><a href="@Url.Action("Index","{Table}")">{Table}</a></li>
    <li class="active">Modify {Table}</li>
</ol>

<div class="container-fluid">
    <div class="panel panel-default">
        <div class="panel-heading">
            <span class="glyphicon glyphicon-modal-window"></span>
            <span>Modify {Table}</span>
        </div>

        <div class="panel-command">
            <div class="pull-left">
                <div class="btn-group" role="group" aria-label="...">
                    <a href="@Url.Action("Modify", "{Table}", new { {ModelParams} })" class="btn btn-default">
                        <span class="glyphicon glyphicon-refresh"></span>
                        <span>Refresh</span>
                    </a>
                    <a href="@Url.Action("Index", "{Table}")" class="btn btn-default">
                        <span class="glyphicon glyphicon-share"></span>
                        <span>Back</span>
                    </a>
                </div>
            </div>
            <div class="pull-right">

            </div>
            <div class="clearfix"></div>
        </div>
        <div class="panel-body">
            <form id="form1">
{FormHiddens}
{FormItems}
                <button type="button" class="btn btn-primary" onclick="SubmitFormAsync('@Url.Action("Update", "{Table}")', 'form1')">Submit</button>
            </form>
        </div>
    </div>
</div>