
# Server side Webapp : Razor pages

> Great developer experience

- No JS/angular/react skill set needed
- One IDE for FE (html+css) and BE (c#)
- Debugging between FE and BE simplified
- Less models, less validations
- One security model
- better security awareness: ~ what you show is what you leak
- [css isolation](https://www.mikesdotnetting.com/article/355/css-isolation-in-razor-pages) (**DEMO** `Search.cshtml.css`)
- Model binded to html (IDE navigation, compilation check) (**DEMO** `Add.cshtml`)
- hot-reload included for BE and FE (**DEMO**)

**Demo website**

> Poor user experience

- Slow interaction feedback
- Page loads destroy transient state
    (scroll positions, unsaved form values, focus)
- Layered interactions are hard
    (modals, drop-downs, drawers)
- Animation is complicated
- Complex forms

# Fix poor user experience with Unpoly

- 25 new HTML attributes to write modern UI, but keep logic on the server
- Works with existing code
	- little to no changes required on the server side
- Works with any backend language or framework
	- although we have some nice Rails bindings
- In development for 2+8 years and in production with multiple apps

How Unpoly works ? => https://unpoly.com/tutorial