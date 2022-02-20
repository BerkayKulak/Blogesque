
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154842845-0b490a1b-65b2-4252-8b29-80187b0f935e.gif">


Here's why:
This tutorial teaches ASP.NET Core MVC with controllers and views. Razor Pages is a new alternative in ASP.NET Core, a page-based programming model that makes building web UI easier and more productive. We recommend you try the Razor Pages tutorial before the MVC version. 

- Is easier to follow.
- Covers more features.
- Is the preferred approach for new app development.

With a layered architecture, applications can enforce restrictions on which layers can communicate with other layers. This architecture helps to achieve encapsulation. When a layer is changed or replaced, only those layers that work with it should be impacted. By limiting which layers depend on which other layers, the impact of changes can be mitigated so that a single change doesn't impact the entire application.

## You will find answers to the following questions

- How do we develop a project with N-Layer Architecture?
- How to use the Code First Approach with Entity Framework Core 5.0?
- How do We Configure a Detailed Database with the Fluent API?
- How do we apply a Generic Repository Design Pattern
- How to implement a Unit of Work Design Pattern?
- What can we do with Asynchronous Programming.
- How do we implement Object-Oriented Programming in our project
- How do we make Front-End Validations with Data Annotations
- How do we implement Dependency Injection on Layered Architecture.
- Is it necessary to write Extension Methods
- What is the Result Structure
- How do we use DTO (Data Transfer Object)
- Use of the AutoMapper Library
- How to Perform the Use of the AutoMapper Library
- How to apply Paging, Sorting, Filtering to a our project.
- How do we perform Image & File Upload Operations.
- How do we set up the Authentication & Authorization mechanization.
- How do we write javascript-based software such as Ajax, Jquery.
- How do I integrate Toaster, DataTables, Trumbowyg, Select2.





### Built With

This section should list any major frameworks/libraries used to bootstrap your project. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.

* [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-6.0)
* [AJAX](https://developer.mozilla.org/en-US/docs/Web/Guide/AJAX/Getting_Started)
* [Jquerry](https://jquery.com/)
* [Bootstrap](https://getbootstrap.com/)

### Technologies and Methods

- Developing a Project With N Layered Architecture
- Entity Framework Core 5.0 Code First
- Database Configurations With Fluent API
- Generic Repository Pattern
- Unit of Work Pattern
- Async Programming
- OOP
- Dependency Injection In N Layered Architecture
- Extension Methods
- Custom Result Structure
- DTO (Data Transfer Object)
- AutoMapper AutoMapper Library
- MD5 Password Hashing
- SHA512 Password Hashing
- Paging, Sorting, Filtering
- LINQ
- File & Image Upload
- User Management System with Identity
- Ajax, Jquerry, Jquerry UI
- Sweet Alert2, Toastr, DataTables, Trumbowyg, Select2
- Bootstrap 4.5



<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started


### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* dotnet Blogesque.Data.csproj
  ```sh
   <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="5.0.14" />
   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.14" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="5.0.14">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.14" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.14">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
  ```
  
* dotnet Villagenix.Client.csproj
  ```sh
  <PackageReference Include="Blazored.LocalStorage" Version="3.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.Authorization" Version="5.0.14" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="5.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="5.0.0" />
  <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
  <PackageReference Include="System.Net.Http.Json" Version="5.0.0" />
  ```
  
* dotnet Villagenix.Server.csproj
  ```sh
  <PackageReference Include="AutoMapper" Version="10.1.1" />
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
  <PackageReference Include="Blazored.TextEditor" Version="1.0.3" />
  <PackageReference Include="Microsoft.AspNetCore.Identity" Version="2.2.0" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.2" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2" />
  ```


### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._


1. Clone the repo
   ```sh
   https://github.com/BerkayKulak/Blazor-Villagenix.git
   ```
2. Update Nuget packages
   ```sh
   dotnet tool update <PACKAGE_ID> -g|--global
   ```
3. Add Migration
   ```js
   dotnet ef migrations add InitialCreate
   ```
4. Update Database
   ```js
   dotnet ef database update
   ```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

To clone and run this application, you'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer. From your command line:

```bash
# Go into the repository API
$ cd \Villagenix\Villagenix.API

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Server
$ cd \Villagenix\Villagenix.Server

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Client
$ cd \Villagenix\Villagenix.Client

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj
```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Bug / Feature Request

If you find a bug (the website couldn't handle the query and / or gave undesired results), kindly open an issue [here](https://github.com/BerkayKulak/Blazor-Villagenix/issues/new) by including your search query and the expected result.

If you'd like to request a new function, feel free to do so by opening an issue [here](https://github.com/BerkayKulak/Blazor-Villagenix/issues/new). Please include sample queries and their corresponding results.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Berkay Kulak - (https://www.linkedin.com/in/berkay-kulak-3442311b1/) - kulakberkay15@gmail.com

Project Link:   (https://github.com/BerkayKulak/Blazor-Villagenix)

<p align="right">(<a href="#top">back to top</a>)</p>
