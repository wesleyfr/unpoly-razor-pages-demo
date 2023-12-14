using Microsoft.AspNetCore.Mvc;

namespace webapp.BindingHelpers;

public class BindFromQueryString : BindPropertyAttribute
{
    public BindFromQueryString()
    {
        SupportsGet = true;
    }
}

public class BindFromForm : BindPropertyAttribute
{
}

public class BindFromRoute : FromRouteAttribute
{
}