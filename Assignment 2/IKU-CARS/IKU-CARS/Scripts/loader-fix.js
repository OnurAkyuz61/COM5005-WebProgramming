// Fix loader screen to hide after page loads
$(document).ready(function() {
    // Hide loader after page is fully loaded
    $(window).on('load', function() {
        $('.loader_bg').fadeOut(500);
    });
    
    // Fallback: Hide loader after 3 seconds if window load doesn't fire
    setTimeout(function() {
        $('.loader_bg').fadeOut(500);
    }, 3000);
});
