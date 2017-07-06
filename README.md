Creating
--------

The overall approach for creating the Web API projects with an abolute
minimal footpring is to start with an Empty project type in Visual
Studio and then add the NuGet packages by hand:

1. Empty web project
2. Install-Package Microsoft.Owin.Host.SystemWeb
3. Install-Package Microsoft.AspNet.WebApi.Owin
3. Install-Package Microsoft.AspNet.WebApi.Cors
4. Add class Startup
5. Add folder Controllers
6. Add a new controller

We also add a Swagger resource for documenting or API:

1. Install-Package Swashbuckle
2. Delete created file SwaggerConfig
3. Add Swagger configuration in existing class Startup

We then enable standard C# documentation in our project and add C#
documentation to the controller class.  In Visual Studio, select the
properties for the project, goto the Build tab and select the "XML
Documentaiton File" option.  Use the name and path of the resulting
XML documentation file and update the Startup class.

If your start the project, you can find the Swagger documentation at the following URL:

* http://localhost:XYZ/swagger/ui/index
