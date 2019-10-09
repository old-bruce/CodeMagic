@{
    ViewBag.Title = "{Table}";
	List<{NameSpace}.Model.{Model}> models = (List<{NameSpace}.Model.{Model}>)ViewBag.Models;
}

<!-- Content Header (Page header) -->
<section class="content-header">
    <h1>
        <!--<i class="fa fa-list"></i> -->{Table}
        <small></small>
    </h1>
    <ol class="breadcrumb">
        <li><a><i class="fa fa-dashboard"></i> {Table}</a></li>
        <li class="active">{Table}</li>
    </ol>
</section>

<!-- Main content -->
<section class="content container-fluid">
    <div class="box">
        <div class="box-body">
            <button class="btn btn-sm btn-info" onclick="location.reload()"><i class="fa fa-refresh"></i> Refresh</button>
            <a class="btn btn-sm btn-success" href="~/{Table}/Add"><i class="fa fa-plus"></i> Add</a>
            <a class="btn btn-sm btn-warning" href="~/{Table}/Import"><i class="fa fa-reply"></i> Import</a>
            <a class="btn btn-sm btn-warning" href="~/{Table}/Export" target="_blank"><i class="fa fa-share"></i> Export</a>
        </div>
    </div>
    <div class="box">
        <div class="box-header">
            <h3 class="box-title">{Table}</h3>
        </div>
        <!-- /.box-header -->
        <div class="box-body">
            <table id="example1" class="table table-bordered table-striped">
                <thead>
                    {trhead}
                </thead>
                <tbody>
                    @for(int i=0; i<@models.Count; i++) {
					{trbody}
                    <tr>
                        <td>@models[i].</td>
                        <td>Jabil WuXi Office @i</td>
                        <td>0</td>
                        <th>0</th>
                        <td>1878</td>
                        <th>900</th>
                        <td><span class="label label-success">enable</span></td>
                        <th><span class="label label-success"><i class="fa fa-check"></i></span></th>
                        <th>
                            <button class="btn btn-sm btn-warning"><i class="fa fa-edit"></i></button>
                            <button class="btn btn-sm btn-danger"><i class="fa fa-remove"></i></button>
                        </th>
                    </tr>
                    }
                </tbody>
                <tfoot>
                    {trlist}
                </tfoot>
            </table>
        </div>
    </div>
    <!-- /.box -->
</section>
<!-- /.content -->


<!-- DataTables -->
<script src="~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
<script src="~/AdminLTE/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
<script>
  $(function () {
    $('#table1').DataTable()
  })
</script>


