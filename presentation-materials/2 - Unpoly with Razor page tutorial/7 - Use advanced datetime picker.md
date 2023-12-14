```html
...
<link rel="stylesheet" href="~/lib/air-datepicker/air-datepicker.css" />
...
<script src="~/lib/air-datepicker/air-datepicker.js"></script>
...
```

```js
up.compiler('input[type=date]', function(element) {  
    element.type = 'text';  
    var localeEn = {  
        days: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'],  
        daysShort: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],  
        daysMin: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],  
        months: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],  
        monthsShort: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],  
        today: 'Today',  
        clear: 'Clear',  
        dateFormat: 'MM/dd/yyyy',  
        timeFormat: 'hh:mm aa',  
        firstDay: 0  
    };  
    new AirDatepicker(element,  {  
        locale: localeEn  
    });
});
```