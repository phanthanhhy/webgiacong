;(function($) {
	$(function() {
		$('.nav').append($('<div class="nav-mobile"></div>'));
		$('.nav-item').has('ul').prepend('<span class="nav-click"><i></i></span>');
		$('.nav-submenu-item').has('ul').prepend('<span class="nav-click"><i></i></span>');
		$('.nav-mobile').click(function(){
			$('.nav-list').toggle();
		});
		$('.nav-list').on('click', '.nav-click', function(){
			$(this).siblings('.nav-submenu').toggle();
			$(this).siblings('.nav1-submenu').toggle();
			$(this).children('.nav-arrow').toggleClass('nav-rotate');
		});	
	});
})(jQuery);