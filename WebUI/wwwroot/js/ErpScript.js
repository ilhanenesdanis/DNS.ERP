

//sabit sweet alert işlemleri

function SuccessModal() {
    Swal.fire({
        icon: 'success',
        title: 'İşlem Başarılı',
        showConfirmButton: false,
        timer: 1500
    })
}
function ErrorModal() {
    Swal.fire({
        icon: 'error',
        title: 'İşlem Sırasında Hata Gerçekleşti, Lütfen Tekrar Deneyiniz',
        showConfirmButton: false,
        timer: 1500
    })
}

//*******Start Brands Functions**********
function AddBrand() {
    $.ajax({
        url: '/Brand/BrandAdd',
        data: $('#BranName').serialize(),
        success: function (data) {
            $('#addModal').modal('hide');
            if (data.status == true) {
                SuccessModal();
                var Dates;
                if (data.data.updateDate == null) {
                    Dates = data.data.createDate;
                }
                else {
                    Dates = data.data.updateDate;
                }
                var html =
                    `<tr>
                           <td>${data.data.name}</td>
                           <td>${Dates}</td>
                           <td><button class="btn btn-outline-warning">Güncelle</button></td>
                           <td><button class="btn btn-outline-danger">Pasif Yap</button></td>
                        </tr>`
                $('#TableBody').prepend(html);
            }
            else {

                ErrorModal()
            }
        }
    })
}
function GetBrandUpdateData(id) {
    $.ajax({
        url: '/Brand/GetByBrandId',
        data: { id: id },
        method: 'GET',
        success: function (value) {
            if (value.status == true) {
                $('#BranNameUpdate').val(value.data.name);
                $('#UpdateId').val(value.data.id);
                $('#UpdateBrandModal').modal('show');
            }
            else {
                ErrorModal()
            }
        }
    })
}
function UpdateBrand() {
    $.ajax({
        url: '/Brand/Update',
        data: $('#BrandUpdate').serialize(),
        method: 'POST',
        success: function (response) {
            if (response.status == true) {
                $('#UpdateBrandModal').modal('hide');
                SuccessModal();

            }
            else {
                $('#UpdateBrandModal').modal('hide');
                ErrorModal();

            }
        }
    })
}
function BrandStatusChange(id) {
    Swal.fire({
        title: 'Emin Misiniz ?',
        showDenyButton: true,

        confirmButtonText: 'Kaydet',
        denyButtonText: `İptal`,
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: '/Brand/ChangeStatus',
                data: { id: id },
                success: function (response) {
                    console.log(response);
                    if (response.status == true) {
                        if (response.data.status == true) {
                            $('#BrandStatu_' + id).removeClass('btn-outline-danger');
                            $('#BrandStatu_' + id).addClass('btn-outline-success');
                            $('#BrandStatu_' + id).text('Pasif Yap')
                            Swal.fire('İşlem Başarılı', '', 'success')
                        }
                        else {
                            $('#BrandStatu_' + id).removeClass('btn-outline-success');
                            $('#BrandStatu_' + id).addClass('btn-outline-danger');
                            $('#BrandStatu_' + id).text('Aktif Yap')
                            Swal.fire('İşlem Başarılı', '', 'success')
                        }
                    }
                    else {
                        Swal.fire('İşlem Başarılı', '', 'error')
                    }
                }
            })
            
        }
    })
}
//*******End Brands Functions**********