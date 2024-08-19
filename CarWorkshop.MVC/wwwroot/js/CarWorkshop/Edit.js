$(document).ready(function () {

    const RenderCarworkshopServices = (services, container) => {
        container.empty();

        for (const service of services) {
            container.append(
                `<div class="card border-secondary mb-3" style="max-width: 18rem;">
          <div class="card-header">${service.cost}</div>
          <div class="card-body">
            <h5 class="card-title">${service.description}</h5> 
          </div>
        </div>`)
        }
    }

    const LoadCarWQorkshopServices = () => {
        const container = $("#services")
        const carWorkshopEncodedName = container.data("encodedName");

        $.ajax({
            url: '/CarWorkshop/${carWorkshopEncodedName}/CarWorkshopService',
            type: 'get',
            success: function (data) {
                if (!data.Length) {
                    container.html("There are no services for this car workshop")
                } else {
                    RenderCarworkshopServices(data,container)
                }
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    }
    LoadCarWQorkshopServices();

    $("#createCarWorkshopServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Created carworkshop service")
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    });
});