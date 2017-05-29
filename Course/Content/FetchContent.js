var ExternalURL = 'www.dummysite.com';
// This address must not contain any leading 'http://'
var ContentLocationInDOM = '#someNode > .childNode';
// If you're trying to get sub-content from the page, specify the 'CSS style' jQuery syntax here, otherwise set this to 'null'

$(document).ready(loadContent);
function loadContent()
{
    var QueryURL = 'http://anyorigin.com/get?url=' + ExternalURL + '&callback=?';
    $.getJSON(QueryURL, function(data){
        if (data && data != null && typeof data == 'object' && data.contents && data.contents != null && typeof data.contents == 'string')
        {
            data = data.contents.replace('/<script[^>]*>[sS]*?</script>/gi, ');
           if (data.length > 0)
            {
              if (ContentLocationInDOM && ContentLocationInDOM != null && ContentLocationInDOM != 'null')
               {
                 $('#queryResultContainer').html($(ContentLocationInDOM, data));
              }
              else
              {
                 $('#queryResultContainer').html(data);
              }
           }
        }
    });
}
//   <div id='queryResultContainer'/>