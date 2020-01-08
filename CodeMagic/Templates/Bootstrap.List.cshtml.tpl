@{
    ViewBag.Title = "{Table}";
	List<{NameSpace}.Model.{Model}> modelList = (List<{NameSpace}.Model.{Model}>)ViewBag.{Table}List;
}

<ol class="breadcrumb mtFixed">
    <li><a href="~/">Home</a></li>
    <li><a href="@Url.Action("Index","{Table}")">{Table}</a></li>
    <li class="active">{Table} List</li>
</ol>

<div class="container-fluid">
    <div class="panel panel-default">
        <div class="panel-heading">
            <div class="pull-left">
                <span class="glyphicon glyphicon-list"></span>
                <span>{Table} List</span>
            </div>
            
            <div class="pull-right">
                <a href="@Url.Action("Index", "{Table}")" class="btn btn-sm btn-default">
                    <span class="glyphicon glyphicon-refresh"></span>
                    <span>Refresh</span>
                </a>
                <a href="@Url.Action("Add", "{Table}")" class="btn btn-sm btn-success">
                    <span class="glyphicon glyphicon-plus"></span>
                    <span>Add</span>
                </a>
            </div>
            <div class="clearfix"></div>
        </div>

        <div class="panel-body" style="overflow-y: scroll;">
            <table id="table1" class="table table-striped">
                <thead>
{thlist}
                </thead>
                <tbody>
                    @foreach (var item in modelList)
                    {
                    <tr>
{tdlist}
                        <td>
                            <a href="@Url.Action("Modify","{Table}", new { {ItemParams} })" class="text-warning" title="Modify">
                                <span class="glyphicon glyphicon-pencil"></span>
                            </a>&nbsp;
                            <a href="javascript:void(0)" onclick="DeleteConfirmYes('@Url.Action("Delete","{Table}", new { {ItemParams} })')" class="text-danger" title="Delete">
                                <span class="glyphicon glyphicon-remove"></span>
                            </a>
                        </td>
                    </tr>
                    }
                </tbody>
            </table>
        </div>
    </div>
</div>

@section scripts {

<!-- DataTables -->
<script src="~/Scripts/jquery.dataTables.min.js"></script>
<script src="~/Scripts/dataTables.bootstrap.min.js"></script>
<script>
    $(document).ready(function () {
        $('#table1').DataTable();
    });
</script>

}
