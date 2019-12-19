@{
    ViewBag.Title = "{Table}";
	List<{NameSpace}.Model.{Model}> models = (List<{NameSpace}.Model.{Model}>)ViewBag.Models;
}

<!-- Content Header (Page header) -->
<section class="content-header">
    <h1>
        <!--<span class="fa fa-list"></span> -->{Table}
        <small></small>
    </h1>
    <ol class="breadcrumb">
        <li><a><span class="fa fa-dashboard"></span> {Table}</a></li>
        <li class="active">{Table}</li>
    </ol>
</section>

<!-- Main content -->
<section class="content container-fluid">
    <div class="box">
        <div class="box-body">
            <button class="btn btn-sm btn-info" onclick="location.reload()"><span class="fa fa-refresh"></span> Refresh</button>
            <a class="btn btn-sm btn-success" href="~/{Table}/Add"><span class="fa fa-plus"></span> Add</a>
            <a class="btn btn-sm btn-warning" href="~/{Table}/Import"><span class="fa fa-reply"></span> Import</a>
            <a class="btn btn-sm btn-warning" href="~/{Table}/Export" target="_blank"><span class="fa fa-share"></span> Export</a>
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
