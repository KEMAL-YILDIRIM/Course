$(document).ready(function () {

    var Cevaplar = {};


    var Cevap1_clickedId;
    $(".cevap1").click(function () {
        $(sonTiklanan1).css("background", "");
        Cevap1_clickedId = $(this).attr("id");
        $(this).css("background", "yellow");
        lastfunction1(this);
    });
    var sonTiklanan1;
    function lastfunction1(element) {
        sonTiklanan1 = element;
    };

    var Cevap2_clickedId;
    $(".cevap2").click(function () {
        $(sonTiklanan2).css("background", "");
        Cevap2_clickedId = $(this).attr("id");
        $(this).css("background", "yellow");
        lastfunction2(this);
    });
    var sonTiklanan2;
    function lastfunction2(element) {
        sonTiklanan2 = element;
    };


    var Cevap3_clickedId;
    $(".cevap3").click(function () {
        $(sonTiklanan3).css("background", "");
        Cevap3_clickedId = $(this).attr("id");
        $(this).css("background", "yellow");
        lastfunction3(this);
    });
    var sonTiklanan3;
    function lastfunction3(element) {
        sonTiklanan3 = element;
    };



    var Cevap4_clickedId;
    $(".cevap4").click(function () {
        $(sonTiklanan4).css("background", "");
        Cevap4_clickedId = $(this).attr("id");
        $(this).css("background", "yellow");
        lastfunction4(this);
    });
    var sonTiklanan4;
    function lastfunction4(element) {
        sonTiklanan4 = element;
    };

    $("#tamamla").click(function () {
        $.ajax({
            type: "POST",
            url: "/User/AjaxMethod",
            data: { id: $("#SinavID").val() },
            dataType: "json",
            success: function (data) {
                for (var i = 1; i <= 4; i++) {
                    var bir = 'Cevap' + i + '_clickedId';
                    var iki = 'data.Cevap' + i;
                    if (bir === iki) {
                        $("#"+bir).css("background", "green");
                    } else {
                        $(bir).css("background", "red");
                    }
                }
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });




});