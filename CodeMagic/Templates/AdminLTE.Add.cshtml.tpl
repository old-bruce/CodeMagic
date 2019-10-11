@{
    ViewBag.Title = "{Table} Add";
}

<!-- Content Header (Page header) -->
<section class="content-header">
    <h1>
        <!--<i class="fa fa-list"></i>-->{Table}
        <small></small>
    </h1>
    <ol class="breadcrumb">
        <li><a><i class="fa fa-dashboard"></i> JOMS</a></li>
        <li><a href="~/{Table}">{Table}</a></li>
        <li class="active">Add</li>

    </ol>
</section>

<!-- Main content -->
<section class="content container-fluid">
    <div class="box">
        <div class="box-body">
            <button class="btn btn-sm btn-info" onclick="location.reload()"><i class="fa fa-refresh"></i> Refresh</button>
            <a class="btn btn-sm btn-default" href="~/{Table}"><i class="fa fa-reply"></i> Return</a>
        </div>
    </div>
    <div class="box">
        <div class="box-header">
            <h3 class="box-title">{Table} Add</h3>
        </div>
        <!-- /.box-header -->
        <div class="box-body">
            <form role="form" id="form1">
{AddColumns}
            </form>
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
            <div class="row">
                <div class="col-md-6">
                    <span class="label label-default">* Is Required</span>
                </div>
                <div class="col-md-6 text-right">
                    <button class="btn btn-sm btn-success" onclick="Save()"><i class="fa fa-save"></i> Save</button>
                    <a class="btn btn-sm btn-default" href="~/{Table}"><i class="fa fa-reply"></i> Return</a>
                </div>
            </div>
        </div>
        <!-- /.box-footer -->
    </div>
    <!-- /.box -->
</section>
<!-- /.content -->

<script>
    function Save()
    {
        $.ajax({
            type: 'POST',
            url: '/{Table}/AddSave',
            data: $("#form1").serialize(),
            success: function (data) {
                if (data.code == 200) {
                    rc.msg.alert("Save Success", "Add", function ()
                    {
                        location.reload();
                    });
                } else {
                    rc.msg.alert(data.msg);
                }
            },
            dataType: 'json'
        });
    }
</script>