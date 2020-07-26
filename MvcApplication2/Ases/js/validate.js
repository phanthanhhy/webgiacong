$(function() {
		$('#formcomment').validate({
			rules : {
				Body : {
					required : true
					//Body : true
				},
				Name : {
					required : true
					//Name : true
				},
				email : {
					required : true,
					email : true
				}
				
			},
			messages : {
				Body : {
					required : "Nội dung không được để trống"
					//Name : "Mật khẩu phải có ít nhất 8 ký tự"
				},
				email : {
					required : "Email không được để trống",
					email : "Email không đúng định dạng",
				},
				Name : {
					required : "Họ tên không được để trống"
					//Name : "Mật khẩu phải có ít nhất 8 ký tự"
				}
			},
			submitHandler : function (form) {
				
				
				//$('#formcomment').on('submit', function(event){
						event.preventDefault();
						//var formData = $(this).serialize();
						var formData = $("form#formcomment").serialize();
						$.ajax({
							type : 'POST',
							url : 'common/savecomment.php',
							data : formData,
							success:function(data){
								$("#formcomment")[0].reset();
								window.setTimeout(function(){window.location.reload()},3000)
								 $("#formcomment").html('<div class=\"text-center\"><img src=\"\images/loading-circle.gif\" /></div>');
								//$("#formcomment")[0].reset();
								 //window.setTimeout(function(){window.location.reload()},3000);
								
								  
								
				
							}
						});		
				//	});
								
				
			}

		});

	})