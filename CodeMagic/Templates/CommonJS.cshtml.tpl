
<script>
	$(function() {
		$('#table1').DataTable()
	})
</script>

<script>
	function deleteConfirm(url) {
        if (confirm("Delete Row?")) {
            location.href = url;
        }
    }
</script>


<script>
	function create() {
		$.ajax({
			type: 'POST',
			url: '{url}',
			data: $("#form1").serialize(),
			dataType: 'json',
			success: function (data) {
				if (data.code == 200) {
					alert('Success');
					location.reload();
				} else {
					alert(data.msg);
				}
			}
		});
	}
</script>
