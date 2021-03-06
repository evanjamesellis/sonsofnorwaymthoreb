﻿// Photo Gallery
$(document).ready(function(){
    $('li img').on('click',function(){
        var src = $(this).attr('src');
        var img = '<img src="' + src + '" class="img-responsive modal-image-assist"/>';
     
        var index = $(this).parent('li').index();
        var html = '';
        html += '<div style="height:25px; clear:both; display:block; margin-bottom:20px;">';
        html += '<a class="a-assist previous-next previous" href="' + (index) + '">&laquo; Previous</a>';
        html += '<a class="a-assist previous-next next" href="'+ (index+2) + '">Next &raquo;</a>';
        html += '</div>';
        html += img;

        $('#myModal').modal();
        $('#myModal').on('shown.bs.modal', function(){
            $('#myModal .modal-body').html(html);
            $('a.previous-next').trigger('click');
        })
    });
})

$(document).on('click', 'a.previous-next', function(){
    var index = $(this).attr('href');
    var src = $('ul.row li:nth-child('+ index +') img').attr('src');
    $('.modal-body img').attr('src', src);

    var newPrevIndex = parseInt(index) - 1;
    var newNextIndex = parseInt(newPrevIndex) + 2;

    if ($(this).hasClass('previous')) {
        $(this).attr('href', newPrevIndex);
        $('a.next').attr('href', newNextIndex);
    } else {
        $(this).attr('href', newNextIndex);
        $('a.previous').attr('href', newPrevIndex);
    }

    var total = $('ul.row li').length + 1;
    // Hide next button
    if (total === newNextIndex) {
        $('a.next').hide();
    } else {
        $('a.next').show()
    }
    // Hide previous button
    if (newPrevIndex === 0) {
        $('a.previous').hide();
    } else {
        $('a.previous').show()
    }
    
    return false;
});