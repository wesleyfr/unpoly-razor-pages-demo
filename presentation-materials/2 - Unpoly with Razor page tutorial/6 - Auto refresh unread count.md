
Add `up-poll` and  `up-interval="10000"`

```html
<p class="candies-events" up-hungry up-poll up-interval="10000">  
    <a asp-page="/Candies/Events">📨 @CandiesRepository.GetUnreadEventsCount() event(s)</a>  
</p>
```

⚠️ Use a specific endpoint for polling to minimize server and network load. See [Controlling the source URL](https://unpoly.com/up-poll#controlling-the-source-url) 