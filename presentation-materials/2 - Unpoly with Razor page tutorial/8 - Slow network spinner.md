Add a custom component

`_Layout.cshtml`
```html
<!-- Main Content -->  
<main>  
    <loading-indicator class="loader-container">  
        <div>Loading...</div>  
    </loading-indicator>
```

```js
/* slow network indicator */  

// Disable the default progress bar  
up.network.config.progressBar = false;

up.compiler('loading-indicator', function(indicator) {  
    function show() { up.element.show(indicator) }  
    function hide() { up.element.hide(indicator) }  
  
    hide()  
  
    return [  
        up.on('up:network:late', show),  
        up.on('up:network:recover', hide)  
    ]});
```

```css
.loader-container {  
  position: fixed;
  display: block;  
  width: 100%;
  height: 100%;
  top: 0;  
  left: 0;  
  right: 0;  
  bottom: 0;  
  background-color: rgba(0,0,0,0.5);  z-index: 2;  
  cursor: pointer;
}  
.loader-container > div {  
  position: absolute;  
  top: 50%;  
  left: 50%;  
  font-size: 50px;  
  color: white;  
  transform: translate(-50%,-50%);  
  -ms-transform: translate(-50%,-50%);  
}
```