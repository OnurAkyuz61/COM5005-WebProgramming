// Fix decimal separator for Turkish locale
$(document).ready(function() {
    // Find all price input fields
    $('input[type="text"], input[type="number"]').filter(function() {
        return this.name.toLowerCase().includes('price') || 
               this.id.toLowerCase().includes('price') ||
               $(this).attr('placeholder') && $(this).attr('placeholder').toLowerCase().includes('price');
    }).on('input', function() {
        // Replace comma with dot for decimal separator
        var value = $(this).val();
        if (value.includes(',')) {
            $(this).val(value.replace(',', '.'));
        }
    });
    
    // Also handle on form submit to ensure proper format
    $('form').on('submit', function() {
        $(this).find('input').each(function() {
            if (this.name.toLowerCase().includes('price')) {
                var value = $(this).val();
                if (value.includes(',')) {
                    $(this).val(value.replace(',', '.'));
                }
            }
        });
    });
});
