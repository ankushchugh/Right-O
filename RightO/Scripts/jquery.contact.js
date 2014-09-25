jQuery(document).ready(function(){
	$('#cform').submit(function(){
	    var isValid = true;

	    if ($('#name').val() == "" || $('#email').val() == "" || $('#comments').val() == "") {
	        isValid = false;
	    }
	    if (isValid) {
	        //var action = $(this).attr('action');

	        //$("#message").slideUp(750, function () {
	        //    $('#message').hide();

	            $('#submit')
                    .after('<img src="images/nivo-preloader.gif" class="contact-loader" />')
                    .attr('disabled', 'disabled');

	        //    $.post(action, {
	        //        name: $('#name').val(),
	        //        email: $('#email').val(),
	        //        comments: $('#comments').val(),
	        //        verify: $('#verify').val()
	        //    },
            //        function (data) {
            //            document.getElementById('message').innerHTML = data;
            //            $('#message').slideDown('slow');
            //            $('#cform img.contact-loader').fadeOut('slow', function () { $(this).remove() });
            //            $('#submit').removeAttr('disabled');
            //            if (data.match('success') != null) $('#cform').slideUp('slow');
            //        }
            //    );

	        //});

	        //return false;
	            var conactModel = {"Name":$('#name').val(), "Email":$('#email').val(),"Comments":$('#comments').val()};

	        $.ajax({
	            url: "/Home/SendContactEnquiry",
	            type: "POST",
	            data: conactModel,
	            success: function (data, textStatus, jqXHR) {
	                //data - response from server
	                if (data.success) {
	                    $('#cform img.contact-loader').fadeOut('slow', function () { $(this).remove() });
	                    $('#submit').removeAttr('disabled');
	                    $("#dialogText").text("We will get back to you for this enquiry.");
	                    $('#message').dialog({
	                        draggable: true,
	                        resizable: true,
	                        position: ['center'],
	                        width: 400,
	                        title: 'Sent successfully!!'
	                    });
	                }
	            },
	            error: function (jqXHR, textStatus, errorThrown) {
	                $("#dialogText").text("Oops!! something went wrong.");
	                $('#message').dialog({
	                    draggable: true,
	                    resizable: true,
	                    position: ['center'],
	                    width: 400,
	                    title: 'Error'
	                });
	            }
	        });
	        return false;
	    }
	    else {
	        $('#message').dialog({
	            draggable: true,
	            resizable: true,
	            position: ['center'],
	            width: 400,
	            title: 'Error'
	        });
	        return false;
	    }

	});

});