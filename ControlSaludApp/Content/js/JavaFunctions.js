    $(document).ready(function () {
        $("#Red").change(function () {
            $("#Microred").empty();
            $.ajax({
                type: 'POST',
                url: '@Url.Action("GetMicrored")',
                dataType: 'json',
                data: { id: $("#Red").val() },

                success: function (microred) {
                    $.each(microred, function (i, microred) {
                        $("#Microred").append('<option value="' + microred.Value + '">' + microred.Text + '</option>');
                    });
                },
                error: function (ex) {
                    alert('Error al obtener Microred ... ' + ex);
                }
            });
            return false;
        })
})

    $(document).ready(function () {
        $("#Microred").change(function () {
            $("#Establecimiento").empty();
            $.ajax({
                type: 'POST',
                url: '@Url.Action("GetEstablecimiento")',
                dataType: 'json',
                data: { id: $("#Microred").val() },

                success: function (microred) {
                    $.each(microred, function (i, microred) {
                        $("#Establecimiento").append('<option value="' + microred.Value + '">' + microred.Text + '</option>');
                    });
                },
                error: function (ex) {
                    alert('Error al obtener Establecimiento ... ' + ex);
                }
            });
            return false;
        })
    })