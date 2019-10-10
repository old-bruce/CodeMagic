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
				@foreach ({NameSpace}.Model.{Model} m in models)
                {
					{trbody}
                }	
                </tbody>
                <tfoot>
                    {trhead}
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
    $(document).ready(function () {
        $('#example1').DataTable();
    });
</script>
<script>
    function Delete(id)
    {
        rc.msg.confirm("Are you sure you want to delete it?", "confirm", function (result) {
            if (result) {
                $.ajax({
                    type: 'POST',
                    url: '/{Table}/Delete/' + id,
                    data: '',
                    success: function (data) {
                        if (data.code == 200) {
                            rc.msg.alert("Delete Success", "Delete", function () {
                                location.reload();
                            });
                        } else {
                            rc.msg.alert(data.msg);
                        }
                    },
                    dataType: 'json'
                });
            }
        });
    }
</script>
