$(document).ready(function(){
    $('#showFooter').click(function(evt) {
        $('#footer').animate({
            'margin-top' : 0,
            'height' : 0
        }
        $('#main').animate({
            'padding-bottom' : 0
        });
    });
});