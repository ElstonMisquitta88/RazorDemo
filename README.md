# Learning Asp.Net 6 with Razor
<p>Divided the project into Section for own understanding.</p>

<ul>
  <li> Models  - Class structure which will be used </li>
  <li>Service - Actual Functionality </li>
  <li>Program.cs - Regsiter the Service to be used. Asp.net core dependency injection</li>
  <li>On the Actual Page - PageName.cshtml - Page Constructor - Call the Service </li>
</ul>



# Dependency injection in ASP.NET Core
<p>https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0</p> 

<li>Created an Interface <b>(IMyDependency.cs)</b> with a method to be implemented - WriteMessage </li>
<li>Two Classed which have implemented the Interface <b>(a) MyDependency.cs  & (b) MyDependencyFailOver.cs</b> </li>
<li>In <b>Program.cs</b> we define the implementation to be used</li>

<ol type="a">
  <li><i>builder.Services.AddScoped<IMyDependency, MyDependency>();</i>
  <li><i>builder.Services.AddScoped<IMyDependency, MyDependencyFailOver>();</i></li>
</ol>  
<li>On the Actual Page - PageName.cshtml - Page Constructor - Call The Interface</li> 
</br>  

>  With this you can change the implemention of the method without doing changes on all the pages
